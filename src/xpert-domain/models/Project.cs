using expert_domain;

namespace xpert_domain;

public class Project(string name, List<Activitie> activities) : BaseObject()
{
    public string Name { get; set; } = name;
    public decimal Progress { get; set; } = 0;
    public TimeSpan? ExpectedDuration { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public List<Activitie> Activities { get; set; } = activities;
    public List<Comment> Comments { get; set; } = [];
}
