#pragma checksum "D:\Project\BookApp\BookApp\Areas\Users\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f60d07b843384a85b12f33df08d90d4c08150bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Role_Index), @"mvc.1.0.view", @"/Areas/Users/Views/Role/Index.cshtml")]
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
#line 1 "D:\Project\BookApp\BookApp\Areas\Users\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\BookApp\BookApp\Areas\Users\Views\_ViewImports.cshtml"
using WebApp.Areas.Users.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\BookApp\BookApp\Areas\Users\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f60d07b843384a85b12f33df08d90d4c08150bc", @"/Areas/Users/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e01479d9c7eb7d144f89caa01efb8318ecbdb75d", @"/Areas/Users/Views/_ViewImports.cshtml")]
    public class Areas_Users_Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Role>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Project\BookApp\BookApp\Areas\Users\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header"">
    <div class=""row"">
        <div class=""col-sm-7 col-auto"">
            <h3 class=""page-title"">Quy???n</h3>
            <ul class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""/Users/"">Trang ch???</a></li>
                <li class=""breadcrumb-item active"">Quy???n</li>
            </ul>
        </div>
        <div class=""col-sm-5 col"">
            <a href=""#add_role"" data-toggle=""modal"" class=""btn btn-primary float-right mt-2"">Th??m quy???n</a>
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
                                <th>M?? quy???n</th>
                                <th>Quy???n</th>
                                <th class=""text-right""></th>
 ");
            WriteLiteral(@"                           </tr>
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
<div class=""modal fade"" id=""add_role"" aria-hidden=""true"" role=""dialog"">
</div>
<!-- /ADD Modal -->
<!-- Edit Details Modal -->
<div class=""modal fade"" id=""edit_role"" aria-hidden=""true"" role=""dialog"">
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
                    <button type=""button"" class=""btn btn-primary"" onc");
            WriteLiteral(@"lick=""deleteRole()"" id=""delete"">X??a </button>
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">H???y</button>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    var j = jQuery.noConflict();
    j(document).ready(() => {
        showRole();
        j.ajax({
            'async': false,
            'type': ""POST"",
            'global': false,
            'dataType': 'json',
            'url': ""/Users/Role/GetRoles"",
            'data': null,
            'success': function (data) {
            }
        });
        
        str = `<div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Th??m quy???n</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </");
            WriteLiteral(@"div>
            <div class=""modal-body"">
                <form>
                    <div class=""row form-row"">
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>T??n quy???n</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""aRoleName"" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <a class=""btn btn-primary btn-block"" onclick=""saveAdd()"">Th??m m???i</a>
                </form>
            </div>
        </div>
    </div>`
        add_role.innerHTML = str;
    })
    var showRole = () => {
        j.post('/Users/Role/GetRoles', null, (d) => {
            console.log({ d })
            let str = """";
            for (var i = 0; i < d.length; i++) {
                str += `<tr  roleId=""${d[i].roleId}"" roleName=""${d[i].r");
            WriteLiteral(@"oleName}"">
                                    <td>${d[i].roleId}</td>
                                    <td>${d[i].roleName}</td>
                                    <td class=""text-right"">
                                        <div class=""actions"">
                                            <a class=""btn btn-sm bg-success-light"" onclick=""showEditModal(this)"" data-toggle=""modal"" href=""#edit_role"">
                                                <i class=""fe fe-pencil""></i> S???a
                                            </a>
                                            <a data-toggle=""modal"" onclick=""showModal('${d[i].roleId}')"" class=""btn btn-sm bg-danger-light"">
                                                <i class=""fe fe-trash""></i> X??a
                                            </a>
                                        </div>
                                    </td>
                                </tr>`
            }
            sheet.innerHTML = str

        })
    }

  ");
            WriteLiteral(@"  var showEditModal = (e) => {
        console.log({ e })
        let tr = e.parentNode.parentNode.parentNode;
        str = `  <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Ch???nh s???a quy???n</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <form>
                    <div class=""row form-row"">
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>M?? quy???n</label>
                                <div>
                                    <input type=""text"" value=""${j(tr).attr('roleId')}"" class=""form-control"" id=""eRoleId"" readonly />
                                </div");
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>T??n quy???n</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""eRoleName"" value=""${j(tr).attr('roleName')}"" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <a class=""btn btn-primary btn-block"" onclick=""saveEdit()"">L??u</a>
                </form>
            </div>
        </div>
    </div>`
        document.getElementById('edit_role').innerHTML = str;
    }
    //hien modal xoa
    var showModal = (id) => {
        j('#delete_modal').modal();
        j('#delete').data('role', id)
    }
    //ham xoa
    var deleteRole = () => {
        //console.log(e)
        console.log(j('#delete').data('role'");
            WriteLiteral(@"))
        j.post('/Users/Role/Delete', { id: j('#delete').data('role') }, (d) => {
            console.log({ d })
            j(`[roleId=""${j('#delete').data('role')}""]`).remove();
            j('#delete_modal').modal('hide');

        })
    }
    var saveEdit = () => {
        obj = {
            roleId: document.getElementById('eRoleId').value,
            roleName: document.getElementById('eRoleName').value,
        }
        console.log(obj);
        j.post('/Users/Role/Edit', { obj: obj }, (d) => {
            console.log({ d })
            showRole()
            j('#edit_role').modal('hide')
        })

    }
    var saveAdd = () => {
        obj = {
            roleName: document.getElementById('aRoleName').value
        }
        j.post('/Users/Role/Create', { obj: obj }, (d) => {
            console.log({ d })
            if (d != 0) {
                showRole()
                document.getElementById('aRoleName').value = """"
                j('#add_role').modal('hide')");
            WriteLiteral("\r\n            }\r\n        })\r\n    }\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Role>> Html { get; private set; }
    }
}
#pragma warning restore 1591
