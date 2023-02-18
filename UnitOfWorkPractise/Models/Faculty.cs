using System.Collections.Generic;

namespace UnitOfWorkPractise.Models;

public class Faculty : BaseEntity
{
    public string? Name { get; set; }

    public List<Group>? Groups { get; set; }
}