#pragma checksum "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2c33d8beee4d0ed59ff6268edc02f0ded5d528f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
#line 1 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commends.DestinationCommand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.GuideResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commends.GuideCommand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c33d8beee4d0ed59ff6268edc02f0ded5d528f", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1cb3ab498e2f5c2ccdba593814a94e3eca43bca", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    tr:nth-child(odd) {
        background: #b0c4de;
    }

    tr:nth-child(even) {
        background: #ffffe0;
    }

    .table thead tr th {
        background: #ff4500;
        color: white !important;
    }
 
</style>


<h1>Yorum Listesi</h1>
<table class=""table table-bordered table table-hover text-center"" style=""border-collapse:collapse;"">
");
            WriteLiteral("    <thead>\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Kullanıcı</th>\r\n            <th>Blog</th>\r\n            <th>Tarih</th>\r\n            <th>Sil</th>\r\n        </tr>\r\n    </thead>\r\n   <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
        foreach(var item in Model)
       {
           sayac++;

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n");
            WriteLiteral("           <td>");
#nullable restore
#line 44 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
          Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 45 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
          Write(item.CommentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("           <td>");
#nullable restore
#line 49 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
          Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 50 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
           Write(((DateTime)item.CommentDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td><a");
            BeginWriteAttribute("href", " href=\"", 1457, "\"", 1508, 2);
            WriteAttributeValue("", 1464, "/Admin/Comment/DeleteComment/", 1464, 29, true);
#nullable restore
#line 51 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 1493, item.CommentID, 1493, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n");
            WriteLiteral("       </tr>\r\n");
#nullable restore
#line 54 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Comment\Index.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
