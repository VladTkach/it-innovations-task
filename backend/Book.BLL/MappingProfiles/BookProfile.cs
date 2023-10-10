using AutoMapper;
using Book.Common.DTO.Book;

namespace Book.BLL.MappingProfiles;

public class BookProfile: Profile
{
    public BookProfile()
    {
        CreateMap<DAL.Entities.Book, BookDto>().ReverseMap();
    }
}