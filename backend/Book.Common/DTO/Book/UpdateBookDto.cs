﻿namespace Book.Common.DTO.Book;

public class UpdateBookDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int PageCount { get; set; }
}