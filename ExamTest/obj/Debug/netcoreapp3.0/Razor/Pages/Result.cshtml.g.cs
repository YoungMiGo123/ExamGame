#pragma checksum "C:\Users\kleinbooim\Desktop\Exam\ExamTest\ExamTest\Pages\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f29f38126c1cac824af554bc80e0f946ce9c181"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExamTest.Pages.Pages_Result), @"mvc.1.0.razor-page", @"/Pages/Result.cshtml")]
namespace ExamTest.Pages
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
#line 1 "C:\Users\kleinbooim\Desktop\Exam\ExamTest\ExamTest\Pages\_ViewImports.cshtml"
using ExamTest;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f29f38126c1cac824af554bc80e0f946ce9c181", @"/Pages/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"227fb4670b4d0e82f0fb0b195a4ac229f759ceb6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Result : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\kleinbooim\Desktop\Exam\ExamTest\ExamTest\Pages\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\kleinbooim\Desktop\Exam\ExamTest\ExamTest\Pages\Result.cshtml"
Write(Html.Raw(Model.result));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamTest.Pages.ResultModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExamTest.Pages.ResultModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExamTest.Pages.ResultModel>)PageContext?.ViewData;
        public ExamTest.Pages.ResultModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591