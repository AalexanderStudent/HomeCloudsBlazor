#pragma checksum "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f19548ad1b0065d84217d944eaa50d8383161bae"
// <auto-generated/>
#pragma warning disable 1591
namespace HomeCLoudsBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\_Imports.razor"
using HomeCLoudsBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\App.razor"
using HomeCLoudsBlazor.Components;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(6);
            __builder.AddAttribute(7, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 8 "C:\Users\docuc\RiderProjects\HomeCloudsBlazor\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
            }
            ));
            __builder.AddAttribute(9, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
