namespace DemoWeb.Models
{
    public class Response
    {
        public Response(ResponseCode code, string message = "")
        {
            Code = code;
            Message = message;
        }

        /// <summary>
        /// 狀態代碼
        /// </summary>
        public ResponseCode Code { get; set; }

        /// <summary>
        /// 狀態訊息
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }

    public class Response<T> : Response
    {
        public Response(T data, ResponseCode code,  string message = "") : base(code, message)
        {
            Data = data;
        }
        
        public T? Data { get; set; } = default!;
    }

    public enum ResponseCode
    {
        Success = 0,
        Error = 1,
        Warning = 2,
        Info = 3
    }
}
