namespace Cwk.Domain.Aggregates.PostAggregate;

public class PostInteraction
{
    public Guid InteractionId { get; set; }
    public Guid PostId { get; set; }
}