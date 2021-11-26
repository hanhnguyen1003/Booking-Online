#pragma checksum "D:\Project\BookApp\BookApp\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe4277b0794a541c216ffe74732307d6a310beb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "D:\Project\BookApp\BookApp\Areas\Admin\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\BookApp\BookApp\Areas\Admin\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4277b0794a541c216ffe74732307d6a310beb7", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936686af5605e9bafa5b30940e0797dea7e9f5a6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Project\BookApp\BookApp\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <!-- Page Header -->
        <div class=""page-header"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <h3 class=""page-title"">Welcome Admin!</h3>
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb-item active"">Dashboard</li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- /Page Header -->

        <div class=""row"">
            <div class=""col-xl-3 col-sm-6 col-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""dash-widget-header"">
                            <span class=""dash-widget-icon text-primary border-primary"">
                                <i class=""fe fe-users""></i>
                            </span>
                            <div class=""dash-count"">
                                <h3>168</h3>
                            </div>
                        </div>
      ");
            WriteLiteral(@"                  <div class=""dash-widget-info"">
                            <h6 class=""text-muted"">Doctors</h6>
                            <div class=""progress progress-sm"">
                                <div class=""progress-bar bg-primary w-50""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-sm-6 col-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""dash-widget-header"">
                            <span class=""dash-widget-icon text-success"">
                                <i class=""fe fe-credit-card""></i>
                            </span>
                            <div class=""dash-count"">
                                <h3>487</h3>
                            </div>
                        </div>
                        <div class=""dash-widget-info"">

                            ");
            WriteLiteral(@"<h6 class=""text-muted"">Patients</h6>
                            <div class=""progress progress-sm"">
                                <div class=""progress-bar bg-success w-50""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-sm-6 col-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""dash-widget-header"">
                            <span class=""dash-widget-icon text-danger border-danger"">
                                <i class=""fe fe-money""></i>
                            </span>
                            <div class=""dash-count"">
                                <h3>485</h3>
                            </div>
                        </div>
                        <div class=""dash-widget-info"">

                            <h6 class=""text-muted"">Appointment</h6>
                            <");
            WriteLiteral(@"div class=""progress progress-sm"">
                                <div class=""progress-bar bg-danger w-50""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-sm-6 col-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""dash-widget-header"">
                            <span class=""dash-widget-icon text-warning border-warning"">
                                <i class=""fe fe-folder""></i>
                            </span>
                            <div class=""dash-count"">
                                <h3>$62523</h3>
                            </div>
                        </div>
                        <div class=""dash-widget-info"">

                            <h6 class=""text-muted"">Revenue</h6>
                            <div class=""progress progress-sm"">
                               ");
            WriteLiteral(@" <div class=""progress-bar bg-warning w-50""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12 col-lg-6"">

                <!-- Sales Chart -->
                <div class=""card card-chart"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">Revenue</h4>
                    </div>
                    <div class=""card-body"">
                        <div id=""morrisArea""></div>
                    </div>
                </div>
                <!-- /Sales Chart -->

            </div>
            <div class=""col-md-12 col-lg-6"">

                <!-- Invoice Chart -->
                <div class=""card card-chart"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">Status</h4>
                    </div>
                    <div class=""card-bod");
            WriteLiteral(@"y"">
                        <div id=""morrisLine""></div>
                    </div>
                </div>
                <!-- /Invoice Chart -->

            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 d-flex"">

                <!-- Recent Orders -->
                <div class=""card card-table flex-fill"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">Doctors List</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover table-center mb-0"">
                                <thead>
                                    <tr>
                                        <th>Doctor Name</th>
                                        <th>Speciality</th>
                                        <th>Earned</th>
                                        <th>Reviews</th>
                      ");
            WriteLiteral(@"              </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/doctors/doctor-thumb-01.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Dr. Ruby Perrin</a>
                                            </h2>
                                        </td>
                                        <td>Dental</td>
                                        <td>$3200.00</td>
                                        <td>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                              ");
            WriteLiteral(@"              <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star-o text-secondary""></i>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/doctors/doctor-thumb-02.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Dr. Darren Elder</a>
                                            </h2>
                                        </td>
                                        <td>Dental</td>
                                        <td>$3100.00</td>
                              ");
            WriteLiteral(@"          <td>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star-o text-secondary""></i>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/doctors/doctor-thumb-03.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Dr. Deborah Angel</a>
                           ");
            WriteLiteral(@"                 </h2>
                                        </td>
                                        <td>Cardiology</td>
                                        <td>$4000.00</td>
                                        <td>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star-o text-secondary""></i>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img cla");
            WriteLiteral(@"ss=""avatar-img rounded-circle"" src=""/assets/img/doctors/doctor-thumb-04.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Dr. Sofia Brient</a>
                                            </h2>
                                        </td>
                                        <td>Urology</td>
                                        <td>$3200.00</td>
                                        <td>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star-o text-secondary""></i>
                                        </td>
                                    </tr>
                                    <tr>
         ");
            WriteLiteral(@"                               <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/doctors/doctor-thumb-05.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Dr. Marvin Campbell</a>
                                            </h2>
                                        </td>
                                        <td>Orthopaedics</td>
                                        <td>$3500.00</td>
                                        <td>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
                                            <i class=""fe fe-star text-warning""></i>
     ");
            WriteLiteral(@"                                       <i class=""fe fe-star-o text-secondary""></i>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!-- /Recent Orders -->

            </div>
            <div class=""col-md-6 d-flex"">

                <!-- Feed Activity -->
                <div class=""card  card-table flex-fill"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">Patients List</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover table-center mb-0"">
                                <thead>
                                    <tr>
                                        <th>Patient Name</th>
          ");
            WriteLiteral(@"                              <th>Phone</th>
                                        <th>Last Visit</th>
                                        <th>Paid</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/patients/patient1.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Charlene Reed </a>
                                            </h2>
                                        </td>
                                        <td>8286329170</td>
                                        <td>20 Oct 2019</td>
                                        <td class=""text-right""");
            WriteLiteral(@">$100.00</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/patients/patient2.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Travis Trimble </a>
                                            </h2>
                                        </td>
                                        <td>2077299974</td>
                                        <td>22 Oct 2019</td>
                                        <td class=""text-right"">$200.00</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
            ");
            WriteLiteral(@"                                    <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/patients/patient3.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Carl Kelly</a>
                                            </h2>
                                        </td>
                                        <td>2607247769</td>
                                        <td>21 Oct 2019</td>
                                        <td class=""text-right"">$250.00</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/patients/patient4.jpg"" alt=""User Image""></a>
                                           ");
            WriteLiteral(@"     <a href=""profile.html""> Michelle Fairfax</a>
                                            </h2>
                                        </td>
                                        <td>5043686874</td>
                                        <td>21 Sep 2019</td>
                                        <td class=""text-right"">$150.00</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/patients/patient5.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Gina Moore</a>
                                            </h2>
                                        </td>
                                        <td>9548207887</td>
                        ");
            WriteLiteral(@"                <td>18 Sep 2019</td>
                                        <td class=""text-right"">$350.00</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!-- /Feed Activity -->

            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">

                <!-- Recent Orders -->
                <div class=""card card-table"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">Appointment List</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover table-center mb-0"">
                                <thead>
                                    <tr>
                                        <th>Doctor Name</th>");
            WriteLiteral(@"
                                        <th>Speciality</th>
                                        <th>Patient Name</th>
                                        <th>Apointment Time</th>
                                        <th>Status</th>
                                        <th class=""text-right"">Amount</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/doctors/doctor-thumb-01.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Dr. Ruby Perrin</a>
                                            </h2>
                                        </td>
               ");
            WriteLiteral(@"                         <td>Dental</td>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/patients/patient1.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Charlene Reed </a>
                                            </h2>
                                        </td>
                                        <td>9 Nov 2019 <span class=""text-primary d-block"">11.00 AM - 11.15 AM</span></td>
                                        <td>
                                            <div class=""status-toggle"">
                                                <input type=""checkbox"" id=""status_1"" class=""check"" checked>
                                                <label for=""status_1"" class=""checktoggle"">checkbox</label>
              ");
            WriteLiteral(@"                              </div>
                                        </td>
                                        <td class=""text-right"">
                                            $200.00
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/doctors/doctor-thumb-02.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Dr. Darren Elder</a>
                                            </h2>
                                        </td>
                                        <td>Dental</td>
                                        <td>
                                            <h2 class=""table-avatar"">");
            WriteLiteral(@"
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/patients/patient2.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Travis Trimble </a>
                                            </h2>
                                        </td>

                                        <td>5 Nov 2019 <span class=""text-primary d-block"">11.00 AM - 11.35 AM</span></td>
                                        <td>
                                            <div class=""status-toggle"">
                                                <input type=""checkbox"" id=""status_2"" class=""check"" checked>
                                                <label for=""status_2"" class=""checktoggle"">checkbox</label>
                                            </div>
                                        </td>
                                        <td class=""text-right"">
    ");
            WriteLiteral(@"                                        $300.00
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/doctors/doctor-thumb-03.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Dr. Deborah Angel</a>
                                            </h2>
                                        </td>
                                        <td>Cardiology</td>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/a");
            WriteLiteral(@"ssets/img/patients/patient3.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Carl Kelly</a>
                                            </h2>
                                        </td>
                                        <td>11 Nov 2019 <span class=""text-primary d-block"">12.00 PM - 12.15 PM</span></td>
                                        <td>
                                            <div class=""status-toggle"">
                                                <input type=""checkbox"" id=""status_3"" class=""check"" checked>
                                                <label for=""status_3"" class=""checktoggle"">checkbox</label>
                                            </div>
                                        </td>
                                        <td class=""text-right"">
                                            $150.00
                                        </td>
                                    </tr>
                ");
            WriteLiteral(@"                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/doctors/doctor-thumb-04.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Dr. Sofia Brient</a>
                                            </h2>
                                        </td>
                                        <td>Urology</td>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/patients/patient4.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html""> Michelle Fairfax</a>
         ");
            WriteLiteral(@"                                   </h2>
                                        </td>
                                        <td>7 Nov 2019<span class=""text-primary d-block"">1.00 PM - 1.20 PM</span></td>
                                        <td>
                                            <div class=""status-toggle"">
                                                <input type=""checkbox"" id=""status_4"" class=""check"" checked>
                                                <label for=""status_4"" class=""checktoggle"">checkbox</label>
                                            </div>
                                        </td>
                                        <td class=""text-right"">
                                            $150.00
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <h2 class=""table-avatar"">
             ");
            WriteLiteral(@"                                   <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/doctors/doctor-thumb-05.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Dr. Marvin Campbell</a>
                                            </h2>
                                        </td>
                                        <td>Orthopaedics</td>
                                        <td>
                                            <h2 class=""table-avatar"">
                                                <a href=""profile.html"" class=""avatar avatar-sm mr-2""><img class=""avatar-img rounded-circle"" src=""/assets/img/patients/patient5.jpg"" alt=""User Image""></a>
                                                <a href=""profile.html"">Gina Moore</a>
                                            </h2>
                                        </td>

                                        <td>15 Nov 2019 <span cl");
            WriteLiteral(@"ass=""text-primary d-block"">1.00 PM - 1.15 PM</span></td>
                                        <td>
                                            <div class=""status-toggle"">
                                                <input type=""checkbox"" id=""status_5"" class=""check"" checked>
                                                <label for=""status_5"" class=""checktoggle"">checkbox</label>
                                            </div>
                                        </td>
                                        <td class=""text-right"">
                                            $200.00
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!-- /Recent Orders -->

            </div>
        </div>
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
