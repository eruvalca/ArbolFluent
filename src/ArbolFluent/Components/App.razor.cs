using Microsoft.AspNetCore.Components;

namespace ArbolFluent.Components;

public sealed partial class App
{
    [CascadingParameter] private HttpContext HttpContext { get; set; } = default!;
}
