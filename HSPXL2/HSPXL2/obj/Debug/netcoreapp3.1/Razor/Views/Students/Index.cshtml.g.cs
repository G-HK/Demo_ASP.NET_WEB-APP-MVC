#pragma checksum "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8394b377b0ef3ba782f3b91207e6ff1d2b616be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\_ViewImports.cshtml"
using HSPXL2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\_ViewImports.cshtml"
using HSPXL2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\_ViewImports.cshtml"
using HSPXL2.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\_ViewImports.cshtml"
using HSPXL2.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8394b377b0ef3ba782f3b91207e6ff1d2b616be", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7aa156879c3860a8ced9c97d0d6089e5cd9c73e", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HSPXL2.Models.StudentIndex>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline d-flex justify-content-center md-form form-sm mt-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::HSPXL2.TagHelpers.DateTagHelper __HSPXL2_TagHelpers_DateTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8394b377b0ef3ba782f3b91207e6ff1d2b616be6635", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8394b377b0ef3ba782f3b91207e6ff1d2b616be7819", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"        <input class=""form-control form-control-sm ml-3 w-50"" name=""name"" type=""text"" placeholder=""Search Is in Development""
               aria-label=""Search"">
        <button type=""submit"" class=""input-group-text cyan lighten-2"">
            <i class=""fas fa-search"" aria-hidden=""true""></i>
        </button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"margin-top:10px; margin-bottom:10px;\">\r\n        <div class=\"card-body\">\r\n            <h3 class=\"card-title\">\r\n                ");
#nullable restore
#line 29 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n        <div class=\"card-body row\">\r\n            <div>\r\n                <h4>Student Info</h4>\r\n                <span>\r\n                    StudentId: ");
#nullable restore
#line 36 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.StudentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span><br />\r\n                <span>\r\n                    Email: ");
#nullable restore
#line 39 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span><br />\r\n                <span>\r\n                    CreationDate: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("date-only", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8394b377b0ef3ba782f3b91207e6ff1d2b616be11839", async() => {
            }
            );
            __HSPXL2_TagHelpers_DateTagHelper = CreateTagHelper<global::HSPXL2.TagHelpers.DateTagHelper>();
            __tagHelperExecutionContext.Add(__HSPXL2_TagHelpers_DateTagHelper);
#nullable restore
#line 42 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
__HSPXL2_TagHelpers_DateTagHelper.Date = item.CreationDate;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("Date", __HSPXL2_TagHelpers_DateTagHelper.Date, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n            <div>\r\n                <h4>Cursusses</h4>\r\n                <ul>\r\n");
#nullable restore
#line 48 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                     foreach (var cur in item.Cursus)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                         if (cur != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
#nullable restore
#line 52 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                           Write(cur.CursusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 53 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                     if(item.Cursus.Count == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <li>Student is niet ingeschreven aan een cursus</li>\r\n");
#nullable restore
#line 58 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"card-footer\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8394b377b0ef3ba782f3b91207e6ff1d2b616be15299", async() => {
                WriteLiteral("\r\n            <i class=\"fa fa-edit\"></i>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                               WriteLiteral(item.StudentID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("|\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8394b377b0ef3ba782f3b91207e6ff1d2b616be17527", async() => {
                WriteLiteral("\r\n            <i class=\"fa fa-info\"></i>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                                  WriteLiteral(item.StudentID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("|\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8394b377b0ef3ba782f3b91207e6ff1d2b616be19758", async() => {
                WriteLiteral("\r\n            <i class=\"fa fa-trash\"></i>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"
                                 WriteLiteral(item.StudentID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 75 "C:\Users\h_kad\Documenten\GitHub\Demo_ASP.NET_WEB-APP-MVC\HSPXL2\HSPXL2\Views\Students\Index.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HSPXL2.Models.StudentIndex>> Html { get; private set; }
    }
}
#pragma warning restore 1591
