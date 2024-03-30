namespace Sample4.Client
{
  using Microsoft.AspNetCore.Components;
  using Microsoft.JSInterop;
  using System.Threading.Tasks;

  public partial class App
  {
    [Inject] private IJSRuntime JSRuntime { get; set; } = null!;
    protected override async Task OnInitializedAsync()
    {
      await base.OnInitializedAsync();
    }

    protected override void OnAfterRender(bool firstRender)
    {
      //throw new NotImplementedException();
      base.OnAfterRender(firstRender);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
      //throw new NotImplementedException();
      if (firstRender)
      {
        await JSRuntime.InvokeVoidAsync("console.log", "Hello from Blazor!");
      }

      await base.OnAfterRenderAsync(firstRender);
    }
  }
}