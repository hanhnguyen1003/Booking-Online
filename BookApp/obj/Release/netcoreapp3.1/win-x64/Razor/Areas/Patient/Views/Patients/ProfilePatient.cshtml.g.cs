#pragma checksum "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5603a0a8bb4e91e170d360555a135d5876134035"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Patient_Views_Patients_ProfilePatient), @"mvc.1.0.view", @"/Areas/Patient/Views/Patients/ProfilePatient.cshtml")]
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
#line 1 "D:\Project\BookApp\BookApp\Areas\Patient\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\BookApp\BookApp\Areas\Patient\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5603a0a8bb4e91e170d360555a135d5876134035", @"/Areas/Patient/Views/Patients/ProfilePatient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936686af5605e9bafa5b30940e0797dea7e9f5a6", @"/Areas/Patient/Views/_ViewImports.cshtml")]
    public class Areas_Patient_Views_Patients_ProfilePatient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Patients>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/doc_assets/img/patients/user.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar-img rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n<!-- doccure/search.html  30 Nov 2019 04:12:16 GMT -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5603a0a8bb4e91e170d360555a135d58761340354838", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Doccure</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, user-scalable=0"">

    <!-- Favicons -->
    <link href=""/specialist/img/favicon.png"" rel=""icon"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""/specialist/css/bootstrap.min.css"">

    <!-- Fontawesome CSS -->
    <link rel=""stylesheet"" href=""/specialist/plugins/fontawesome/css/fontawesome.min.css"">
    <link rel=""stylesheet"" href=""/specialist/plugins/fontawesome/css/all.min.css"">

    <!-- Datetimepicker CSS -->
    <link rel=""stylesheet"" href=""/specialist/css/bootstrap-datetimepicker.min.css"">

    <!-- Select2 CSS -->
    <link rel=""stylesheet"" href=""/specialist/plugins/select2/css/select2.min.css"">

    <!-- Fancybox CSS -->
    <link rel=""stylesheet"" href=""/specialist/plugins/fancybox/jquery.fancybox.min.css"">

    <!-- Main CSS -->
    <link rel=""stylesheet"" href=""/specialist/css/style.css"">

    <!-- HTML5 shim and Respond.js IE8 supp");
                WriteLiteral(@"ort of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
        <script src=""/specialist/js/html5shiv.min.js""></script>
        <script src=""/specialist/js/respond.min.js""></script>
    <![endif]-->
    <style>

        .action-logout {
            background-color: #f7f8f9;
            color: #333 !important;
        }

            .action-logout .text-logout-bt {
                color: #333 !important;
                display: block;
                padding: 10px 0px 8px 10px !important;
            }

        .control-dropdown {
            margin-top: 0px;
            overflow: hidden;
            padding: 15px;
        }

        .card .card-header {
            background-color: #42a5f5;
            border-bottom: 1px solid #f0f0f0;
        }

        .left-columns .leftc-name {
            font-size: 14px;
            margin-bottom: 20px;
        }

            .left-columns .leftc-name a {
                font-weight: bold;
                color: #4d4d4d;
                WriteLiteral(@"
                transition: all .2s ease;
                margin-left: 5px;
            }

        .left-columns .leftc-menu a.active {
            background: #e4e7eb;
            color: #307be7;
        }

            .left-columns .leftc-menu a.active i.fa-angle-right {
                transform: translateX(0);
                color: #307be7;
            }

        .left-columns .leftc-menu a i.fa-angle-right {
            width: 13px;
            height: 15px;
            position: absolute;
            top: 50%;
            margin-top: -8px;
            right: 10px;
            transition: all .2s ease;
        }

        .left-columns .leftc-menu a {
            font-size: 15px;
            color: #4d4d4d;
            transition: all .2s ease;
            padding: 10px 33px;
            display: flex;
            margin-bottom: 10px;
            position: relative;
            overflow: hidden;
        }

        i.far.fa-address-book {
            padding-right: 10p");
                WriteLiteral(@"x;
            padding-top: 4px;
        }

        i.fa.fa-credit-card {
            padding-right: 7px;
            padding-top: 4px;
        }

        i.fas.fa-file-medical {
            padding-right: 11px;
            padding-top: 4px;
        }

        .group-dashed {
            padding: 14px 20px 11px;
            font-size: 14px;
            border: 1px dashed #cdd8ea;
            border-radius: 3px;
            background: #fff;
            margin-bottom: 15px;
            cursor: pointer;
            transition: all .2s ease;
            position: relative;
        }

        .group {
            border: 1px solid #307be7;
            background: #fff;
            padding: 20px 20px 40px;
            border-radius: 3px;
            height: auto;
            transition: all .2s ease;
            position: relative;
            margin-bottom: 20px;
            width: 100%;
        }

        .group-dashed:hover {
            border: 1px dashed #307be7;
      ");
                WriteLiteral(@"      transition: all .3s ease-out;
            position: relative;
        }

        .group-dashed a:hover {
            color: #307be7;
        }

        .ml-auto {
            margin-left: auto !important;
        }

        .position-relative {
            position: relative !important;
        }

        .group.group-files .group-files-item .group-files-item-right a {
            color: #696969;
            font-size: 13px;
            transition: all .2s ease;
            position: relative;
            padding-left: 20px;
        }

        .group.group-files .group-files-item .group-files-item-right .gfi-see-more {
            position: absolute;
            color: #307be7;
            bottom: 20px;
            left: 0;
            font-size: 13px;
            border-radius: 3px;
        }

        .btn.more-less {
            color: #307be7;
        }

        .type.dropdown-toggle.nav-link {
            border: 1px solid;
            background: #fff;
      ");
                WriteLiteral(@"      border-color: #307be7;
            border-radius: 99px;
            color: #307be7 !important;
            min-width: 125px;
            display: inline-flex;
            align-items: center;
            justify-content: center;
            font-size: 12px;
            letter-spacing: 0;
            min-height: 38px;
            font-weight: 600;
            transition: all 0.2s linear;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5603a0a8bb4e91e170d360555a135d587613403511576", async() => {
                WriteLiteral(@"

    <!-- Main Wrapper -->
    <div class=""main-wrapper"">

        <!-- Header -->
        <header class=""header"">
            <nav class=""navbar navbar-expand-lg header-nav"">
                <div class=""navbar-header"">
                    <a id=""mobile_btn"" href=""javascript:void(0);"">
                        <span class=""bar-icon"">
                            <span></span>
                            <span></span>
                            <span></span>
                        </span>
                    </a>
                    <a href=""index-2.html"" class=""navbar-brand logo"">
                        <img src=""/specialist/img/logo.png"" class=""img-fluid"" alt=""Logo"">
                    </a>
                </div>
                <div class=""main-menu-wrapper"">
                    <div class=""menu-header"">
                        <a href=""index-2.html"" class=""menu-logo"">
                            <img src=""/specialist/img/logo.png"" class=""img-fluid"" alt=""Logo"">
                   ");
                WriteLiteral(@"     </a>
                        <a id=""menu_close"" class=""menu-close"" href=""javascript:void(0);"">
                            <i class=""fas fa-times""></i>
                        </a>
                    </div>
                    <ul class=""main-nav"">
                        <li class=""has-submenu"">
                            <a href=""/"">Trang chủ</a>
                        </li>
                        <li class=""has-submenu"">
                            <a href=""/Home/Intro"">Giới thiệu</a>
                        </li>
                        <li class=""has-submenu"">
                            <a href=""/Home/Quytrinh"">Quy trình</a>
                        </li>
                        <li class=""has-submenu"">
                            <a href=""/Home/Help"">Hướng dẫn sử dụng</a>
                        </li>
                        <li class=""has-submenu"">
                            <a href=""/Home/Contact"">Liên hệ</a>
                        </li>
                    </ul>
     ");
                WriteLiteral(@"           </div>
                <ul class=""nav header-navbar-rht"">
                    <li class=""nav-item contact-item"">
                        <div class=""header-contact-img"">
                            <i class=""far fa-hospital""></i>
                        </div>
                        <div class=""header-contact-detail"">
                            <p class=""contact-header"">Liên hệ</p>
                            <p class=""contact-info-header"">0977129155</p>
                        </div>
                    </li>

");
#nullable restore
#line 262 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <li class=""nav-item dropdown has-arrow"">
                            <a href=""#"" class=""dropdown-toggle nav-link"" data-toggle=""dropdown"">
                                <span><i class=""fas fa-user-circle mr-2""></i>Thông tin tài khoản</span><span class=""user-img""></span>
                            </a>
                            <div class=""dropdown-menu"">
                                <div class=""user-header"">
                                    <div class=""avatar avatar-sm"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5603a0a8bb4e91e170d360555a135d587613403515427", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"user-text\">\r\n                                        <h6>Xin chào!</h6>\r\n                                        <p class=\"text-muted mb-0\">");
#nullable restore
#line 275 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                                              Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <a class=""dropdown-item"" href=""/Patient/Patients/ProfilePatient"">Hồ sơ bệnh nhân</a>
                                <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 9556, "\"", 9609, 2);
                WriteAttributeValue("", 9563, "/Patient/Patients/ManageMB/", 9563, 27, true);
#nullable restore
#line 279 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
WriteAttributeValue("", 9590, User.Identity.Name, 9590, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Phiếu khám bệnh</a>
                                <div class=""action-logout"">
                                    <a class=""text-logout-bt"" href=""/Users/Auth/SignOut"">
                                        <i class=""fas fa-sign-out-alt mr-2""></i>Thoát
                                    </a>
                                </div>
                            </div>
                        </li>
");
#nullable restore
#line 287 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                         if (User.IsInRole("Patient"))
                        {

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 290 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link header-login\" href=\"/Users/Auth/SignIn\">Đăng nhập</a>\r\n                        </li>\r\n");
#nullable restore
#line 297 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </ul>
            </nav>
        </header>
        <!-- /Header -->
        <!-- Breadcrumb -->
        <div class=""breadcrumb-bar"">
            <div class=""container-fluid"">
                <div class=""row align-items-center"">
                    <div class=""col-md-8 col-12"">
                        <nav aria-label=""breadcrumb"" class=""page-breadcrumb"">
                            <ol class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index-2.html"">Trang chủ</a></li>
                            </ol>
                        </nav>
                        <h3 class=""breadcrumb-title"">Thông tin tài khoản</h3>
                    </div>
                    <div class=""col-md-4 col-12 d-md-block d-none"">
                        <div class=""sort-by"">
                            <ul style=""list-style:none"">
                                <li class=""nav-item dropdown has-arrow"" style=""list-style:none"">
                                    <a h");
                WriteLiteral(@"ref=""#"" class=""type dropdown-toggle nav-link text-uppercase"" data-toggle=""dropdown"">
                                        <span>Chọn hình thức đăng ký</span><span class=""user-img""></span>
                                    </a>
                                    <div class=""dropdown-menu text-uppercase"">
                                        <a class=""dropdown-item"" href=""/Patient/Home/BookingByDoctor"">Đặt lịch theo bác sĩ</a>
                                        <hr />
                                        <a class=""dropdown-item"" href=""/Patient/Home/BookingByDay"">Đặt lịch theo ngày</a>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- /Breadcrumb -->
        <!-- Page Content -->
        <div class=""content"">
            <div class=""container-fluid"" style=""padding-left: 100px; padding-rig");
                WriteLiteral(@"ht: 100px; transform: none; min-height: 500px"">
                <div class=""row"">
                    <div class=""col-md-12 col-lg-4 col-xl-3 theiaStickySidebar"">
                        <div class=""left-columns"">
                            <div class=""leftc-name"">
                                Tài khoản của <a>");
#nullable restore
#line 341 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                            Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                            </div>
                            <div class=""leftc-menu"">
                                <a class=""leftc-menu-1 active"" href=""/Patient/Patients/ProfilePatient"">
                                    <i class=""far fa-address-book""></i> Hồ sơ bệnh nhân <i class=""fas fa-angle-right""></i>
                                </a>
                                <a class=""leftc-menu-2""");
                BeginWriteAttribute("href", " href=\"", 13213, "\"", 13266, 2);
                WriteAttributeValue("", 13220, "/Patient/Patients/ManageMB/", 13220, 27, true);
#nullable restore
#line 347 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
WriteAttributeValue("", 13247, User.Identity.Name, 13247, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    <i class=""fas fa-file-medical""></i>Phiếu khám bệnh
                                    <i class=""fas fa-angle-right""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12 col-lg-8 col-xl-9"">
                        <div class=""group-dashed group-dashed-info text-center"">
                            <a href=""Create""><i class=""fas fa-user-plus""></i>Thêm hồ sơ bệnh nhân</a>
                        </div>
");
#nullable restore
#line 358 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""group group-files shadow-2"">
                                <div class=""group-files-item d-flex"">
                                    <div class=""group-files-item-left"">
                                        <div class=""visible-content"">
                                            <div class=""gfi-info font-weight-bold text-uppercase"">");
#nullable restore
#line 364 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                                                                             Write(item.NamePatient);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                            <div class=\"gfi-info\">Ngày sinh : ");
#nullable restore
#line 365 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                                                         Write(item.DOB.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                        </div>\r\n                                        <div class=\"invisible-content\">\r\n                                            <div class=\"gfi-info font-weight-bold text-uppercase\">");
#nullable restore
#line 368 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                                                                             Write(item.NamePatient);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                            <div class=\"gfi-info\">Ngày sinh : ");
#nullable restore
#line 369 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                                                         Write(item.DOB.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                            <div class=\"gfi-info\">Điện thoại: ");
#nullable restore
#line 370 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                                                         Write(item.SubPhone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                            <div class=\"gfi-info\">Giới tính: ");
#nullable restore
#line 371 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                                                         Write(item.SexPatient?"Nữ":"Nam");

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                            <div class=\"gfi-info\">CMND/Passport : <i>");
#nullable restore
#line 372 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                                                                Write(item.Ident);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i></div>\r\n                                            <div class=\"gfi-info\">Email : <i>");
#nullable restore
#line 373 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                                                        Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i></div>\r\n                                            <div class=\"gfi-info\">Nghề nghiệp : ");
#nullable restore
#line 374 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                                                           Write(item.JobName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                            <div class=\"gfi-info\">Địa chỉ : ");
#nullable restore
#line 375 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                                                                       Write(item.AddP);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                        </div>
                                        <button class=""btn more-less"">Xem thêm</button>
                                    </div>

                                    <div class=""group-files-item-right ml-auto position-relative"">
                                        <a");
                BeginWriteAttribute("href", " href=\"", 15767, "\"", 15812, 2);
                WriteAttributeValue("", 15774, "/Patient/Patients/Edit/", 15774, 23, true);
#nullable restore
#line 381 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
WriteAttributeValue("", 15797, item.IdPatient, 15797, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"gfi-edit\" style=\"cursor: pointer;\">\r\n                                            <i class=\"fas fa-edit\"></i>Sửa\r\n                                        </a>\r\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 16022, "\"", 16069, 2);
                WriteAttributeValue("", 16029, "/Patient/Patients/Delete/", 16029, 25, true);
#nullable restore
#line 384 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
WriteAttributeValue("", 16054, item.IdPatient, 16054, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"class=""gfi-delete"" style=""cursor: pointer;"">
                                         
                                                <i class=""fas fa-times-circle""></i>Xóa
                                            </a>
</div>
                                </div>
                            </div>
");
#nullable restore
#line 391 "D:\Project\BookApp\BookApp\Areas\Patient\Views\Patients\ProfilePatient.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
            </div>

        </div>
        <!-- /Page Content -->
        <!-- Footer -->
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
                                    <p>Doccure có đội ngũ chuyên gia, bác sĩ, dược sĩ và điều dưỡng trình độ chuyên môn cao, giàu kinh nghiệm. tận tâm và chuyên nghiệp. Luôn đặt người bệnh làm trung tâm, Doccur");
                WriteLiteral(@"e cam kết đem đến dịch vụ chăm sóc sức khỏe tốt nhất.</p>
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
                                            ");
                WriteLiteral(@"</li>
                                            <li>
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
            ");
                WriteLiteral(@"                        </div>
                                    <p>
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
        <!-- /Footer -->
    </div>
    <!-- /Main Wrapper -->
    <!-- jQuery -->
    <script src=""/specialist/js/jquery.min.js""></script>
    <script>
        $(document).ready(function () {

            $("".invisible-content"").hide();

            $(");
                WriteLiteral(@"document).on('click', '.btn', function () {
                var moreLessButton = $("".invisible-content"").is(':visible') ? 'Xem thêm' : 'Thu gọn';
                $(this).text(moreLessButton);
                $(this).parent('.group-files-item-left').find("".invisible-content"").toggle();
                $(this).parent('.group-files-item-left').find("".visible-content"").toggle();
            });

        });

    </script>
    <!-- Bootstrap Core JS -->
    <script src=""/specialist/js/popper.min.js""></script>
    <script src=""/specialist/js/bootstrap.min.js""></script>

    <!-- Sticky Sidebar JS -->
    <script src=""/specialist/plugins/theia-sticky-sidebar/ResizeSensor.js""></script>
    <script src=""/specialist/plugins/theia-sticky-sidebar/theia-sticky-sidebar.js""></script>

    <!-- Select2 JS -->
    <script src=""/specialist/plugins/select2/js/select2.min.js""></script>

    <!-- Datetimepicker JS -->
    <script src=""/specialist/js/moment.min.js""></script>
    <script src=""/specialist/js/b");
                WriteLiteral("ootstrap-datetimepicker.min.js\"></script>\r\n\r\n    <!-- Fancybox JS -->\r\n    <script src=\"/specialist/plugins/fancybox/jquery.fancybox.min.js\"></script>\r\n\r\n    <!-- Custom JS -->\r\n    <script src=\"/specialist/js/script.js\"></script>\r\n\r\n");
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
            WriteLiteral("\r\n\r\n<!-- doccure/search.html  30 Nov 2019 04:12:16 GMT -->\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Patients>> Html { get; private set; }
    }
}
#pragma warning restore 1591