﻿namespace WinTail
{
    using Akka.Actor;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Monitors the file at <see cref="_filePath"/> for changes and sends
    /// file updates to console.
    /// </summary>
    public class TailActor : UntypedActor
    {
        #region Message types

        /// <summary>
        /// Signal that the file has changed, and we need to read the next line of the file
        /// </summary>
        public class FileWrite
        {
            public string FileName { get; }

            public FileWrite(string fileName)
            {
                FileName = fileName;
            }
        }

        /// <summary>
        /// Signal that the OS had an error accessing the file
        /// </summary>
        public class FileError
        {
            public string FileName { get; }
            public string Reason { get; }

            public FileError(string fileName, string reason)
            {
                FileName = fileName;
                Reason = reason;
            }
        }

        /// <summary>
        /// Signal to read the initial contents of the file at actor startup
        /// </summary>
        public class InitialRead
        {
            public string FileName { get; }
            public string Text { get; }

            public InitialRead(string fileName, string text)
            {
                FileName = fileName;
                Text = text;
            }
        }

        #endregion

        readonly string _filePath;
        readonly IActorRef _reporterActor;
        readonly FileObserver _observer;
        readonly Stream _fileStream;
        readonly StreamReader _fileStreamReader;

        public TailActor(IActorRef reporterActor, string filePath)
        {
            _reporterActor = reporterActor;
            _filePath = filePath;

            //start watching one file for changes
            _observer = new FileObserver(Self, Path.GetFullPath(_filePath));
            _observer.Start();

            //open the file stream with shared read/write permissions (so file can be written to while open)
            _fileStream = new FileStream(Path.GetFullPath(_filePath), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            _fileStreamReader = new StreamReader(_fileStream, Encoding.UTF8);

            //read the initial contents of the file and send it to console as first msg
            var text = _fileStreamReader.ReadToEnd();
            Self.Tell(new InitialRead(_filePath, text));
        }

        protected override void OnReceive(object message)
        {
            if (message is FileWrite)
            {
                //move file cursor forward
                //pull results from cursor to end of file and write to output
                //this is assuming a log file type format that is append-only)
                var text = _fileStreamReader.ReadToEnd();
                if (!string.IsNullOrEmpty(text))
                {
                    _reporterActor.Tell(text);
                }
            }
            else if (message is FileError fe)
            {
                _reporterActor.Tell($"Tail error: {fe.Reason}");
            }
            else if (message is InitialRead ir)
            {
                _reporterActor.Tell(ir.Text);
            }
        }
    }
}
