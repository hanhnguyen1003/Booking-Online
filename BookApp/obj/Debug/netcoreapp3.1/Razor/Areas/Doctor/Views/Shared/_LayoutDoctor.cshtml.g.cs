#pragma checksum "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Shared\_LayoutDoctor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67b1f028817bdaff33ef2751f4217c429aa064cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Doctor_Views_Shared__LayoutDoctor), @"mvc.1.0.view", @"/Areas/Doctor/Views/Shared/_LayoutDoctor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67b1f028817bdaff33ef2751f4217c429aa064cd", @"/Areas/Doctor/Views/Shared/_LayoutDoctor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936686af5605e9bafa5b30940e0797dea7e9f5a6", @"/Areas/Doctor/Views/_ViewImports.cshtml")]
    public class Areas_Doctor_Views_Shared__LayoutDoctor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Areas.Admin.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/doc_assets/js/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/doc_assets/js/circle-progress.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html lang=\"en\">\r\n\r\n<!-- doccure/doctor-dashboard.html  30 Nov 2019 04:12:03 GMT -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b1f028817bdaff33ef2751f4217c429aa064cd4310", async() => {
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

    <script src=""/doc_assets/js/jquery.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b1f028817bdaff33ef2751f4217c429aa064cd5286", async() => {
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
                WriteLiteral("\r\n    <script src=\"/doc_assets/js/popper.min.js\"></script>\r\n    <script src=\"/doc_assets/js/bootstrap.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b1f028817bdaff33ef2751f4217c429aa064cd6512", async() => {
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
    <!-- Sticky Sidebar JS -->
    <script src=""/doc_assets/plugins/theia-sticky-sidebar/ResizeSensor.js""></script>
    <script src=""/doc_assets/plugins/theia-sticky-sidebar/theia-sticky-sidebar.js""></script>
    <script src=""/doc_assets/js/script1.js""></script>

    <style>
        .profile-info-widget .booking-doc-img {
            margin-right: 20px;
            font-size: 40px;
            color: #370be7
        }

        h6.booking-doc-img {
            font-size: 2.5rem;
        }
    </style>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b1f028817bdaff33ef2751f4217c429aa064cd8842", async() => {
                WriteLiteral(@"
    <!-- Main Wrapper -->
    <div class=""main-wrapper"">

        <!-- Breadcrumb -->
        <div class=""breadcrumb-bar"">
            <div class=""container-fluid"">
                <div class=""row align-items-center"">
                    <div class=""col-md-12 col-12"">

                        <h2 class=""breadcrumb-title"">Trang chủ</h2>
                    </div>
                </div>
            </div>
        </div>
        <!-- /Breadcrumb -->
        <!-- Page Content -->
        <div class=""content"">
            <div class=""container-fluid"">

                <div class=""row"">
                    <div class=""col-md-5 col-lg-4 col-xl-3 theiaStickySidebar"">

                        <!-- Profile Sidebar -->
                        <div class=""profile-sidebar"">
                            <div class=""widget-profile pro-widget-content"">
                                <div class=""profile-info-widget"">
                                    <a href=""#"" class=""booking-doc-img"">
        ");
                WriteLiteral(@"                                <img src=""/doc_assets/img/doctors/doctor-thumb-02.jpg"" alt=""User Image"">
                                    </a>
                                    <div class=""profile-det-info"">
                                        <h3 id=""username""></h3>
                                    </div>
                                </div>
                            </div>
                            <div class=""dashboard-widget"">
                                <nav class=""dashboard-menu"">
                                    <ul>
                                        <li>
                                            <a href=""/Doctor/Home/Index"">
                                                <i class=""fas fa-columns""></i>
                                                <span>Trang chủ</span>
                                            </a>
                                        </li>
                                        <li>
                                           ");
                WriteLiteral(@" <a href=""/Doctor/Home/Appointment"">
                                                <i class=""fas fa-calendar-check""></i>
                                                <span>Danh sách đăng ký</span>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""/Doctor/Home/ListPatient"">
                                                <i class=""fas fa-user-injured""></i>
                                                <span>Danh sách Bệnh nhân</span>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""/Users/Auth/ChangePass"">
                                                <i class=""fas fa-lock""></i>
                                                <span>Đổi mật khẩu</span>
                                            </a>
    ");
                WriteLiteral(@"                                    </li>
                                        <li>
                                            <a href=""/Users/Auth/SignOut"">
                                                <i class=""fas fa-sign-out-alt""></i>
                                                <span>Đăng xuất</span>
                                            </a>
                                        </li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                        <!-- /Profile Sidebar -->

                    </div>
                    <div class=""col-md-7 col-lg-8 col-xl-9"">

                        ");
#nullable restore
#line 122 "D:\Project\BookApp\BookApp\Areas\Doctor\Views\Shared\_LayoutDoctor.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                    </div>

                </div>
            </div>

        </div>
        <footer class=""footer"">

            <!-- Footer Top -->
            <div class=""footer-top"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-lg-2 col-md-3"">
                        </div>
                        <div class=""col-lg-3 col-md-6"">
                            <div class=""footer-widget footer-about"">
                                <div class=""footer-logo"">
                                    <img src=""/doc_assets/img/footer-logo.png"" alt=""logo"">
                                </div>
                                <div class=""footer-about-content"">
                                    <p>Doccure có đội ngũ chuyên gia, bác sĩ, dược sĩ và điều dưỡng trình độ chuyên môn cao, giàu kinh nghiệm. tận tâm và chuyên nghiệp. Luôn đặt người bệnh làm trung tâm, Doccure cam kết đem đến dịch vụ chăm sóc sức khỏe tốt n");
                WriteLiteral(@"hất.</p>
                                    <div class=""social-icon"">
                                        <ul>
                                            <li>
                                                <a href=""#"" target=""_blank""><i class=""fab fa-facebook-f""></i> </a>
                                            </li>
                                            <li>
                                                <a href=""#"" target=""_blank""><i class=""fab fa-twitter""></i> </a>
                                            </li>
                                            <li>
                                                <a href=""#"" target=""_blank""><i class=""fab fa-linkedin-in""></i></a>
                                            </li>
                                            <li>
                                                <a href=""#"" target=""_blank""><i class=""fab fa-instagram""></i></a>
                                            </li>
                                          ");
                WriteLiteral(@"  <li>
                                                <a href=""#"" target=""_blank""><i class=""fab fa-dribbble""></i> </a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-1"">
                        </div>
                        <div class=""col-lg-4 col-md-12"">
                            <div class=""footer-widget footer-contact"">
                                <h2 class=""footer-title"">Liên hệ</h2>
                                <div class=""footer-contact-info"">
                                    <div class=""footer-address"">
                                        <span><i class=""fas fa-map-marker-alt""></i></span>
                                        <p> 437c/4 Long Hòa, Bình Thủy, Cần Thơ</p>
                                    </div>
                 ");
                WriteLiteral(@"                   <p>
                                        <i class=""fas fa-phone-alt""></i>
                                        0977129155
                                    </p>
                                    <p class=""mb-0"">
                                        <i class=""fas fa-envelope""></i>
                                        doccure@gmail.com
                                    </p>
                                </div>
                            </div>

                        </div>
                        <div class=""col-lg-2 col-md-3"">
                        </div>
                    </div>
                </div>
            </div>
        </footer>

    </div>   
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Areas.Admin.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591