using System;

namespace LoggerService
{
    public class Action
    {
        public Result MessageInfo()
        {
            Logger.Instance.Log(LogType.Info, "Start Method");
            return new Result(true, string.Empty);
        }

        public Result MessageWarning()
        {
            Logger.Instance.Log(LogType.Warning, "Skipped logic in method");
            return new Result(true, string.Empty);
        }

        public Result MessageError()
        {
            return new Result(false, "I broke a logic");
        }
    }
}