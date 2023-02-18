using System.Collections.Generic;

namespace UnitOfWorkPractise.Models;

public class Group : BaseEntity
{
    public string? Name { get; set; }
    public int Id_Faculty { get; set; }

    public Faculty? Faculty { get; set; }
    public List<Student>? Students { get; set; }
}