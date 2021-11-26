#pragma checksum "D:\Project\BookApp\BookApp\Views\Home\Quytrinh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11f02d6a16eb9b6dc7a5830b547264614e3f9e46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Quytrinh), @"mvc.1.0.view", @"/Views/Home/Quytrinh.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11f02d6a16eb9b6dc7a5830b547264614e3f9e46", @"/Views/Home/Quytrinh.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee4df46ea30e98bb86a794fd24db4bbf4b09b404", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Quytrinh : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Project\BookApp\BookApp\Views\Home\Quytrinh.cshtml"
  
    Layout = "~/Areas/Patient/Views/Shared/_LayoutPA.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f02d6a16eb9b6dc7a5830b547264614e3f9e463328", async() => {
                WriteLiteral(@"
    <style>

        .bd-callout-info {
            background: #fff;
        }

        .bd-callout {
            padding: 1rem;
            margin-top: 1.25rem;
            margin-bottom: 1.25rem;
            border: 1px solid #eee;
            border-left-width: .25rem;
            border-radius: .25rem;
            border-left-color: orange;
        }

        h2, h3 {
            font-family: Arial,sans-serif;
            color: #15558d;
            position: relative;
            font-weight: 700;
        }

        .ml-4, .mx-4 {
            margin-left: 1.5rem !important;
        }
        .line{
            width:130px;
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
            WriteLiteral(@"
<section class=""comp-section"">
    <div class=""comp-header"">
        <h3 class=""comp-title"">QUY TRÌNH</h3>
        <div class=""line""></div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <h2 class=""text-xl-center"">QUY TRÌNH ĐĂNG KÝ KHÁM BỆNH THEO HẸN</h2><br />
                    <ul>
                        <li>
                            <h3>BƯỚC 1: ĐẶT LỊCH KHÁM</h3>
                            <div>
                                <p>> Đăng nhập phần mềm trên web hoặc ứng dụng di động.</p>
                                <p>> Chọn hình thức đặt khám: Theo ngày hoặc theo bác sĩ.</p>
                                <p>> Nhập thông tin bệnh nhân: Bằng số hồ sơ hoặc tạo mới.</p>
                                <p>> Chọn thông tin khám: Chuyên khoa, bác sĩ, ngày khám, giờ khám và có BHYT hay không.</p>
                            </div>
                            <h3>BƯỚC 2: THAN");
            WriteLiteral(@"H TOÁN TIỀN KHÁM</h3>
                            <p>> Chọn loại thẻ thanh toán: Thẻ khám bệnh của bệnh viện Đại Học Y Dược TPHCM, thẻ thanh toán quốc tế hoặc thẻ ATM nội địa.</p>
                            <p>> Kiểm tra tiền khám, các loại phí và tổng tiền thanh toán.</p>
                            <p>> Nhập thông tin thẻ để tiến hành thanh toán.</p>
                            <div class=""bd-callout bd-callout-info"">
                                <strong>Lưu ý:</strong>
                                <p class=""font-italic"">- Thanh toán bằng thẻ khám bệnh của Bệnh viện Đại học Y Dược TPHCM, phí tiện ích sẽ có mức thấp nhất.</p>
                                <p class=""font-italic"">- Đối với thẻ khám Bệnh viện Đại học Y Dược TPHCM, vui lòng đăng ký chức năng thanh toán trực tuyến tại các chi nhánh Vietinbank trong cả nước, trước khi sử dụng.</p>
                            </div>
                            <h3>BƯỚC 3: XÁC NHẬN NGƯỜI BỆNH ĐẾN BỆNH VIỆN KHÁM THEO HẸN</h3>
                      ");
            WriteLiteral(@"      <p>> Sau khi đặt khám thành công phiếu khám điện tử sẽ được gửi ngay qua email, tin nhắn sms và trên phần mềm.</p>
                            <p>><b> Đến ngày khám</b></p>
                            <p class=""ml-4"">> Người bệnh không BHYT sẽ đến trực tiếp phòng khám trước giờ hẹn 15-30 phút để khám bệnh.</p>
                            <p class=""ml-4"">> Người bệnh khám BHYT vui lòng đến quầy 12,13,14 khu A trước giờ hẹn 15-30 phút để xác nhận bảo hiểm trước khi vào phòng khám.</p>
                            <h3>BƯỚC 4: KHÁM VÀ THỰC HIỆN CẬN LÂM SÀNG</h3>
                            <p>> Người bệnh khám tại các phòng khám chuyên khoa theo thông tin khám đã đặt.</p>
                            <p>> Thực hiện cận lâm sàng (nếu có) và đóng phí tại các quầy thu ngân hoặc trừ vào tài khoản thẻ khám bệnh (nếu có).</p>
                            <p>> Khi đủ kết quả cận lâm sàng, người bệnh quay lại phòng khám gặp Bác sĩ nhận toa thuốc.</p>
                            <h3>BƯỚC 5: NHẬN THUỐC</h3>
   ");
            WriteLiteral(@"                         <p>> <b>Người bệnh có BHYT:</b> Thực hiện kết toán BHYT tại quầy 17,18,19,20 tầng trệt khu A và nhận thuốc tại nhà thuốc khu B.</p>
                            <p>> <b>Người bệnh không có BHYT:</b> Đến nhà thuốc khu A hoặc khu B mua thuốc, thanh toán tiền thuốc tại quầy hoặc trừ vào tài khoản thẻ khám bệnh (nếu có).</p>
                            <h3>BƯỚC 6: ĐẶT LỊCH TÁI KHÁM</h3>
                            <p>> Sử dụng phần mềm đặt hẹn tái khám như BƯỚC 1 và BƯỚC 2 để nhận phiếu khám điện tử.</p>
                            <div class=""bd-callout bd-callout-info"">
                                <strong>Lưu ý:</strong>
                                <p class=""font-italic"">> Chọn bác sĩ khám và ngày tái khám theo thông tin trên toa thuốc.</p>
                                <p class=""font-italic"">> Nhập thông tin người bệnh bằng số hồ sơ trên toa thuốc (không được tạo mới).</p>
                            </div>
                        </li>
                    </ul>

 ");
            WriteLiteral("               </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
