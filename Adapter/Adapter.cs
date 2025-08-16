namespace DesignPatterns.Adapter
{
    // 3. Adapter - makes ThirdPartyLogger fit IMyLogger interface
    internal class Adapter : IMyLogger
    {
        private readonly ThirdPartyLogger _thirdpartylogger;

        public Adapter(ThirdPartyLogger thirdpartylogger)
        {
            _thirdpartylogger = thirdpartylogger;
        }

        public void LogInfo(string msg)
        {
            // Will write some logic to make MyLogger,cs compatible with ThirdPartLogger.cs
            _thirdpartylogger.WriteLog("Success",msg);
        }

        public void LogError(string msg)
        {
            // Will write some logic to make MyLogger,cs compatible with ThirdPartLogger.cs
            _thirdpartylogger.WriteLog("Error", msg);
        }
    }
}