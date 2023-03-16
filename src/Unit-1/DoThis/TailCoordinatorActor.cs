namespace WinTail
{
    using Akka.Actor;
    using System;

    public class TailCoordinatorActor : UntypedActor
    {
        #region Message types

        /// <summary>
        /// Start tailing the file at user-specified path
        /// </summary>
        public class StartTail
        {
            public string FilePath { get; }
            public IActorRef ReporterActor { get; }
            public StartTail(string filePath, IActorRef reporterActor)
            {
                FilePath = filePath;
                ReporterActor = reporterActor;
            }
        }

        /// <summary>
        /// Stop tailing the file at user-specified path
        /// </summary>
        public class StopTail
        {
            public string FilePath { get; }

            public StopTail(string filePath)
            {
                FilePath = filePath;
            }
        }

        #endregion

        protected override void OnReceive(object message)
        {
            if (message is StartTail msg)
                Context.ActorOf(Props.Create(() => new TailActor(msg.ReporterActor, msg.FilePath)));
        }

        protected override SupervisorStrategy SupervisorStrategy()
        {
            return new OneForOneStrategy(
                10,
                TimeSpan.FromSeconds(30),
                x =>
                {
                    if (x is ArithmeticException) return Directive.Resume;
                    else if (x is NotSupportedException) return Directive.Stop;
                    else return Directive.Restart;
                });
        }
    }
}
