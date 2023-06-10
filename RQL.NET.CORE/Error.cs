namespace RQL.NET.CORE
{
    public class Error : IError
    {
        private readonly string _msg;

        public Error(string msg)
        {
            _msg = msg;
        }

        public string GetMessage()
        {
            return _msg;
        }
    }

    public interface IError
    {
        string GetMessage();
    }
}