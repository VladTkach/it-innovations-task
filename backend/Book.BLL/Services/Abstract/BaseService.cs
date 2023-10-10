using AutoMapper;
using Book.DAL.Context;

namespace Book.BLL.Services.Abstract;

public abstract class BaseService
{
    private protected readonly BookContext _context;
    private protected readonly IMapper _mapper;

    protected BaseService(BookContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
}