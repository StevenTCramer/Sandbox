using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;

public abstract partial class BaseEditor<T> : ComponentBase
{
  private T? _valueProxy;

  [CascadingParameter]
  public bool IsReadOnly { get; set; }
    
  [Parameter]
  public T? Value
  {
    get => _valueProxy;
    set
    {
      if (!EqualityComparer<T?>.Default.Equals(_valueProxy, value))
      {
        _valueProxy = value;
        ValueChanged.InvokeAsync(value);
      }
    }
  }

  [Parameter]
  public EventCallback<T?> ValueChanged { get; set; }

  [Parameter]
  public Expression<Func<T?>>? ValueExpression { get; set; }

  [Parameter]
  public string? Label { get; set; }
  public abstract string ControlName { get; }

  protected string ControlId => ControlName + Guid.NewGuid().ToString("N");

  protected override void OnParametersSet()
  {
    _valueProxy = Value; // Sync the proxy with the incoming parameter
  }
}