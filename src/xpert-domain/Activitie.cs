using xpert_domain;

namespace expert_domain;

public class Activitie : BaseObject
{
    public Activitie(string name, string description, List<Activitie> dependencies, List<Activitie> blocks, List<Comment> comments)
    {
        Name = name;
        Description = description;
        Dependencies = dependencies;
        Blocks = blocks;
        Comments = comments;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public List<Activitie> Dependencies { get; set; }
    public List<Activitie> Blocks { get; set; }
    public List<Comment> Comments { get; set; }
}
