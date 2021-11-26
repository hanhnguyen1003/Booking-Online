#pragma checksum "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe6b3680915bdeebf8e8833551740555e5970ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Doctor_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Doctor/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fe6b3680915bdeebf8e8833551740555e5970ff", @"/Areas/Doctor/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936686af5605e9bafa5b30940e0797dea7e9f5a6", @"/Areas/Doctor/Views/_ViewImports.cshtml")]
    public class Areas_Doctor_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Doctor/Views/Shared/_LayoutDoctor.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card dash-card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-12 col-lg-4"">
                        <div class=""dash-widget dct-border-rht"">
                            <div class=""circle-bar circle-bar1"">
                                <div class=""circle-graph1"" data-percent=""75"">
                                    <img src=""/doc_assets/img/icon-01.png"" class=""img-fluid"" alt=""patient"">
                                </div>
                            </div>
                            <div class=""dash-widget-info"">
                                <h6>Tổng bệnh nhân</h6>
                                <h3>");
#nullable restore
#line 20 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\Index.cshtml"
                               Write(ViewBag.sumexam);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                <p class=""text-muted"">Till Today</p>
                            </div>
                        </div>
                    </div>

                    <div class=""col-md-12 col-lg-4"">
                        <div class=""dash-widget dct-border-rht"">
                            <div class=""circle-bar circle-bar2"">
                                <div class=""circle-graph2"" data-percent=""65"">
                                    <img src=""/doc_assets/img/icon-02.png"" class=""img-fluid"" alt=""Patient"">
                                </div>
                            </div>
                            <div class=""dash-widget-info"">
                                <h6>Bệnh nhân hôm nay</h6>
                                <h3>");
#nullable restore
#line 35 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\Index.cshtml"
                               Write(ViewBag.sumtoday);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                <p class=""text-muted"">06, Nov 2019</p>
                            </div>
                        </div>
                    </div>

                    <div class=""col-md-12 col-lg-4"">
                        <div class=""dash-widget"">
                            <div class=""circle-bar circle-bar3"">
                                <div class=""circle-graph3"" data-percent=""50"">
                                    <img src=""/doc_assets/img/icon-03.png"" class=""img-fluid"" alt=""Patient"">
                                </div>
                            </div>
                            <div class=""dash-widget-info"">
                                <h6>Tổng đăng ký</h6>
                                <h3>");
#nullable restore
#line 50 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\Index.cshtml"
                               Write(ViewBag.sumother);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                <p class=""text-muted"">06, Apr 2019</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <h4 class=""mb-4"">Patient Appoinment</h4>
        <div class=""appointment-tab"">

            <!-- Appointment Tab -->
            <ul class=""nav nav-tabs nav-tabs-solid nav-tabs-rounded"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" href=""#upcoming-appointments"" data-toggle=""tab"">Mới</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#today-appointments"" data-toggle=""tab"">Hôm nay</a>
                </li>
            </ul>
            <!-- /Appointment Tab -->

            <div class=""tab-content"">

                <!-- Upcoming Appointment Tab -->
                <div class=""tab-pane show");
            WriteLiteral(@" active"">
                    <div class=""card card-table mb-0"">
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-hover table-center mb-0"">
                                    <thead>
                                        <tr>
                                            <th>Số thứ tự khám</th>
                                            <th>Họ tên Bệnh nhân</th>
                                            <th>Ngày giờ đăng ký</th>
                                            <th>Giới tính</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tbody id=""upcomingappointments"">
                                        
                                    </tbody>
                                </table>
                            </div>
            ");
            WriteLiteral(@"            </div>
                    </div>
                </div>
                <!-- /Upcoming Appointment Tab -->
                <!-- Today Appointment Tab -->
                <div class=""tab-pane"" id=""today-appointments"">
                    <div class=""card card-table mb-0"">
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-hover table-center mb-0"">
                                    <thead>
                                        <tr>
                                            <th>Số thứ tự khám</th>
                                            <th>Họ tên Bệnh nhân</th>
                                            <th>Ngày giờ đăng ký</th>
                                            <th>Giới tính</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                        ");
            WriteLiteral(@"            <tbody id=""today"">
                                        
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /Today Appointment Tab -->

            </div>
        </div>
    </div>
</div>
<script>
    var j = jQuery.noConflict();
    colors = ['#B22222', 'DarkOrange', 'Gold', 'LawnGreen', 'DodgerBlue', 'Aqua', 'DeepPink','LightSeaGreen']
    j(document).ready(() => {
        let id = """);
#nullable restore
#line 136 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\Index.cshtml"
             Write(ViewBag.userId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
        console.log(id);
        j.post('/Doctor/home/GetPKBByIdEmp', { id: id }, (d) => {
            console.log(d);
            if (d.length > 0) {
                let str = ''
                let str1=''
                for (var i = 0; i < d.length; i++) {
                    str += `
                        <tr>
                                            <td>
                                                <h6 class=""booking-doc-img"" style=""color:${(colors.length - 1) > i ? colors[i] : 'black'}"">${d[i].sttPatient}</h6>
                                            </td>
                                            <td>${d[i].namePatient}</td>
                                            <td>${moment(d[i].dated).format('DD/MM/YYYY')}<span class=""d-block text-info"">${d[i].rangeTime}</span></td>
                                            <td>${d[i].sexP == true ? ""Nữ"" : ""Nam""}</td>
                                            <td class=""text-right"">
                                         ");
            WriteLiteral(@"       <div class=""table-action"">
                                                    <a onclick=""diagnose(this)"" data-id=""${d[i].idPatient}"" data-content=""${JSON.stringify(d[i]).replace(/""/g,""."")}"" class=""btn btn-sm bg-info-light"">
                                                        <i class=""far fa-edit""></i> Chẩn đoán
                                                    </a>

                                                    <a href=""javascript:void(0);"" class=""btn btn-sm bg-success-light"">
                                                        <i class=""fas fa-check""></i> Hoàn tất
                                                    </a>
                                                </div>
                                            </td>
                                        </tr>`
                }
                upcomingappointments.innerHTML = str;
                for (var i = 0; i < d.length; i++) {
                    str1 += `
                        <tr>
                 ");
            WriteLiteral(@"                           <td>
                                                <h6 class=""booking-doc-img"" style=""color:${(colors.length - 1) > i ? colors[i] : 'black'}"">${d[i].sttPatient}</h6>
                                            </td>
                                            <td>${d[i].namePatient}</td>
                                            <td>${moment(d[i].dated).format('DD/MM/YYYY')}<span class=""d-block text-info"">${d[i].rangeTime}</span></td>
                                            <td>${d[i].sexP == true ? ""Nữ"" : ""Nam""}</td>
                                            <td class=""text-right"">
                                                <div class=""table-action"">
                                                    <a onclick=""diagnose(this)"" data-id=""${d[i].idPatient}"" data-content=""${JSON.stringify(d[i]).replace(/""/g, ""."")}"" class=""btn btn-sm bg-info-light"">
                                                        <i class=""far fa-edit""></i> Chẩn đoán
                  ");
            WriteLiteral(@"                                  </a>

                                                    <a href=""javascript:void(0);"" class=""btn btn-sm bg-success-light"">
                                                        <i class=""fas fa-check""></i> Hoàn tất
                                                    </a>
                                                </div>
                                            </td>
                                        </tr>`
                }
                today.innerHTML = str1;

            }

        })
    })
    function diagnose(e) {
        let data = j(e).data('content').replace(/\./g,""\"""");
        let id = j(e).data('id');
        console.log(id, data);
        localStorage.setItem(""PatientChoosed"", data);
        setTimeout(() => {
            window.location.href = ""/doctor/home/patientprofile/"" + id;
        },500)
       
    }
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