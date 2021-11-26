#pragma checksum "D:\Project\BookApp\BookApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c87a535b6d3a624c5bc82da7e37ebb800280f7fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Project\BookApp\BookApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\BookApp\BookApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\BookApp\BookApp\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c87a535b6d3a624c5bc82da7e37ebb800280f7fe", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee4df46ea30e98bb86a794fd24db4bbf4b09b404", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c87a535b6d3a624c5bc82da7e37ebb800280f7fe4896", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, user-scalable=0\">\r\n\r\n    <title>");
#nullable restore
#line 7 "D:\Project\BookApp\BookApp\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - Administrator</title>

    <!-- Favicon -->
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""/assets/img/favicon.png"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""/assets/css/bootstrap.min.css"">

    <!-- Fontawesome CSS -->
    <link rel=""stylesheet"" href=""/assets/css/font-awesome.min.css"">

    <!-- Feathericon CSS -->
    <link rel=""stylesheet"" href=""/assets/css/feathericon.min.css"">

    <link rel=""stylesheet"" href=""/assets/plugins/morris/morris.css"">

    <!-- Main CSS -->
    <link rel=""stylesheet"" href=""/assets/css/style.css"">
");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c87a535b6d3a624c5bc82da7e37ebb800280f7fe6152", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c87a535b6d3a624c5bc82da7e37ebb800280f7fe7251", async() => {
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
                WriteLiteral("\r\n  \r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c87a535b6d3a624c5bc82da7e37ebb800280f7fe9060", async() => {
                WriteLiteral(@"
  
    <!-- Main Wrapper -->
    <div class=""main-wrapper"">

        <!-- Header -->
        <div class=""header"">

            <!-- Logo -->
            <div class=""header-left"">
                <a href=""/Home/Index"" class=""logo"">
                    <img src=""/assets/img/logo.png"" alt=""Logo"">
                </a>
                <a href=""#"" class=""logo logo-small"">
                    <img src=""/assets/img/logo-small.png"" alt=""Logo"" width=""30"" height=""30"">
                </a>
            </div>
            <!-- /Logo -->

            <a href=""javascript:void(0);"" id=""toggle_btn"">
                <i class=""fe fe-text-align-left""></i>
            </a>

            <div class=""top-nav-search"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c87a535b6d3a624c5bc82da7e37ebb800280f7fe10092", async() => {
                    WriteLiteral("\r\n                    <input type=\"text\" class=\"form-control\" placeholder=\"Search here\">\r\n                    <button class=\"btn\" type=\"submit\"><i class=\"fa fa-search\"></i></button>\r\n                ");
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
                WriteLiteral(@"
            </div>

            <!-- Mobile Menu Toggle -->
            <a class=""mobile_btn"" id=""mobile_btn"">
                <i class=""fa fa-bars""></i>
            </a>
            <!-- /Mobile Menu Toggle -->
            <!-- Header Right Menu -->
            <ul class=""nav user-menu"">

                <!-- Notifications -->
                <li class=""nav-item dropdown noti-dropdown"">
                    <a href=""#"" class=""dropdown-toggle nav-link"" data-toggle=""dropdown"">
                        <i class=""fe fe-bell""></i> <span class=""badge badge-pill"">3</span>
                    </a>
                    <div class=""dropdown-menu notifications"">
                        <div class=""topnav-dropdown-header"">
                            <span class=""notification-title"">Notifications</span>
                            <a href=""javascript:void(0)"" class=""clear-noti""> Clear All </a>
                        </div>
                        <div class=""noti-content"">
                          ");
                WriteLiteral(@"  <ul class=""notification-list"">
                                <li class=""notification-message"">
                                    <a href=""#"">
                                        <div class=""media"">
                                            <span class=""avatar avatar-sm"">
                                                <img class=""avatar-img rounded-circle"" alt=""User Image"" src=""/assets/img/doctors/doctor-thumb-01.jpg"">
                                            </span>
                                            <div class=""media-body"">
                                                <p class=""noti-details""><span class=""noti-title"">Dr. Ruby Perrin</span> Schedule <span class=""noti-title"">her appointment</span></p>
                                                <p class=""noti-time""><span class=""notification-time"">4 mins ago</span></p>
                                            </div>
                                        </div>
                                    </a>
            ");
                WriteLiteral(@"                    </li>
                                <li class=""notification-message"">
                                    <a href=""#"">
                                        <div class=""media"">
                                            <span class=""avatar avatar-sm"">
                                                <img class=""avatar-img rounded-circle"" alt=""User Image"" src=""/assets/img/patients/patient1.jpg"">
                                            </span>
                                            <div class=""media-body"">
                                                <p class=""noti-details""><span class=""noti-title"">Charlene Reed</span> has booked her appointment to <span class=""noti-title"">Dr. Ruby Perrin</span></p>
                                                <p class=""noti-time""><span class=""notification-time"">6 mins ago</span></p>
                                            </div>
                                        </div>
                                    </a>
      ");
                WriteLiteral(@"                          </li>
                                <li class=""notification-message"">
                                    <a href=""#"">
                                        <div class=""media"">
                                            <span class=""avatar avatar-sm"">
                                                <img class=""avatar-img rounded-circle"" alt=""User Image"" src=""/assets/img/patients/patient2.jpg"">
                                            </span>
                                            <div class=""media-body"">
                                                <p class=""noti-details""><span class=""noti-title"">Travis Trimble</span> sent a amount of $210 for his <span class=""noti-title"">appointment</span></p>
                                                <p class=""noti-time""><span class=""notification-time"">8 mins ago</span></p>
                                            </div>
                                        </div>
                                    </a>
   ");
                WriteLiteral(@"                             </li>
                                <li class=""notification-message"">
                                    <a href=""#"">
                                        <div class=""media"">
                                            <span class=""avatar avatar-sm"">
                                                <img class=""avatar-img rounded-circle"" alt=""User Image"" src=""/assets/img/patients/patient3.jpg"">
                                            </span>
                                            <div class=""media-body"">
                                                <p class=""noti-details""><span class=""noti-title"">Carl Kelly</span> send a message <span class=""noti-title""> to his doctor</span></p>
                                                <p class=""noti-time""><span class=""notification-time"">12 mins ago</span></p>
                                            </div>
                                        </div>
                                    </a>
               ");
                WriteLiteral(@"                 </li>
                            </ul>
                        </div>
                        <div class=""topnav-dropdown-footer"">
                            <a href=""#"">View all Notifications</a>
                        </div>
                    </div>
                </li>
                <!-- /Notifications -->
                <!-- User Menu -->
");
#nullable restore
#line 141 "D:\Project\BookApp\BookApp\Views\Shared\_Layout.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"nav-item dropdown has-arrow\">\r\n                        <a href=\"#\" class=\"dropdown-toggle nav-link\" data-toggle=\"dropdown\">\r\n                            <span>Hello ");
#nullable restore
#line 145 "D:\Project\BookApp\BookApp\Views\Shared\_Layout.cshtml"
                                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span><span class=""user-img""><img class=""rounded-circle"" src=""/assets/img/profiles/avatar-01.jpg"" width=""31"" alt=""Ryan Taylor""></span>
                        </a>
                        <div class=""dropdown-menu"">
                            <div class=""user-header"">
                                <div class=""avatar avatar-sm"">
                                    <img src=""/assets/img/profiles/avatar-01.jpg"" alt=""User Image"" class=""avatar-img rounded-circle"">
                                </div>
                                <div class=""user-text"">
                                    <h6>Ryan Taylor</h6>
                                    <p class=""text-muted mb-0"">Administrator</p>
                                </div>
                            </div>
                            <a class=""dropdown-item"" href=""profile.html"">My Profile</a>
                            <a class=""dropdown-item"" href=""settings.html"">Settings</a>
                            <a class=""dropdown-item"" href=""/");
                WriteLiteral("users/auth/SignOut\">Logout</a>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 163 "D:\Project\BookApp\BookApp\Views\Shared\_Layout.cshtml"
                     if (User.IsInRole("Admin"))
                    {

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 166 "D:\Project\BookApp\BookApp\Views\Shared\_Layout.cshtml"
                     

                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li>\r\n                        <a href=\"/users/auth/signin\">Đăng nhập</a>\r\n                    </li>\r\n");
#nullable restore
#line 174 "D:\Project\BookApp\BookApp\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                <!-- /User Menu -->

            </ul>
            <!-- /Header Right Menu -->

        </div>
        <!-- /Header -->
        <!-- Sidebar -->
        <div class=""sidebar"" id=""sidebar"">
            <div class=""sidebar-inner slimscroll"">
                <div id=""sidebar-menu"" class=""sidebar-menu"">
                    <ul>
                        <li class=""menu-title"">
                            <span>Main</span>
                        </li>
                        <li class=""active"">
                            <a href=""/Admin/Home/Index""><i class=""fe fe-home""></i> <span>Dashboard</span></a>
                        </li>
                        <li>
                            <a href=""appointment-list.html""><i class=""fe fe-layout""></i> <span>Appointments</span></a>
                        </li>
                        <li>
                            <a href=""/Admin/Department/Index""><i class=""fe fe-users""></i> <span>Quản lý chuyên khoa</span></a>
            ");
                WriteLiteral(@"            </li>
                        <li>
                            <a href=""/Admin/Room/Index""><i class=""fe fe-users""></i> <span>Quản lý phòng khám</span></a>
                        </li>
                        <li>
                            <a href=""/Admin/Employee/Index""><i class=""fe fe-user-plus""></i> <span> Quản lý nhân viên</span></a>
                        </li>
                        <li>
                            <a href=""/Users/Role/Index""><i class=""fe fe-user-plus""></i> <span> Phân quyền</span></a>
                        </li>
                        <li class=""submenu"">
                            <a href=""#"">
                                <i class=""fe fe-document""></i> <span> Quản lý danh mục</span>
                                <span class=""menu-arrow""></span>
                            </a>
                            <ul style=""display: none;"">
                                <li><a href=""/Admin/Medicine/Index""><span>Thuốc</span></a></li>
                 ");
                WriteLiteral(@"               <li><a href=""/Admin/MeGroup/Index""><span>Nhóm thuốc</span></a></li>
                                <li><a href=""/Admin/MeElement/Index""><span>Hoạt chất</span></a></li>
                                <li><a href=""/Admin/Producer/Index""><span>Nhà sản xuất</span></a></li>
                                <li><a href=""/Admin/Education/Index""><span>Trình độ học vấn</span></a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- /Sidebar -->
        <!-- Page Wrapper -->
        <div class=""page-wrapper"">
            <div class=""content container-fluid"">
                ");
#nullable restore
#line 232 "D:\Project\BookApp\BookApp\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!-- /Page Wrapper -->\r\n\r\n    </div>\r\n    <!-- /Main Wrapper -->\r\n    <!-- jQuery -->\r\n\r\n    <script src=\"/assets/plugins/morris/morris.min.js\"></script>\r\n");
                WriteLiteral(@"
    <!-- Bootstrap Core JS -->
    <script src=""/assets/js/popper.min.js""></script>
    <script src=""/assets/js/bootstrap.min.js""></script>

    <!-- Slimscroll JS -->
    <script src=""/assets/plugins/slimscroll/jquery.slimscroll.min.js""></script>

    <script src=""/assets/plugins/raphael/raphael.min.js""></script>
    <!-- Custom JS -->


    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c87a535b6d3a624c5bc82da7e37ebb800280f7fe23841", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n<!-- Mirrored from dreamguys.co.in/demo/doccure/admin/index.html by HTTrack Website Copier/3.x [XR&CO\'2014], Sat, 30 Nov 2019 04:12:34 GMT -->\r\n</html>");
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
