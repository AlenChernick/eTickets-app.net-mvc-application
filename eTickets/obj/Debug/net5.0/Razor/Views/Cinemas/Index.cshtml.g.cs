#pragma checksum "C:\Users\Alen\source\repos\eTickets\eTickets\Views\Cinemas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b00307aed9f8b27053cef8e6d79538621ebf110"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cinemas_Index), @"mvc.1.0.view", @"/Views/Cinemas/Index.cshtml")]
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
#line 1 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b00307aed9f8b27053cef8e6d79538621ebf110", @"/Views/Cinemas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae36ea9afdbf4434090466b2ad951861827cd6f9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cinemas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cinema>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\Cinemas\Index.cshtml"
  
    ViewData["Title"] = "List of Cinemas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    ");
            WriteLiteral(@"@media only screen and (max-width : 960px) {
        .btn {
            margin-block: 0.2rem;
        }

        img {
            width: 104%;
        }

        th {
            font-size: 0.8rem;
        }
    }
</style>


<section class=""row"">
    <div class=""col-md-8 offset-md-2"">
        <table class=""table"">
            <thead>
                <tr class=""text-center text-capitalize"">
                    <th>");
#nullable restore
#line 29 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\Cinemas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 30 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\Cinemas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 31 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\Cinemas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody class=\"shadow-sm\">\r\n");
#nullable restore
#line 36 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\Cinemas\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"text-center\">\r\n                        <td class=\"align-middle shadow-sm\">\r\n                            <img class=\"rounded-circle shadow-sm img-fluid img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 1118, "\"", 1134, 1);
#nullable restore
#line 40 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\Cinemas\Index.cshtml"
WriteAttributeValue("", 1124, item.Logo, 1124, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1135, "\"", 1151, 1);
#nullable restore
#line 40 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\Cinemas\Index.cshtml"
WriteAttributeValue("", 1141, item.Name, 1141, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\r\n                        </td>\r\n                        <td class=\"align-middle text-capitalize shadow-sm\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\Cinemas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle text-capitalize shadow-sm\">\r\n                            ");
#nullable restore
#line 46 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\Cinemas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                        <td class=""align-middle text-center text-capitalize"">
                            <a class=""btn btn-outline-primary mr-1 shadow-sm""><i class=""bi bi-pencil-square mr-1""></i>Edit</a>
                            <a class=""btn btn-outline-info mr-1 shadow-sm""><i class=""bi bi-eye mr-1""></i>Details</a>
                            <a class=""btn btn-outline-danger mr-1 shadow-sm""><i class=""bi bi-trash mr-1""></i>Delete</a>
                        </td>
                    </tr>
");
#nullable restore
#line 54 "C:\Users\Alen\source\repos\eTickets\eTickets\Views\Cinemas\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cinema>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
