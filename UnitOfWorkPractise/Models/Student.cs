using System.Collections.Generic;

namespace UnitOfWorkPractise.Models;

public class Student : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Id_Group { get; set; }

    public Group? Group { get; set; }
    public List<S_Card>? S_Cards { get; set; }
}
