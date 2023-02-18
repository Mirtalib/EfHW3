using System.Collections.Generic;

namespace UnitOfWorkPractise.Models;

public class Department : BaseEntity
{
    public string? Name { get; set; }

    public List<Teacher>? Teachers { get; set; }
}