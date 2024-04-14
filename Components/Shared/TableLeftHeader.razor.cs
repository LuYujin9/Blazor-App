namespace BlazorApp.Components.Shared;

using Global;
using Microsoft.AspNetCore.Components;

public partial class TableLeftHeader
{
    [Parameter]
    public List<Team>? TeamInfo { get; set; }

    [Parameter]
    public int UserCount { get; set; }
}