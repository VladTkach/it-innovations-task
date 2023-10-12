namespace Library.Common.DTO.Chart;

public class BarChart
{
    public List<string> Labels { get; set; } = new();
    public List<int> Data { get; set; } = new();
}