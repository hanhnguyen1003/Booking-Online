#pragma checksum "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PresForPatient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ad6b4c47e43aa56cc457fbca27b0b9a4410c53e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Doctor_Views_Home_PresForPatient), @"mvc.1.0.view", @"/Areas/Doctor/Views/Home/PresForPatient.cshtml")]
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
#line 1 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad6b4c47e43aa56cc457fbca27b0b9a4410c53e", @"/Areas/Doctor/Views/Home/PresForPatient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936686af5605e9bafa5b30940e0797dea7e9f5a6", @"/Areas/Doctor/Views/_ViewImports.cshtml")]
    public class Areas_Doctor_Views_Home_PresForPatient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PresForPatient.cshtml"
   Layout = "";
    List<Precription> pres = ViewBag.patients; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PresForPatient.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Doctor/Views/Shared/_LayoutDoctor.cshtml";
    List<Patients> patients = ViewBag.patients;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- doccure/my-patients.html  30 Nov 2019 04:12:09 GMT -->

<style>
    .appointments .appointment-list {
        background-color: #fff;
        border: 1px solid #f0f0f0;
        border-radius: 4px;
        display: -webkit-box;
        display: -ms-flexbox;
        display: flex;
        -ms-flex-wrap: wrap;
        flex-wrap: wrap;
        margin-bottom: 20px;
        padding: 20px;
    }
</style>

<!-- Main Wrapper -->
<div class=""main-wrapper"">

    <div class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12 col-lg-12 col-xl-12"">
                    <div class=""row row-grid"">
");
#nullable restore
#line 35 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PresForPatient.cshtml"
                         foreach (var item in pres)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-md-12 col-lg-12 col-xl-12"">
                                <div class=""appointments"">
                                    <div class=""appointment-list"">
                                        <div class=""profile-info-widget"">

                                            <div class=""profile-det-info"">
                                                <h3>");
#nullable restore
#line 43 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PresForPatient.cshtml"
                                               Write(item.InDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                                <div class=""patient-details"">

                                                    
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 53 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PresForPatient.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n\n\n        </div>\n\n    </div>\n    <!-- /Page Content -->\n    <!-- Footer -->\n    <!-- /Footer -->\n\n</div>\n\n\n\n");
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