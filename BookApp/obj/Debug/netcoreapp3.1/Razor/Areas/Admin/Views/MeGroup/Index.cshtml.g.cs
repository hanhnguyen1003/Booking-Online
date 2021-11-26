#pragma checksum "D:\Project\BookApp\BookApp\Areas\Admin\Views\MeGroup\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88fddfd1d0b484ec3d07c0d0cae9c2a8fa9cc9e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MeGroup_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/MeGroup/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88fddfd1d0b484ec3d07c0d0cae9c2a8fa9cc9e6", @"/Areas/Admin/Views/MeGroup/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936686af5605e9bafa5b30940e0797dea7e9f5a6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_MeGroup_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Areas.Admin.Models.MeGroup>>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Project\BookApp\BookApp\Areas\Admin\Views\MeGroup\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header"">
    <div class=""row"">
        <div class=""col-sm-7 col-auto"">
            <h3 class=""page-title"">Nhóm thuốc</h3>
            <ul class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Trang chủ</a></li>
                <li class=""breadcrumb-item active"">Nhóm thuốc</li>
            </ul>
        </div>
        <div class=""col-sm-5 col"">
            <a href=""#Add_group"" data-toggle=""modal"" class=""btn btn-primary float-right mt-2"">Thêm nhóm thuốc</a>
        </div>
    </div>
</div>
<!-- /Page Header -->
<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-hover table-center mb-0"">
                        <thead>
                            <tr>
                                <th>Mã nhóm thuốc</th>
                                <th>Tên nhóm thuốc</th>
                              ");
            WriteLiteral(@"  <th class=""text-right""></th>
                            </tr>
                        </thead>
                        <tbody id=""sheet"">
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- /Page Wrapper -->
<!-- Add Modal -->
<div class=""modal fade"" id=""Add_group"" aria-hidden=""true"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Thêm nhóm thuốc</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88fddfd1d0b484ec3d07c0d0cae9c2a8fa9cc9e65503", async() => {
                WriteLiteral(@"
                    <div class=""row form-row"">
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>Mã nhóm thuốc</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""aidgroup"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>Tên nhóm thuốc</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""agroup"" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <a class=""btn btn-primary btn-block"" onclick=""saveAdd()"">Lưu</a>
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
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<!-- /ADD Modal -->
<!-- Edit Details Modal -->
<div class=""modal fade"" id=""Edit_group"" aria-hidden=""true"" role=""dialog"">
</div>
<!-- /Edit Details Modal -->
<!-- Delete Modal -->
<div class=""modal fade"" id=""delete_modal"" aria-hidden=""true"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <div class=""form-content p-2"">
                    <h4 class=""modal-title"">Xóa</h4>
                    <p class=""mb-4"">Bạn chắc chắn muốn xóa?</p>
                    <button type=""button"" class=""btn btn-primary"" onclick=""deleteGroup()"" id=""delete"">Xóa</button>
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Hủy</button>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    var j = jQuery.noConflict();
    j(document).ready(() => {
        showGroup();");
            WriteLiteral(@"
    })
    var showGroup = () => {
        j.post('/Admin/MeGroup/GetMeGroup', null, (d) => {
            let str = """";
            for (var i = 0; i < d.length; i++) {
                str += `<tr idMeGroup=""${d[i].idMeGroup}"" meGroupName=""${d[i].meGroupName}""}"">
                                    <td>${d[i].idMeGroup}</td>
                                    <td>${d[i].meGroupName}</td>
                                    <td class=""text-right"">
                                        <div class=""actions"">
                                            <a class=""btn btn-sm bg-success-light"" onclick=""showEditModal(this)"" data-toggle=""modal"" href=""#Edit_group"">
                                                <i class=""fe fe-pencil""></i> Sửa
                                            </a>
                                            <a data-toggle=""modal"" onclick=""showModal('${d[i].idMeGroup}')"" class=""btn btn-sm bg-danger-light"">
                                                <i class=""fe fe-tra");
            WriteLiteral(@"sh""></i> Xóa
                                            </a>
                                        </div>
                                    </td>
                                </tr>`
            }
            sheet.innerHTML = str
        })
    }
    var showEditModal = (e) => {
        console.log({ e })
        let tr = e.parentNode.parentNode.parentNode;
        str = `  <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Cập nhật nhóm thuốc</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <form>
                    <div class=""row form-row"">
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group""");
            WriteLiteral(@">
                                <label>Mã nhóm thuốc</label>
                                <div>
                                    <input type=""text"" value=""${j(tr).attr('idMeGroup')}"" class=""form-control"" id=""eidgroup""/>
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>Tên nhóm thuốc</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""egroup"" value=""${j(tr).attr('meGroupName')}"" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <a class=""btn btn-primary btn-block"" onclick=""saveEdit()"">Lưu</a>
                </form>
            </div>
        </div>
    </div>`
        document.getElementById('Edit_group').i");
            WriteLiteral(@"nnerHTML = str;
    }
    //hien modal xoa
    var showModal = (id) => {
        j('#delete_modal').modal();
        j('#delete').data('group', id)
    }
    //ham xoa
    var deleteGroup = () => {
        //console.log(e)
        console.log(j('#delete').data('group'))
        j.post('/Admin/MeGroup/Delete', { id: j('#delete').data('group') }, (d) => {
            console.log({ d })
            //window.location.reload();
            j(`[idmegroup=""${j('#delete').data('group')}""]`).remove();

            j('#delete_modal').modal('hide');

        })
    }
    var saveEdit = () => {
        obj = {
            idMeGroup: document.getElementById('eidgroup').value,
            meGroupName: document.getElementById('egroup').value
        }
        console.log(obj);
        j.post('/Admin/MeGroup/Edit', { obj: obj }, (d) => {
            console.log({ d })
            //window.location.reload();
            showGroup()
            j('#Edit_group').modal('hide')
        })

    }
");
            WriteLiteral(@"    var saveAdd = () => {
        obj = {
            idMeGroup: document.getElementById('aidgroup').value,
            meGroupName: document.getElementById('agroup').value
        }
        j.post('/Admin/MeGroup/Create', { obj: obj }, (d) => {
            console.log({ d })
            if (d != 0) {
                obj = {
                    idMeGroup: document.getElementById('aidgroup').value,
                    meGroupName: document.getElementById('agroup').value
                }

                showGroup()
                document.getElementById('aidgroup').value = """"
                document.getElementById('agroup').value = """"
                j('#Add_group').modal('hide')
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Areas.Admin.Models.MeGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
