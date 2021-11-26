#pragma checksum "D:\Project\BookApp\BookApp\Areas\Admin\Views\Room\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f625b18f2a27264ff3166737e1bc9e3670a874da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Room_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Room/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f625b18f2a27264ff3166737e1bc9e3670a874da", @"/Areas/Admin/Views/Room/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936686af5605e9bafa5b30940e0797dea7e9f5a6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Room_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Project\BookApp\BookApp\Areas\Admin\Views\Room\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f625b18f2a27264ff3166737e1bc9e3670a874da3316", async() => {
                WriteLiteral("\r\n    <style>\r\n        h2, th, td {\r\n            font-family: Arial, sans-serif;\r\n            margin-top: 0;\r\n        }\r\n    </style>\r\n");
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
<div class=""page-header"">
    <div class=""row"">
        <div class=""col-sm-7 col-auto"">
            <h3 class=""page-title""> Phòng khám</h3>
            <ul class=""breadcrumb"">
                <li class=""breadcrumb-item"">Trang chủ</li>
                <li class=""breadcrumb-item active"">Phòng khám</li>
            </ul>
        </div>
        <div class=""col-sm-5 col"">
            <a href=""#add_room"" data-toggle=""modal"" class=""btn btn-primary float-right mt-2"">Thêm</a>
        </div>
    </div>
</div>
<!-- /Page Header -->
<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""table-responsive"">
");
            WriteLiteral(@"                       <table class=""table table-hover table-center mb-0"">
                            <thead>
                                <tr>
                                    <th>STT</th>
                                    <th><input placeholder=""Tên chuyên khoa"" id=""dept"" onkeyup=""filterFunction()"" /></th>
                                    <th><input placeholder=""Tên phòng"" id=""room"" onkeyup=""filterFunction()"" /></th>
                                    <th> Số lượng bệnh nhân</th>
                                    <th class=""text-right"">Hành động</th>
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
<div class=""modal fade"" id=""add_room"" aria-hidden=""true"" role=""dialog"">
</div>
<!-- /ADD Modal -->
<!-- Edit Details M");
            WriteLiteral(@"odal -->
<div class=""modal fade"" id=""edit_room"" aria-hidden=""true"" role=""dialog"">
</div>
<!-- /Edit Details Modal -->
<!-- Delete Modal -->
<div class=""modal fade"" id=""delete_modal"" aria-hidden=""true"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <div class=""form-content p-2"">
                    <h4 class=""modal-title""> Xóa</h4>
                    <p class=""mb-4""> Bạn chắc chắn muốn xóa?</p>
                    <button type=""button"" class=""btn btn-primary"" onclick=""deleteRoom()"" id=""delete"">Xóa</button>
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal""> Hủy</button>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    var j = jQuery.noConflict();
    chuyenkhoa = []
    soption = '';
    j(document).ready(() => {
        //j(""#entries"").DataTable({
        //    ""ajax"": {
        //     ");
            WriteLiteral(@"   ""url"": ""/Admin/Room/GetRoom"",
        //        ""type"": ""GET"",
        //        ""dataType"":
        //    }
        //})

        showRoom();

        j.ajax({
            'async': false,
            'type': ""POST"",
            'global': false,
            'dataType': 'json',
            'url': ""/Admin/Department/GetDepartment"",
            'data': null,
            'success': function (data) {
                chuyenkhoa = data
            }
        });

        for (var i = 0; i < chuyenkhoa.length; i++) {
            soption += `<option value=${chuyenkhoa[i].idDept}>${chuyenkhoa[i].deptName}</option>`
        }
        str = `<div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Thêm phòng</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&t");
            WriteLiteral(@"imes;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <form>
                        <div class=""row form-row"">
                            <div class=""col-12 col-sm-6"">
                                <div class=""form-group"">
                                    <label>Tên chuyên khoa</label>
                                    <div>
                                        <select class=""form-control"" id=aIdDept>${soption}</select>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row form-row"">
                            <div class=""col-12 col-sm-6"">
                                <div class=""form-group"">
                                    <label>Tên phòng</label>
                                    <div>
                                        <input type=""text"" class=""form-control");
            WriteLiteral(@""" id=""aRoomName"" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row form-row"">
                            <div class=""col-12 col-sm-6"">
                                <div class=""form-group"">
                                    <label>Số lượng bệnh nhân</label>
                                    <div>
                                        <input type=""number"" class=""form-control"" id=""aCount"" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <a class=""btn btn-primary btn-block"" onclick=""saveAdd()"">Lưu</a>
                    </form>
                </div>
            </div>
        </div>`
        add_room.innerHTML = str;
    })
    var showRoom = () => {
        j.post('/Admin/Room/GetRoom', null, (d) => {
            c");
            WriteLiteral(@"onsole.log({ d })
            let str = """";
            for (var i = 0; i < d.length; i++) {
                str += `<tr  ordinalRoom=""${d[i].ordinalRoom}"" idDept=""${d[i].idDept}"" roomname=""${d[i].roomName}"" quantityPatient= ""${d[i].quantityPatient}"">
                                        <td>${d[i].ordinalRoom}</td>
                                        <td>${d[i].deptName}</td>
                                        <td>${d[i].roomName}</td>
                                        <td>${d[i].quantityPatient}</td>
                                        <td class=""text-right"">
                                            <div class=""actions"">
                                                <a class=""btn btn-sm bg-success-light"" onclick=""showEditModal(this)"" data-toggle=""modal"" href=""#edit_room"">
                                                    <i class=""fe fe-pencil""></i> Sửa
                                                </a>
                                                <a data-toggl");
            WriteLiteral(@"e=""modal"" onclick=""showModal('${d[i].ordinalRoom}')"" class=""btn btn-sm bg-danger-light"">
                                                    <i class=""fe fe-trash""></i> Xóa
                                                </a>
                                            </div>
                                        </td>
                                    </tr>`
            }
            sheet.innerHTML = str

        })
    }

    //chinh sua department
    var showEditModal = (e) => {
        console.log({ e })
        let tr = e.parentNode.parentNode.parentNode;
        str = ` <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"">Sửa phòng</h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span");
            WriteLiteral(@">
                                </button>
                        </div>
                        <div class=""modal-body"">
                            <form>
                                <div class=""row form-row"">
                                    <div class=""col-12 col-sm-6"">
                                        <div class=""form-group"">
                                        <label>STT</label>
                                        <div>
                                        <input type=""text"" value=""${j(tr).attr('ordinalRoom')}"" class=""form-control"" id=""eordinalRoom"" readonly />
                                    </div>
                                </div>
                        </div>
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>Tên chuyên khoa</label>
                                    <div>
                                        <select class=""form-control"" id=eIdDept>");
            WriteLiteral(@"${soption}</select >
                                    </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"" >
                            <div class=""form-group"" >
                                <label> Tên phòng</label >
                                <div>
                                        <input type=""text"" class=""form-control"" id=""eRoomName"" value=""${j(tr).attr('roomName')}"" / >
                                 </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"" >
                            <div class=""form-group"" >
                                    <label > Số lượng</label >
                            <div>
                            <input type=""number"" class=""form-control"" id=""eCount"" value=""${j(tr).attr('quantityPatient')}"" / >
                        </div>
                        </div>
                        </div>
   ");
            WriteLiteral(@"                     </div>
                            <a class=""btn btn-primary btn-block"" onclick=""saveEdit()""> Lưu</a>
                    </form>
                    </div>
                </div>
        </div>`
        document.getElementById('edit_room').innerHTML = str;
    }

    //hien modal xoa
    var showModal = (id) => {
        j('#delete_modal').modal();
        j('#delete').data('room', id)
    }

    //ham xoa
    var deleteRoom = () => {
        //console.log(e)
        console.log(j('#delete').data('room'))
        j.post('/Admin/Room/Delete', { id: j('#delete').data('room') }, (d) => {
            console.log({ d })
            j(`[ordinalroom=""${j('#delete').data('room')}""]`).remove();
            j('#delete_modal').modal('hide');
        })
    }

    var saveEdit = () => {
        obj = {
            ordinalRoom: document.getElementById('eordinalRoom').value, idDept: document.getElementById('eIdDept').value, roomName: document.getElementById('eRoomName').val");
            WriteLiteral(@"ue, quantityPatient: document.getElementById('eCount').value,
        }
        console.log(obj);
        j.post('/Admin/Room/Edit', { obj: obj }, (d) => {
            console.log({ d })
            showRoom()
            j('#edit_room').modal('hide')
        })
    }

    var saveAdd = () => {
        obj = {
            idDept: document.getElementById('aIdDept').value, roomName: document.getElementById('aRoomName').value, quantityPatient: document.getElementById('aCount').value
        }
        j.post('/Admin/Room/Create', { obj: obj }, (d) => {
            console.log({ d })
            if (d != 0) {
                showRoom()
                document.getElementById('aIdDept').value = """",
                    document.getElementById('aRoomName').value = """",
                    document.getElementById('aCount').value = """"
                j('#add_room').modal('hide')
            }
        })
    }
   function filterFunction(){
       var table, tr, i;
       dept = document.getElem");
            WriteLiteral(@"entById('dept').value.toUpperCase();
       room = document.getElementById('room').value.toUpperCase();
       table = document.getElementById('sheet');
       tr = table.getElementsByTagName('tr');
       for (var i = 0; i < tr.length; i++) {
           td1 = tr[i].getElementsByTagName('td')[1];
           td2 = tr[i].getElementsByTagName('td')[2];
           if (td1||td2) {
               txtDept = td1.innerText.toUpperCase();
               txtRoom = td2.innerText.toUpperCase();
               if (txtDept.indexOf(dept)>-1 && txtRoom.indexOf(room)>-1) {
                   tr[i].style.display = """";
               } else {
                   tr[i].style.display = ""none"";
               }
           }
       }

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