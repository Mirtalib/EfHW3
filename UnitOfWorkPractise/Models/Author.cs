using System.Collections.Generic;

namespace UnitOfWorkPractise.Models;

public class Author : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public List<Book>? Books { get; set; }
}
