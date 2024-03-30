namespace Sample4.Client
{
  public partial class Routes
  {
    override protected void OnInitialized()
    {
      base.OnInitialized();
    }

    override protected void OnAfterRender(bool firstRender)
    {
      base.OnAfterRender(firstRender);
    }

    override protected async Task OnAfterRenderAsync(bool firstRender)
    {
      await base.OnAfterRenderAsync(firstRender);
    }
  }
}