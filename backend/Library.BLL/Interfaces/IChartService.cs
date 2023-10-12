using Library.Common.DTO.Chart;

namespace Library.BLL.Interfaces;

public interface IChartService
{
    Task<BarChart> GetBarDataAsync();
}