#pragma checksum "E:\netcentricproject\netcentricproject\netcentricproject\Views\Student\ClassIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f3cdec6bdc243da035ba576cce6cb0a884fd052"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ClassIndex), @"mvc.1.0.view", @"/Views/Student/ClassIndex.cshtml")]
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
#line 1 "E:\netcentricproject\netcentricproject\netcentricproject\Views\_ViewImports.cshtml"
using netcentricproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\netcentricproject\netcentricproject\netcentricproject\Views\_ViewImports.cshtml"
using netcentricproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f3cdec6bdc243da035ba576cce6cb0a884fd052", @"/Views/Student/ClassIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bdec2e042f1792c4a2940a41bfb50c7960c79bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_ClassIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Student\ClassIndex.cshtml"
  
    ViewData["Title"] = "ClassIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ClassIndex</h1>\r\n<div class=\"col-md-12\">\r\n    <a");
            BeginWriteAttribute("href", " href=\'", 132, "\'", 179, 1);
#nullable restore
#line 9 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Student\ClassIndex.cshtml"
WriteAttributeValue("", 139, Url.Content("~/Student/AddUpdateClass"), 139, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add New</a>\r\n</div>\r\n<table border=\"1\">\r\n    <thead>\r\n        <tr>\r\n");
#nullable restore
#line 14 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Student\ClassIndex.cshtml"
             foreach (var column in Model.Columns)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>\r\n                    ");
#nullable restore
#line 17 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Student\ClassIndex.cshtml"
               Write(column);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
#nullable restore
#line 19 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Student\ClassIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Student\ClassIndex.cshtml"
         foreach (System.Data.DataRow item in Model.Rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 26 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Student\ClassIndex.cshtml"
                 foreach (System.Data.DataColumn column in Model.Columns)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 29 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Student\ClassIndex.cshtml"
                   Write(item[column]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 31 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Student\ClassIndex.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 34 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Student\ClassIndex.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Data.DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
