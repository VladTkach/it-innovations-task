using AutoMapper;
using Library.DAL.Context;

namespace Library.BLL.Services.Abstract;

public abstract class BaseService
{
    private protected readonly LibraryContext _context;
    private protected readonly IMapper _mapper;

    protected BaseService(LibraryContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
}