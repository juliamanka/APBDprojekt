#pragma checksum "C:\Users\Carbon X1\Desktop\APBDprojekt\Pages\StudentDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "718789a2b93559555509971364ad5a1015e71b22"
// <auto-generated/>
#pragma warning disable 1591
namespace APBDprojekt.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using APBDprojekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using APBDprojekt.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using APBDprojekt.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Carbon X1\Desktop\APBDprojekt\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students/{ID:int}")]
    public partial class StudentDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Student Details</h3>\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "value", 
#nullable restore
#line 6 "C:\Users\Carbon X1\Desktop\APBDprojekt\Pages\StudentDetails.razor"
               Student.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "value", 
#nullable restore
#line 7 "C:\Users\Carbon X1\Desktop\APBDprojekt\Pages\StudentDetails.razor"
               Student.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "value", 
#nullable restore
#line 8 "C:\Users\Carbon X1\Desktop\APBDprojekt\Pages\StudentDetails.razor"
               Student.BirthDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 9 "C:\Users\Carbon X1\Desktop\APBDprojekt\Pages\StudentDetails.razor"
               Student.Studies

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 10 "C:\Users\Carbon X1\Desktop\APBDprojekt\Pages\StudentDetails.razor"
               Student.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.AddMarkupContent(21, "<button>Return</button>");
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Carbon X1\Desktop\APBDprojekt\Pages\StudentDetails.razor"
       
    [Parameter]
    public int ID {get; set;}
    public Student Student {get;set;}

    protected override void OnInitialized(){
        Student = StudentService.GetStudent(ID);
    }
    private void Return(){
            navigator.NavigateTo("/students");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591
