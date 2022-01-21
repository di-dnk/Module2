namespace LoggerService
{
    public class Result
    {
        public bool Status { get; private set; }
        public string Message { get; private set; }

        public Result(bool status, string message)
        {
            Status = status;
            Message = message;
        }
    }
}