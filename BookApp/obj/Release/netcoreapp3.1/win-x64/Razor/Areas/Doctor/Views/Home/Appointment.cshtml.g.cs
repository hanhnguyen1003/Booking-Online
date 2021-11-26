#pragma checksum "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\Appointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2505ad6a0c4ac4429ab755e9f7d71f15f657c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Doctor_Views_Home_Appointment), @"mvc.1.0.view", @"/Areas/Doctor/Views/Home/Appointment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2505ad6a0c4ac4429ab755e9f7d71f15f657c01", @"/Areas/Doctor/Views/Home/Appointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936686af5605e9bafa5b30940e0797dea7e9f5a6", @"/Areas/Doctor/Views/_ViewImports.cshtml")]
    public class Areas_Doctor_Views_Home_Appointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\Appointment.cshtml"
  
    ViewData["Title"] = "Appointment";
    Layout = "~/Areas/Doctor/Views/Shared/_LayoutDoctor.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Main Wrapper -->
<div class=""main-wrapper"">
    <!-- Page Content -->
    <div class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-7 col-lg-8 col-xl-12"">
                    <div class=""appointments"" id=""bodycontentdoctor"">
                    </div>
                </div>
            </div>
        </div>

    </div>
    <!-- /Page Content -->
    <!-- Footer -->
    <!-- /Footer -->

</div>
<!-- /Main Wrapper -->
<!-- Appointment Details Modal -->
<div class=""modal fade custom-modal"" id=""appt_details"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Appointment Details</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div c");
            WriteLiteral(@"lass=""modal-body"">
                <ul class=""info-details"">
                    <li>
                        <div class=""details-header"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <span class=""title"">#APT0001</span>
                                    <span class=""text"">21 Oct 2019 10:00 AM</span>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""text-right"">
                                        <button type=""button"" class=""btn bg-success-light btn-sm"" id=""topup_status"">Completed</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </li>
                    <li>
                        <span class=""title"">Status:</span>
                        <span class=""text"">Completed</span>
 ");
            WriteLiteral(@"                   </li>
                    <li>
                        <span class=""title"">Confirm Date:</span>
                        <span class=""text"">29 Jun 2019</span>
                    </li>
                    <li>
                        <span class=""title"">Paid Amount</span>
                        <span class=""text"">$450</span>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>

<!-- doccure/appointments.html  30 Nov 2019 04:12:09 GMT -->
<script>
    var j = jQuery.noConflict();
    colors = ['#B22222', 'DarkOrange', 'Gold', 'LawnGreen', 'DodgerBlue', 'Aqua', 'DeepPink','LightSeaGreen']
    j(document).ready(() => {
 let id = """);
#nullable restore
#line 76 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\Appointment.cshtml"
      Write(ViewBag.userId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
        console.log(id);
        j.post('/Doctor/home/GetPKBByIdEmp', { id: id }, (d) => {
            console.log(d);
            if (d.length > 0) {
                let str=''
                for (var i = 0; i < d.length; i++) {
                    str += `
                        <div class=""appointment-list"">
                            <div class=""profile-info-widget"">
                                <h6 class=""booking-doc-img"" style=""color:${(colors.length-1)>i?colors[i]:'black'}"">${d[i].sttPatient}
                                </h6>
                                <div class=""profile-det-info"">
                                    <h3>${d[i].namePatient}</h3>
                                    <div class=""patient-details"">
                                        <h5><i class=""far fa-clock""></i>${moment(d[i].dated).format('DD/MM/YYYY')}, Khung giờ:${d[i].rangeTime} AM</h5>
                                        <h5><i class=""fas fa-map-marker-alt""></i>${d[i].addP}</h5>
          ");
            WriteLiteral(@"                          </div>
                                </div>
                            </div>
                            <div class=""appointmenViewBag-action"">
                                <a href=""/Doctor/Home/PatientProfile/${d[i].idPatient}"" class=""btn btn-sm bg-info-light"" data-target=""#appt_details"">
                                    <i class=""far fa-edit""></i> Chẩn đoán
                                </a>
                                <a href=""javascript:void(0);"" class=""btn btn-sm bg-success-light"">
                                    <i class=""fas fa-check""></i> Hoàn tất
                                </a>
                            </div>
                        </div>`
                }
                bodycontentdoctor.innerHTML = str;

            }

        })
    })
</script>
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
