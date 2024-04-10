  
namespace BlazorApp.Components.Shared;
using Global;
using Microsoft.AspNetCore.Components;

public partial class TableRow{
  [Parameter]
    public UserInfo? UserData { get; set; }
}