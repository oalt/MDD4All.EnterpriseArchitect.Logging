/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using NLog;
using NLog.Targets;
using EAAPI = EA;

namespace MDD4All.EnterpriseArchitect.Logging
{
    public class EaPluginNlogTarget : TargetWithLayout
    {
        private EAAPI.Repository _repository;
        private string _logTabName = "System";

        public EaPluginNlogTarget(EAAPI.Repository repository, string logTabName)
        {
            Name = "EA Logger " + logTabName;
            _repository = repository;
            _logTabName = logTabName;
        }

        protected override void Write(LogEventInfo logEvent)
        {
            string message = logEvent.TimeStamp.ToString() + " [" + logEvent.Level + "] " + logEvent.Message; 

            if (_repository != null)
            {
                _repository.WriteOutput(_logTabName, message, 0);
            }
        }
    }
}
