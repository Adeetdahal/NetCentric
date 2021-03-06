#pragma checksum "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47cb7744a7f4924aa6a9e125f3a8d44a024d1c53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marks_StudentMarks), @"mvc.1.0.view", @"/Views/Marks/StudentMarks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47cb7744a7f4924aa6a9e125f3a8d44a024d1c53", @"/Views/Marks/StudentMarks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bdec2e042f1792c4a2940a41bfb50c7960c79bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Marks_StudentMarks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DAL.MarksModels>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
  
    ViewData["Title"] = "StudentMarks";
    int marksCounter = 1 ;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>StudentMarks</h1>\r\n\r\n");
#nullable restore
#line 11 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
 if (Model.ToList().Count>0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th colspan=\"3\" class=\"text-center\">\r\n                Marks Sheet of ");
#nullable restore
#line 17 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
                          Write(Model.ToList()[0].StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <thead class=\"thead-light\">\r\n        <tr>\r\n            <th>\r\n                S.No.\r\n            </th>\r\n\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 29 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
           Write(Html.DisplayNameFor(model => model.SubjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 33 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
           Write(Html.DisplayNameFor(model => model.ObtainedMarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
               Write(marksCounter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
               Write(Html.DisplayFor(modelItem => item.SubjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
               Write(Html.DisplayFor(modelItem => item.ObtainedMarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 56 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"

            marksCounter++;


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr style=\"font-weight:bold\">\r\n            <td colspan=\"2\" class=\"text-right\">\r\n                Total\r\n            </td>\r\n            <td>\r\n\r\n                ");
#nullable restore
#line 68 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
           Write(Model.Sum(x => x.ObtainedMarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n        <tr style=\"font-weight:bold\">\r\n            <td colspan=\"2\" class=\"text-right\">\r\n                Percentage\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
           Write(Model.Average(x => x.ObtainedMarks));

#line default
#line hidden
#nullable disable
            WriteLiteral(" %\r\n\r\n            </td>\r\n        </tr>\r\n\r\n\r\n\r\n\r\n    </tbody>\r\n</table>\r\n");
#nullable restore
#line 87 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        No Result found!!!\r\n    </p>\r\n");
#nullable restore
#line 94 "E:\netcentricproject\netcentricproject\netcentricproject\Views\Marks\StudentMarks.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DAL.MarksModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
