#pragma checksum "C:\Users\Asus\source\repos\DTSMCC_WebApp\DTSMCC_WebApp\Views\Employees\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0b3ab99ac8821bca5159676daeeb8c87d3a2064"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Update), @"mvc.1.0.view", @"/Views/Employees/Update.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0b3ab99ac8821bca5159676daeeb8c87d3a2064", @"/Views/Employees/Update.cshtml")]
    public class Views_Employees_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DTSMCC_WebApp.Models.Employees>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Asus\source\repos\DTSMCC_WebApp\DTSMCC_WebApp\Views\Employees\Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Update</h1>

<h4>Employees</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Update"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""EmployeeId"" class=""control-label""></label>
                <input asp-for=""EmployeeId"" class=""form-control"" />
                <span asp-validation-for=""EmployeeId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EmployeeName"" class=""control-label""></label>
                <input asp-for=""EmployeeName"" class=""form-control"" />
                <span asp-validation-for=""EmployeeName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IdJob"" class=""control-label""></label>
                <input asp-for=""IdJob"" class=""form-control"" />
                <span asp-validation-for=""IdJob"" class=""text-");
            WriteLiteral(@"danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\Asus\source\repos\DTSMCC_WebApp\DTSMCC_WebApp\Views\Employees\Update.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DTSMCC_WebApp.Models.Employees> Html { get; private set; }
    }
}
#pragma warning restore 1591
