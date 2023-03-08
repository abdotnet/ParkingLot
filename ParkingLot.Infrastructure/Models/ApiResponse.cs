namespace ParkingLot.Infrastructure.Models
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }

        public static ApiResponse<T> GetApiResult(T model, string status = Constants.ResponseCodes.Success,
            string message = "")
        {
            ApiResponse<T> response = new()
            {
                Data = model,
                Status = status,
                Message = message
            };
            return response;
        }
    }
}
