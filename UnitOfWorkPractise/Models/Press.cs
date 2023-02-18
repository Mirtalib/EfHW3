using System.Collections.Generic;

namespace UnitOfWorkPractise.Models;

public class Press : BaseEntity
{
    public string? Name { get; set; }

    public List<Book>? Books { get; set; }
}