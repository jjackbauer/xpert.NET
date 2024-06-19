namespace xpert_domain;

public class Comment : BaseObject
{
    public Comment(Guid userId, string title, string content, List<Comment> replies)
    {
        UserId = userId;
        Title = title;
        Content = content;
        Replies = replies;
    }

    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public List<Comment> Replies { get; set; }
}