namespace Book.Common.DTO.Book;

public class BookDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int PageCount { get; set; }
    public DateTime CreatedAt { get; set; }
}