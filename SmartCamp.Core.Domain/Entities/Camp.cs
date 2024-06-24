namespace SmartCamp.Core.Domain.Entities;

public class Camp : BaseEntity
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}