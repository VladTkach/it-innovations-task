using AutoMapper;
using Library.Common.DTO.Book;

namespace Library.BLL.MappingProfiles;

public class BookProfile: Profile
{
    public BookProfile()
    {
        CreateMap<DAL.Entities.Book, BookDto>().ReverseMap();
    }
}