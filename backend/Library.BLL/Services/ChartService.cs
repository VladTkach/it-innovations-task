using Library.BLL.Interfaces;
using Library.Common.DTO.Chart;

namespace Library.BLL.Services;

public class ChartService: IChartService
{
    private readonly IBookService _bookService;

    public ChartService(IBookService bookService)
    {
        _bookService = bookService;
    }
    
    public async Task<BarChart> GetBarDataAsync()
    {
        var books = await _bookService.GetAllBooksAsync();
        
        var booksByYear = books
            .GroupBy(book => book.CreatedAt.Year)
            .OrderBy(group => group.Key)
            .ToList();
        
        var barChart = new BarChart
        {
            Labels = booksByYear.Select(group => group.Key.ToString()).ToList(),
            Data = booksByYear.Select(group => group.Count()).ToList()
        };

        return barChart;
    }
}