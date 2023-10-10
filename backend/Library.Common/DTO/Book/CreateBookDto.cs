namespace Library.Common.DTO.Book;

public class CreateBookDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int PageCount { get; set; }
}