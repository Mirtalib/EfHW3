using System.Collections.Generic;

namespace UnitOfWorkPractise.Models;

public class Theme : BaseEntity
{
    public string? Name { get; set; }
 
    public List<Book>? Books { get; set; }
}