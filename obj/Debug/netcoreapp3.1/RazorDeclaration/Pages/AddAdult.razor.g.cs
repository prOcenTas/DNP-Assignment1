#pragma checksum "D:\Users\F\RiderProjects\DNP\Assignment1\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dff90a1e0423198b0a9ec2e74772781691e7527f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\F\RiderProjects\DNP\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\F\RiderProjects\DNP\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\F\RiderProjects\DNP\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\F\RiderProjects\DNP\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\F\RiderProjects\DNP\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\F\RiderProjects\DNP\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\F\RiderProjects\DNP\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\F\RiderProjects\DNP\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\F\RiderProjects\DNP\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\F\RiderProjects\DNP\Assignment1\Pages\AddAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\F\RiderProjects\DNP\Assignment1\Pages\AddAdult.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\F\RiderProjects\DNP\Assignment1\Pages\AddAdult.razor"
           [Authorize(Policy="MustBeManager")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "D:\Users\F\RiderProjects\DNP\Assignment1\Pages\AddAdult.razor"
       
    private Adult newAdult=new Adult();

    private void AddNewAdult()
    {
        Service.AddAdult(newAdult);
        NavigationManager.NavigateTo("/ViewAdult");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IService Service { get; set; }
    }
}
#pragma warning restore 1591