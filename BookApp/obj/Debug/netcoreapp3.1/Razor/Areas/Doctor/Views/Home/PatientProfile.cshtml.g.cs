#pragma checksum "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbdb3869302b3ff719ce3ab38257b597a50959d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Doctor_Views_Home_PatientProfile), @"mvc.1.0.view", @"/Areas/Doctor/Views/Home/PatientProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbdb3869302b3ff719ce3ab38257b597a50959d1", @"/Areas/Doctor/Views/Home/PatientProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936686af5605e9bafa5b30940e0797dea7e9f5a6", @"/Areas/Doctor/Views/_ViewImports.cshtml")]
    public class Areas_Doctor_Views_Home_PatientProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/doc_assets/js/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/doc_assets/js/bootstrap-datetimepicker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml"
   Layout = "";

    List<Precription> pres = ViewBag.pres;
    int n = 0;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbdb3869302b3ff719ce3ab38257b597a50959d14565", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Doccure</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, user-scalable=0"">

    <!-- Favicons -->
    <link href=""/doc_assets/img/favicon.png"" rel=""icon"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""/doc_assets/css/bootstrap.min.css"">

    <!-- Fontawesome CSS -->
    <link rel=""stylesheet"" href=""/doc_assets/plugins/fontawesome/css/fontawesome.min.css"">
    <link rel=""stylesheet"" href=""/doc_assets/plugins/fontawesome/css/all.min.css"">

    <!-- Main CSS -->
    <link rel=""stylesheet"" href=""/doc_assets/css/style.css"">

    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
        <script src=""/doc_assets/js/html5shiv.min.js""></script>
        <script src=""/doc_assets/js/respond.min.js""></script>
    <![endif]-->

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- Main Wrapper -->
<div class=""main-wrapper"">
    <!-- Breadcrumb -->
    <div class=""breadcrumb-bar"">
        <div class=""container-fluid"">
            <div class=""row align-items-center"">
                <div class=""col-md-12 col-12"">

                    <h2 class=""breadcrumb-title"">Appointment</h2>
                </div>
            </div>
        </div>
    </div>
    <!-- /Breadcrumb -->
    <!-- Header -->
    <!-- Page Content -->
    <div class=""content"">
        <div class=""container-fluid"">

            <div class=""row"">
                <div class=""col-md-5 col-lg-4 col-xl-3 theiaStickySidebar dct-dashbd-lft"">

                    <!-- Profile Widget -->
                    <div class=""card widget-profile pat-widget-profile"">
                        <div class=""card-body"" id=""infoPatient"">                           
                        </div>
                    </div>
                    <!-- /Profile Widget -->

                </div>

                <div ");
            WriteLiteral(@"class=""col-md-7 col-lg-8 col-xl-9 dct-appoinment"">
                    <div class=""card"">
                        <div class=""card-body pt-0"">
                            <div class=""user-tabs"">
                                <ul class=""nav nav-tabs nav-tabs-bottom nav-justified flex-wrap"">
");
            WriteLiteral("                                    <li class=\"nav-item\">\r\n                                        <a class=\"nav-link active\" href=\"#pres\" data-toggle=\"tab\"><span>K?? ????n thu???c</span></a>\r\n                                    </li>\r\n");
            WriteLiteral(@"
                                </ul>
                            </div>
                            <div class=""tab-content"">
                                <!-- Appointment Tab -->
                                <!--<div id=""pat_appointments"" class=""tab-pane fade show active"">
                                    <div class=""card card-table mb-0"">
                                        <div class=""card-body"">
                                            <div class=""table-responsive"">
                                                <table class=""table table-hover table-center mb-0"">
                                                    <thead>
                                                        <tr>
                                                            <th>B??c s??</th>
                                                            <th>Ng??y kh??m</th>
                                                            <th>Ti???n kh??m</th>
                                                            <");
            WriteLiteral(@"th></th>
                                                        </tr>
                                                    </thead>
                                                    <tbody id=""sheet"">
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                </div>-->
                                <!-- /Appointment Tab -->
                                <!-- Prescription Tab -->
                                <div class=""tab-pane fade show active"" id=""pres"">
                                    <div class=""text-right"">
                                        <a href=""/Doctor/Home/Prescription"" class=""add-new-btn"">K?? ????n thu???c</a>
                                    </div>
                                    <div class=""card card-table mb-0"">
                 ");
            WriteLiteral(@"                       <div class=""card-body"">

                                            <div class=""table-responsive"">

                                                <table class=""table table-hover table-center mb-0"">
                                                    <thead>
                                                        <tr>
                                                            <th>STT</th>
                                                            <th>Ng??y t???o </th>
                                                            <th>B??c s??</th>
                                                            <th></th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
");
#nullable restore
#line 123 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml"
                                                         foreach (var item in pres)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <tr>\r\n                                                                <td>");
#nullable restore
#line 126 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml"
                                                                Write(++n);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 127 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml"
                                                               Write(item.InDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                                <td>
                                                                    <h2 class=""table-avatar"">
                                                                        <a href=""doctor-profile.html"" class=""avatar avatar-sm mr-2"">
                                                                            <img class=""avatar-img rounded-circle""");
            BeginWriteAttribute("src", " src=\"", 6717, "\"", 6759, 2);
            WriteAttributeValue("", 6723, "/doc_assets/img/doctors/", 6723, 24, true);
#nullable restore
#line 131 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml"
WriteAttributeValue("", 6747, item.Images, 6747, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"User Image\">\r\n                                                                        </a>\r\n                                                                        <a href=\"doctor-profile.html\">");
#nullable restore
#line 133 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml"
                                                                                                 Write(item.NameEmp);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 133 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml"
                                                                                                                     Write(item.DeptName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>
                                                                    </h2>
                                                                </td>
                                                                <td class=""text-right"">
                                                                    <div class=""table-action"">
                                                                        <a onclick=""viewDetail(this)"" data-content=""");
#nullable restore
#line 138 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml"
                                                                                                                Write(n);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id=\"");
#nullable restore
#line 138 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml"
                                                                                                                              Write(item.IdPres);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btn btn-sm bg-info-light"">
                                                                            <i class=""far fa-eye""></i> Xem toa
                                                                        </a>
                                                                    </div>
                                                                </td>
                                                            </tr>
");
#nullable restore
#line 144 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </tbody>
                                                </table>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                                <!-- /Prescription Tab -->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""submit-section float-right"">
                        <a href=""/Doctor/Home/Index"" class=""btn btn-primary"">Quay l???i</a>
                    </div>
                </div>
            </div>

        </div>

    </div>
    <!-- /Page Content -->

</div>
<!-- /Main Wrapper -->
<!-- Add Medical Records Modal -->
<div class=""modal fade custom-modal"" id=""add_medical_records"">
    <div class=""modal-dialo");
            WriteLiteral(@"g modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 class=""modal-title"">Th??ng tin chi ti???t</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbdb3869302b3ff719ce3ab38257b597a50959d117201", async() => {
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n                    <div class=\"form-group\">\r\n                        <label>Ng??y</label>\r\n                        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 9581, "\"", 9589, 0);
                EndWriteAttribute();
                WriteLiteral(" readonly id=\"mDated\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Ch???n ??o??n</label>\r\n                        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 9801, "\"", 9809, 0);
                EndWriteAttribute();
                WriteLiteral(@" readonly id=""mDiagnose"">
                    </div>
                    <div class=""form-group"">
                        <label>Toa thu???c</label>
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th></th>
                                    <th>T??n thu???c</th>
                                    <th>S??? l?????ng</th>
                                    <th>??VT</th>
                                    <th>Li???u L?????ng</th>
                                    <th>C??ch d??ng</th>
                                </tr>
                            </thead>
                            <tbody id=""msheet""></tbody>
                        </table>
                    </div>
                    <div class=""form-group"">
                        <label>L???i khuy??n</label>
                        <input type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 10775, "\"", 10783, 0);
                EndWriteAttribute();
                WriteLiteral(" readonly id=\"mAdvice\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>L???ch H???n</label>\r\n                        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 10995, "\"", 11003, 0);
                EndWriteAttribute();
                WriteLiteral(@" readonly id=""mAppointment"">
                    </div>
                    <div class=""submit-section text-center"">
                        <button type=""button"" class=""btn btn-secondary submit-btn"" data-dismiss=""modal"">OK</button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- /Add Medical Records Modal -->\r\n<script src=\"/doc_assets/js/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbdb3869302b3ff719ce3ab38257b597a50959d121148", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbdb3869302b3ff719ce3ab38257b597a50959d122188", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""/doc_assets/js/popper.min.js""></script>
<script src=""/doc_assets/js/bootstrap.min.js""></script>
<script src=""/doc_assets/plugins/theia-sticky-sidebar/ResizeSensor.js""></script>
<script src=""/doc_assets/plugins/theia-sticky-sidebar/theia-sticky-sidebar.js""></script>
<script src=""/doc_assets/js/script1.js""></script>
<script>

    var j = jQuery.noConflict();
    j(document).ready(() => {
        let patient = JSON.parse(localStorage.getItem('PatientChoosed'));
        console.log(patient)
        infoPatient.innerHTML =`<div class=""pro-widget-content"">
                                <div class=""profile-info-widget"">
                                    <a href=""#"" class=""booking-doc-img"">
                                    <img src=""/assets/img/patients/user-icon-jpg-28.jpg"" />                                
                                    </a>
                                    <div class=""profile-det-info"">
                                        <h3>${patient.namePatien");
            WriteLiteral(@"t}</h3>

                                        <div class=""patient-details"">
                                            <h5><b>M?? b???nh nh??n :</b> ${patient.idPatient}</h5>
                                            <h5 class=""mb-0""><i class=""fas fa-map-marker-alt""></i> ${patient.addP}</h5>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""patient-info"">
                                <ul>
                                    <li>Ng??y sinh <span>${moment(patient.dob).format('DD/MM/YYYY')}</span></li>
                                    <li>Gi???i t??nh <span>${patient.sexP == true?""N???"":""Nam""}</span></li>
                                </ul>
                            </div>`
    })
    function viewDetail(e) {
        console.log('123')
        let id = j(e).data('id');
        console.log(id);
        let pres =JSON.parse('");
#nullable restore
#line 264 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Home\PatientProfile.cshtml"
                         Write(Html.Raw(Json.Serialize(pres)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
        console.log(pres)
        let m = j(e).data('content')-1;
        console.log(m);
        mDated.value = '';
        mAdvice.value = '';
        mAppointment.value = '';
        mDiagnose.value = '';
        console.log(id);
        j.ajax({
            async: false,
            url: '/doctor/home/GetPresDetailByIdPres',
            data: { id: id },
            success: function (d) {
                console.log(d);
                if (d.length > 0) {
                    str = ''
                    mDated.value = moment(pres[m].inDate).format('DD/MM/YYYY');
                    mAdvice.value = pres[m].advice;
                    mAppointment.value = pres[m].followAppoint;
                    mDiagnose.value = pres[m].diagnose;
                    for (var i = 0; i < d.length; i++) {
                        str +=`<tr><td>${i+1}</td>
                                    <td>${d[i].nameMedicine}</td>
                                    <td>${d[i].quantity}</td>
                                  ");
            WriteLiteral(@"  <td>${d[i].unit}</td>
                                    <td>${d[i].usage}</td>
                                    <td>${d[i].dosage}</td>
                                </tr>`
                    }
                    msheet.innerHTML = str;
                    j('#add_medical_records').modal('show');
                } else {
                    alert('kh??ng c?? d??? li???u')
                }
            }
        })
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
