using Microsoft.JSInterop;

public class ChartService
{
    private readonly IJSRuntime _js;

    public ChartService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task RenderLineChart(string id, string[] labels, double[] data)
    {
        await _js.InvokeVoidAsync(
            "chartInterop.renderLineChart",
            id,
            labels,
            data
        );
    }
}