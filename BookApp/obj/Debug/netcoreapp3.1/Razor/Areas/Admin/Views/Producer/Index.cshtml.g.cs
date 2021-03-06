#pragma checksum "D:\Project\BookApp\BookApp\Areas\Admin\Views\Producer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74a9462c918a684f4a2a65a9c59e5b998ce246f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Producer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Producer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74a9462c918a684f4a2a65a9c59e5b998ce246f1", @"/Areas/Admin/Views/Producer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936686af5605e9bafa5b30940e0797dea7e9f5a6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Producer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Producer>>
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
#line 2 "D:\Project\BookApp\BookApp\Areas\Admin\Views\Producer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header"">
    <div class=""row"">
        <div class=""col-sm-7 col-auto"">
            <h3 class=""page-title"">Ho???t ch???t</h3>
            <ul class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Trang ch???</a></li>
                <li class=""breadcrumb-item active"">Nh?? s???n xu???t</li>
            </ul>
        </div>
        <div class=""col-sm-5 col"">
            <a href=""#Add_Proc"" data-toggle=""modal"" class=""btn btn-primary float-right mt-2"">Th??m nh?? s???n xu???t</a>
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
                                <th>M?? NSX</th>
                                <th>T??n NSX</th>
                                <th class=");
            WriteLiteral(@"""text-right""></th>
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
<div class=""modal fade"" id=""Add_Proc"" aria-hidden=""true"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Th??m NSX</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74a9462c918a684f4a2a65a9c59e5b998ce246f15464", async() => {
                WriteLiteral(@"
                    <div class=""row form-row"">
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>M?? NSX</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""aidproc"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>T??n NSX</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""aproc"" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <a class=""btn btn-primary btn-block"" onclick=""saveAdd()"">L??u</a>
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
<div class=""modal fade"" id=""Edit_Proc"" aria-hidden=""true"" role=""dialog"">
</div>
<!-- /Edit Details Modal -->
<!-- Delete Modal -->
<div class=""modal fade"" id=""delete_modal"" aria-hidden=""true"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <div class=""form-content p-2"">
                    <h4 class=""modal-title"">X??a</h4>
                    <p class=""mb-4"">B???n ch???c ch???n mu???n x??a?</p>
                    <button type=""button"" class=""btn btn-primary"" onclick=""deleteProc()"" id=""delete"">X??a</button>
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">H???y</button>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    var j = jQuery.noConflict();
    j(document).ready(() => {
        showProducer()");
            WriteLiteral(@";
    })
    var showProducer = () => {
        j.post('/Admin/Producer/GetProducer', null, (d) => {
            let str = """";
            for (var i = 0; i < d.length; i++) {
                str += `<tr idProducer=""${d[i].idProducer}"" nameProducer=""${d[i].nameProducer}""}"">
                                    <td>${d[i].idProducer}</td>
                                    <td>${d[i].nameProducer}</td>
                                    <td class=""text-right"">
                                        <div class=""actions"">
                                            <a class=""btn btn-sm bg-success-light"" onclick=""showEditModal(this)"" data-toggle=""modal"" href=""#Edit_Proc"">
                                                <i class=""fe fe-pencil""></i> S???a
                                            </a>
                                            <a data-toggle=""modal"" onclick=""showModal('${d[i].idProducer}')"" class=""btn btn-sm bg-danger-light"">
                                                <i clas");
            WriteLiteral(@"s=""fe fe-trash""></i> X??a
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
                <h5 class=""modal-title"">C???p nh???t NSX</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <form>
                    <div class=""row form-row"">
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-g");
            WriteLiteral(@"roup"">
                                <label>M?? NSX</label>
                                <div>
                                    <input type=""text"" value=""${j(tr).attr('idProducer')}"" class=""form-control"" id=""eidproc""/>
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>T??n NSX</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""eproc"" value=""${j(tr).attr('nameProducer')}"" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <a class=""btn btn-primary btn-block"" onclick=""saveEdit()"">L??u</a>
                </form>
            </div>
        </div>
    </div>`
        document.getElementById('Edit_Proc').innerHTML =");
            WriteLiteral(@" str;
    }
    //hien modal xoa
    var showModal = (id) => {
        j('#delete_modal').modal();
        j('#delete').data('proc', id)
    }
    //ham xoa
    var deleteProc = () => {
        //console.log(e)
        console.log(j('#delete').data('proc'))
        j.post('/Admin/Producer/Delete', { id: j('#delete').data('proc') }, (d) => {
            console.log({ d })
            //window.location.reload();
            j(`[idproducer=""${j('#delete').data('proc')}""]`).remove();

            j('#delete_modal').modal('hide');

        })
    }
    var saveEdit = () => {
        obj = {
            idProducer: document.getElementById('eidproc').value,
            nameProducer: document.getElementById('eproc').value
        }
        console.log(obj);
        j.post('/Admin/Producer/Edit', { obj: obj }, (d) => {
            console.log({ d })
            //window.location.reload();
            showProducer()
            j('#Edit_Proc').modal('hide')
        })

    }
    var sa");
            WriteLiteral(@"veAdd = () => {
        obj = {
            idProducer: document.getElementById('aidproc').value,
            nameProducer: document.getElementById('aproc').value
        }
        j.post('/Admin/Producer/Create', { obj: obj }, (d) => {
            console.log({ d })
            if (d != 0) {
                obj = {
                    idProducer: document.getElementById('aidproc').value,
                    nameProducer: document.getElementById('aproc').value
                }

                showProducer()
                document.getElementById('aidproc').value = """"
                document.getElementById('aproc').value = """"
                j('#Add_Proc').modal('hide')
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Producer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
