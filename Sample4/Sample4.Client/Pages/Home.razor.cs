namespace Sample4.Client.Pages
{
  public partial class Home
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