public class Archer
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public BowStyle BowStyle { get; set; }
    public SkillLevel SkillLevel { get; set; }

    public Guid GroupId { get; set; }
}
