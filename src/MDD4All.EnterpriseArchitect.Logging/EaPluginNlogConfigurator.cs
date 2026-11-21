/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using NLog;
using NLog.Config;
using EAAPI = EA;

namespace MDD4All.EnterpriseArchitect.Logging
{
    public class EaPluginNlogConfigurator
    {
        private EaPluginNlogConfigurator()
        { }

        public static void InitializePluginLogging(EAAPI.Repository repository, string logTabName = "System")
        {
            LoggingConfiguration loggingConfig = new LoggingConfiguration();

            EaPluginNlogTarget eaPluginNlogTarget = new EaPluginNlogTarget(repository, logTabName);

            loggingConfig.AddTarget(eaPluginNlogTarget);

            loggingConfig.AddRuleForAllLevels(eaPluginNlogTarget);

            LogManager.Configuration = loggingConfig;

            repository.EnsureOutputVisible(logTabName);
        }
    }
}
