using Library.BLL.Interfaces;
using Library.Common.DTO.Chart;
using Microsoft.AspNetCore.Mvc;

namespace Library.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChartController: ControllerBase
{
    private readonly IChartService _chartService;

    public ChartController(IChartService chartService)
    {
        _chartService = chartService;
    }

    [HttpGet("bar")]
    public async Task<ActionResult<BarChart>> GetBarData()
    {
        return Ok(await _chartService.GetBarDataAsync());
    }
}