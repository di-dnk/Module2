using System;
using System.IO;

namespace LoggerService
{
    public class Starter
    {
        public void Run()
        {
            Random rnd = new Random();
            Action action = new Action();
            
            for (int i = 0; i < 100; i++)
            {
                int index = rnd.Next(1, 4);
                Result result = null;
                switch (index)
                {
                    case 1: 
                        result= action.MessageInfo();
                        break;
                    case 2: 
                        result= action.MessageWarning();
                        break;
                    case 3:
                        result= action.MessageError();
                        break;
                }

                if (!result.Status)
                {
                    Logger.Instance.Log(LogType.Error, $"Action failed by a reason:{result.Message}");                    
                }
            }
            
            File.WriteAllText("log.txt", string.Join("\n", Logger.Instance.Logs));
        }
    }
}