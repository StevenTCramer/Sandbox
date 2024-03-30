namespace Sample4.Client
{
  using System.Threading.Tasks;

  public partial class Eggs
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