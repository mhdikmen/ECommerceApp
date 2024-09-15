namespace BuildingBlocks.Responses;

public record BaseResponse
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; } = default!;
    public BaseResponse(bool isSuccess, string message)
    {
        IsSuccess = isSuccess;
        Message = message;
    }
}

public record BaseResponse<T> : BaseResponse
{
    public T? Data { get; set; }
    public BaseResponse(bool isSuccess, string message, T data) : base(isSuccess, message)
    {
        Data = data;
    }
}
