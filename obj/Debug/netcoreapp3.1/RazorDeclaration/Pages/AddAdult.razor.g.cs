#pragma checksum "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17d7ddbc92d0b8018d87c01e7a524605662c741b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNPAssignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\_Imports.razor"
using DNPAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\_Imports.razor"
using DNPAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\Pages\AddAdult.razor"
using DNPAssignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\Pages\AddAdult.razor"
using DNPAssignment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\Pages\AddAdult.razor"
           [Authorize(Policy = "adultaddaccess")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adultAdd")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "E:\DNP1\Blazor\DNPAssignment\DNPAssignment\Pages\AddAdult.razor"
       
    private Adult newAdult = new Adult();

    private void addNewAdult() {
        AdultHandler.AddAdult(newAdult);
        NavigationManager.NavigateTo("/Adults");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultHandler AdultHandler { get; set; }
    }
}
#pragma warning restore 1591