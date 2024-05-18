using Cwk.Domain.Aggregates.UserProfileAggregate;

namespace Cwk.Domain.Aggregates.PostAggregate;

public class Post
{
    public Guid PostId { get; set; }
    public Guid UserProfileId { get; set; }
    public UserProfile UserProfile { get; set; }
    public string TextContent { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime LastModified { get; set; }
    public ICollection<PostComment> Comments { get; set; }
    public ICollection<PostInteraction> Interactions { get; set; }
}