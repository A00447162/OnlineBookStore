#pragma checksum "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47ab782c885f1b26a4ca6ba765de9ddeeae9a360"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publishers_Index), @"mvc.1.0.view", @"/Views/Publishers/Index.cshtml")]
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
#line 1 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\_ViewImports.cshtml"
using TheOnlineBookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\_ViewImports.cshtml"
using TheOnlineBookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47ab782c885f1b26a4ca6ba765de9ddeeae9a360", @"/Views/Publishers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f572d7436897c01dda4fe102cd21ba51f74a81c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Publishers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Publisher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml"
  
    ViewData["Title"] = "List of Publishers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
#nullable restore
#line 13 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.PictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 14 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 15 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.About));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 768, "\"", 790, 1);
#nullable restore
#line 24 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 774, item.PictureURL, 774, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 791, "\"", 807, 1);
#nullable restore
#line 24 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 797, item.Name, 797, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 27 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 30 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.About));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                        <td class=""align-middle"">
                            <a class=""btn btn-outline-primary""><i class=""bi bi-pencil-square""></i>Edit </a> |
                            <a class=""btn btn-outline-info""><i class=""bi bi-eye""></i>Details </a> |
                            <a class=""btn btn-danger text-white""><i class=""bi bi-trash""></i>Delete </a>
                        </td>
                    </tr>
");
#nullable restore
#line 38 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 45 "C:\Users\vaidy\source\repos\TheOnlineBookStore\Views\Publishers\Index.cshtml"
Write(await Html.PartialAsync("_CreateItem", "Publishers"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Publisher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
