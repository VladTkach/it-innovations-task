using Library.DAL.Entities.Abstract;

namespace Library.DAL.Entities;

public class Book: BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int PageCount { get; set; }
}