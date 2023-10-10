using AutoMapper;
using Library.Common.DTO.Book;
using Library.DAL.Entities;

namespace Library.BLL.MappingProfiles;

public class BookProfile: Profile
{
    public BookProfile()
    {
        CreateMap<Book, BookDto>().ReverseMap();
        CreateMap<CreateBookDto, Book>();
        CreateMap<UpdateBookDto, Book>();
    }
}