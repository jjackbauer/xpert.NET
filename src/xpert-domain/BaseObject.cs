using System.Net.NetworkInformation;

namespace xpert_domain;

public abstract class BaseObject
{
    public Guid Id { get; set; }
    public bool Deleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public DateTime? LastUpdatedAt { get; set; }
    public List<Change> ChangeLog { get; set; }

    public BaseObject()
    {
        Id = Guid.NewGuid();
        Deleted = false;
        CreatedAt = DateTime.UtcNow;
        ChangeLog = [];
    }
}
