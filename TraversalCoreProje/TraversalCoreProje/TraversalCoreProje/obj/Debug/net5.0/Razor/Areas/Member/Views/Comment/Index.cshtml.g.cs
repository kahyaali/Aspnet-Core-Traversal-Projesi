#pragma checksum "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11fb9783da7d0606ead96a114cc18d2628f4e8fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Comment/Index.cshtml")]
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
#line 1 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\_ViewImports.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11fb9783da7d0606ead96a114cc18d2628f4e8fc", @"/Areas/Member/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"482fb87065e3ce3f5ae1a007d021543e69790139", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Bu view _UserLayoutnu kullanıyor-->
<!--webte aç deyince hata veriyor o yüzden CommentController içinde hangi areayı kullanacağını söyllüyoruz [Area(""Member"")]-->
<!--Login olmadan erişmeye izin vermez izin vermesi için CommentController sayfasına [AllowAnonymous] bu ifadeyi ekliyoruz-->
<!--bu index sayfası areas klasörü altındaki Member klasörü altındaki contollers klasörü altındaki CommentController classının index sayfasıdır -->
<h1>Index</h1>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591