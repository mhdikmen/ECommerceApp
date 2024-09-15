namespace BuildingBlocks.Requests;

public record BaseRequest
{
    public DateTime RequestedTime { get; private set; } = DateTime.Now;
}
