#pragma checksum "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\AjaxCity\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3dcd7dead658eed6d73d202e1707116c66a1299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AjaxCity_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AjaxCity/Index.cshtml")]
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
#line 3 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concreate;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3dcd7dead658eed6d73d202e1707116c66a1299", @"/Areas/Admin/Views/AjaxCity/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1cb3ab498e2f5c2ccdba593814a94e3eca43bca", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AjaxCity_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ali kahya\OneDrive\Masaüstü\C Sharp Projeler\TraversalCoreProje\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\AjaxCity\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>
<h1>Şehir - Ülke İşlemleri</h1>
<br />
<button type=""button"" id=""btngetlist"" class=""btn btn-outline-dark"">Şehir Listesi</button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-outline-info"">Şehir Getir</button>
<button type=""button"" id=""btnaddcity"" class=""btn btn-outline-success"">Şehir Ekle</button>
<button type=""button"" id=""btndeletecity"" class=""btn btn-outline-danger"">Şehir Sil</button>
<button type=""button"" id=""btnupdatecity"" class=""btn btn-outline-primary"">Şehir Güncelle</button>
<br />
<br />


<div id=""citylist"" style=""border:1px solid black padding:2px"">
    Şehir Listesi Gelecek
</div>
<br />

<div style=""border:1px solid black; padding:2px"">
    <input type=""text"" id=""txtid"" placeholder=""Şehir ID Değerini Giriniz"" class=""form-control"" />
</div>
<br />
<div id=""destinationlistgetbyid"" style=""border:1px solid black; padding:2px"">
    ID Değerine Göre Şehir Listesi Gelecek
</div>
<br />

");
            WriteLiteral(@"<div style=""border:1px solid black; padding:2px"">
    <input type=""text"" id=""txtdeleteid"" placeholder=""Silinecek ID Değerini Giriniz"" class=""form-control"" />
</div>
<br />

<div style=""border:1px solid black; padding:2px"">
    <input type=""text"" id=""txtgid"" placeholder=""Güncellenecek ID Değerini Giriniz"" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtgcityname"" placeholder=""Güncellenecek Şehir Adını Giriniz"" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtgkonaklama"" placeholder=""Güncellenecek Konaklama Süresini Giriniz"" class=""form-control"" />
</div>
<br />
<div style=""border:1px solid black; padding:2px"">
");
            WriteLiteral(@"    <input type=""text"" placeholder=""Şehir Adını Giriniz"" class=""form-control"" id=""txtcity"" />
    <br />
    <input type=""text"" placeholder=""Konaklama Süresini Giriniz"" class=""form-control"" id=""txtdaynight"" />
    <br />
    <input type=""text"" placeholder=""Fiyatı Giriniz"" class=""form-control"" id=""txtprice"" />
    <br />
    <input type=""text"" placeholder=""Kişi Sayısını Giriniz"" class=""form-control"" id=""txtcapacity"" />
</div>


");
            WriteLiteral(@"<script>
    $(""#btngetlist"").click(function () {
                $.ajax({
                    contentType: ""application/json"",
                    dataType: ""json"",
                    type: ""get"",
                    url: ""/Admin/AjaxCity/CityList/"",
                    success: function (func1) {
                        let result = jQuery.parseJSON(func1);
                        console.log(result);
                        

                        let tableHtml = ""<table class=table table-bordered><tr><th>Şehir Adı</th><th>Konaklama Süresi</th><th>Fiyat</th></tr>"";
                        $.each(result, (index, value) => {
                            tableHtml += `<tr><td>${value.City}</td> <td>${value.DayNight}</td> <td>${value.Price} ₺</td></tr>`
                        });
                        tableHtml += ""</table>"";

                        $(""#citylist"").html(tableHtml);
                    },
                });
            });

            $(""#btnaddcity"").click(functio");
            WriteLiteral(@"n () {
                let cityValues = {
                    City: $(""#txtcity"").val(),
                    DayNight: $(""#txtdaynight"").val(),
                    Price: $(""#txtprice"").val(),
                    Capacity: $(""#txtcapacity"").val()
                };


                $.ajax({
                    type: ""post"",
                    url: ""/Admin/AjaxCity/AddCityDestination"",
                    data: cityValues,
                    success: function (func2) {
                        let result = jQuery.parseJSON(func2);
                        console.log(result);
                        alert(""Şehir - Rota Başarılı Bir Şekilde Eklendi"");
                    },
                });
            });

            $(""#btngetbyid"").click(x => {
                let id = $(""#txtid"").val();

                $.ajax({
                    contentType: ""application/json"",
                    dataType: ""json"",
                    type: ""Get"",
                    url: ""/Admin/AjaxCity");
            WriteLiteral(@"/GetById/"",
                    data: { DestinationID: id },
                    success: function (func3) {
                        let result = jQuery.parseJSON(func3);
                        console.log(result);
                        let htmlstr = `<table class=table table-bordered><tr><th>Şehir Adı</th><th>Konaklama Süresi</th><th>Fiyat</th><th>Kapasite</th></tr><tr><td>${result.City}</td><td>${result.DayNight}</td><td>${result.Price}</td><td>${result.Capacity}</td></table>`

                        $(""#destinationlistgetbyid"").html(htmlstr);
                    },
                    error: function (err) {
                        $(""#destinationlistgetbyid"").html(""<b>Böyle Bir Şehir Bulunamadı Geçerli Bir ID Değeri Giriniz<b>"");
                    }
                });
            });

            $(""#btndeletecity"").click(x => {
                let id = $(""#txtdeleteid"").val();

                $.ajax({
                    url: ""/Admin/AjaxCity/DeleteCity/"" + id,
               ");
            WriteLiteral(@"     contentType: ""application/json"",
                    dataType: ""json"",
                    type: ""post"",
                success: function (func4) {
                        alert(""Şehir Silindi"");
                    },
                error: function (err) {
                    console.log(err);
                        alert(""Verilen ID Değerli Şehir Bulunamadı"");
                    }
                });
            });

            $(""#btnupdatecity"").click(x => {
                let values = {
                    DestinationID: $(""#txtgid"").val(),
                    City: $(""#txtgcityname"").val(),
                    DayNight: $(""#txtgkonaklama"").val()
                }
                $.ajax({
                    type: ""post"",
                    dataType: ""json"",
                    url: ""/Admin/AjaxCity/UpdateCity/"",
                    data: values,
                    success: function (func5) {
                        alert(""Güncelleme İşlemi Başarılı"");
             ");
            WriteLiteral("       },\r\n                    error: function (err) {\r\n                        alert(\"Verilen ID Değerli Şehir Bulunamadı\");\r\n                    }\r\n                });\r\n            });\r\n</script>\r\n\r\n");
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
