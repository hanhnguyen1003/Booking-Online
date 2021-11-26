#pragma checksum "D:\Project\BookApp\BookApp\Areas\Admin\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e081334add33b302058f1c3220d6be5d11a69ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Department_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Department/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e081334add33b302058f1c3220d6be5d11a69ce", @"/Areas/Admin/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936686af5605e9bafa5b30940e0797dea7e9f5a6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Areas.Admin.Models.Department>>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Project\BookApp\BookApp\Areas\Admin\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e081334add33b302058f1c3220d6be5d11a69ce3669", async() => {
                WriteLiteral(@"

    <style>
        h2, th {
            font-family: Arial, sans-serif;
            margin-top: 0;
        }

        .image-area {
            position: relative;
            width: 100%;
            display: inline-block;
        }

            .image-area img {
                max-width: 100%;
                height: auto;
            }

        .remove-image {
            display: none;
            position: absolute;
            top: -10px;
            right: -10px;
            border-radius: 10em;
            padding: 2px 6px 3px;
            text-decoration: none;
            font: 700 21px/20px sans-serif;
            background: #555;
            border: 3px solid #fff;
            color: #FFF;
            box-shadow: 0 2px 6px rgba(0,0,0,0.5), inset 0 2px 4px rgba(0,0,0,0.3);
            text-shadow: 0 1px 2px rgba(0,0,0,0.5);
            -webkit-transition: background 0.5s;
            transition: background 0.5s;
        }

            .remove-image:hover {
                WriteLiteral(@"
                background: #E54E4E;
                padding: 3px 7px 5px;
                top: -11px;
                right: -11px;
            }

            .remove-image:active {
                background: #E54E4E;
                top: -10px;
                right: -11px;
            }

        .btn-info {
            border-radius: 50px;
            width: 150px;
            line-height: 2rem;
        }

        .change-avatar {
            padding-top: 25px;
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
<div class=""page-header"">
    <div class=""row"">
        <div class=""col-sm-7 col-auto"">
            <h3 class=""page-title"">Chuyên khoa</h3>
            <ul class=""breadcrumb"">
                <li class=""breadcrumb-item"">Trang chủ</li>
                <li class=""breadcrumb-item active"">Chuyên khoa</li>
            </ul>
        </div>
        <div class=""col-sm-5 col"">
            <a href=""#Add_Specialities_details"" data-toggle=""modal"" class=""btn btn-primary float-right mt-2"">Thêm chuyên khoa</a>
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
                                <th>Mã chuyên khoa</th>
                                <th>Tên chuyên khoa</th>
                                <th");
            WriteLiteral(">Giá</th>\r\n                                <th class=\"text-right\">Hành động</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody id=\"sheet\">\r\n");
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- /Page Wrapper -->
<!-- Add Modal -->
<div class=""modal fade"" id=""Add_Specialities_details"" aria-hidden=""true"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Thêm chuyên khoa</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e081334add33b302058f1c3220d6be5d11a69ce8308", async() => {
                WriteLiteral(@"
                    <div class=""row form-row"">
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>Mã chuyên khoa</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""aiddept"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>Tên chuyên khoa</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""adeptname"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label");
                WriteLiteral(@">Giá</label>
                                <div>
                                    <input type=""number"" class=""form-control"" id=""aprice"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-10 col-sm-6"">
                            <div class=""form-group"">
                                <div class=""change-avatar"">
                                    <div id=""caiquan"">
                                        <div class=""image-area d-none"" id=""maindiv"">
                                            <img");
                BeginWriteAttribute("src", " src=\"", 7203, "\"", 7209, 0);
                EndWriteAttribute();
                WriteLiteral(@" alt=""Preview"" id=""mainimg"" />
                                            <a class=""remove-image"" id=""image1"" style=""display: inline;"">&#215;</a>
                                        </div>
                                    </div>
                                    <input type=""hidden"" name=""images"" id=""amain"" />
                                    <input type=""file"" accept=""image/*"" class=""f"" id=""mainimage"" style=""display:none"" value=""1"" />
                                    <input type=""button"" class=""btn btn-info"" value=""Choose File"" onclick=""document.getElementById('mainimage').click();"" />

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
<div class=""modal fade"" id=""edit_specialities_details"" aria-hidden=""true"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Cập nhật chuyên khoa</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e081334add33b302058f1c3220d6be5d11a69ce12998", async() => {
                WriteLiteral(@"
                    <div class=""row form-row"">
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>Mã chuyên khoa</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""eiddept"" readonly />
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <label>Tên chuyên khoa</label>
                                <div>
                                    <input type=""text"" class=""form-control"" id=""edeptname"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                             ");
                WriteLiteral(@"   <label>Giá</label>
                                <div>
                                    <input type=""number"" class=""form-control"" id=""eprice"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-6"">
                            <div class=""form-group"">
                                <div class=""change-avatar"">
                                    <div id=""ecaiquan"">
                                        <div class=""image-area d-none"" id=""emaindiv"">
                                            <img");
                BeginWriteAttribute("src", " src=\"", 10398, "\"", 10404, 0);
                EndWriteAttribute();
                WriteLiteral(@" alt=""Preview"" id=""emainimg"" />
                                            <a class=""remove-image"" t=""edit"" id=""image1"" style=""display: inline;"">&#215;</a>
                                        </div>
                                    </div>
                                    <input type=""hidden"" name=""images"" id=""emain"" />
                                    <input type=""file"" accept=""image/*"" class=""f"" id=""emainimage"" style=""display:none"" />
                                    <input type=""button"" class=""btn btn-info"" value=""Choose File"" onclick=""document.getElementById('emainimage').click();"" />

                                </div>
                            </div>
                        </div>
                    </div>
                    <a class=""btn btn-primary btn-block"" onclick=""saveEdit()"">Lưu</a>
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
<!-- /Edit Details Modal -->
<!-- Delete Modal -->
<div class=""modal fade"" id=""delete_modal"" aria-hidden=""true"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <div class=""form-content p-2"">
                    <h4 class=""modal-title"">Xóa</h4>
                    <p class=""mb-4"">Bạn chắc chắn muốn xóa?</p>
                    <button type=""button"" class=""btn btn-primary"" onclick=""deleteDept()"" id=""delete"">Xóa</button>
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Hủy</button>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    var j = jQuery.noConflict();
    j(document).ready(() => {
        showDepartment();
    })
    var showDepartment = () => {
        j.post('/Admin/Department/GetDepartment', null, (d) => {
            let str");
            WriteLiteral(@" = """";
            for (var i = 0; i < d.length; i++) {
                str += `<tr iddept=""${d[i].idDept}"" image=""${d[i].images}"" deptName=""${d[i].deptName}"" price=""${d[i].price}"">
                                    <td>${d[i].idDept}</td>
                                    <td>
                                        <h2 class=""table-avatar"">
                                                <img class=""avatar-img hinhchinh"" src="""" height=""50"" width=""60"" alt=""Hình gì đó"">
                                                ${d[i].deptName}</h2>
                                    </td>
                                    <td>${d[i].price}</td>
                                    <td class=""text-right"">
                                        <div class=""actions"">
                                            <a class=""btn btn-sm bg-success-light"" onclick=""showEditModal(this)"" data-toggle=""modal"" href=""#edit_specialities_details"">
                                                <i class=""fe fe-pencil""");
            WriteLiteral(@"></i> Sửa
                                            </a>
                                            <a data-toggle=""modal"" onclick=""showModal('${d[i].idDept}')"" class=""btn btn-sm bg-danger-light"">
                                                <i class=""fe fe-trash""></i> Xóa
                                            </a>
                                        </div>
                                    </td>
                                </tr>`
            }
            sheet.innerHTML = str
            let im = document.getElementsByClassName('hinhchinh')
            console.log(im)
            for (var i = 0; i < im.length; i++) {
                im[i].src = d[i].images ? (""/assets/img/specialities/"" + d[i].images) : """";
            }
        })
    }
    //chinh sua department
    var showEditModal = (e) => {
        console.log(""Cai quan"")
        console.log({ e })
        //j('#edit_specialities_details').modal();
        let tr = e.parentNode.parentNode.parentNode;
      ");
            WriteLiteral(@"  //console.log({tr})
        let id = j(tr).attr('iddept')
        let name = j(tr).attr('deptname')
        let price = j(tr).attr('price')
        let image = j(tr).attr('image')
        console.log({ tr }, { id }, { name }, { price }, { image })
        eiddept.value = id;
        edeptname.value = name;
        eprice.value = parseInt(price)
        emaindiv.classList.remove('d-none')
        emainimg.src = ""/assets/img/specialities/"" + image;
        emain.value = image;
    }
    //hien modal xoa
    var showModal = (id) => {
        j('#delete_modal').modal();
        j('#delete').data('dept', id)
    }
    //ham xoa
    var deleteDept = () => {
        //console.log(e)
        console.log(j('#delete').data('dept'))
        j.post('/Admin/Department/Delete', { id: j('#delete').data('dept') }, (d) => {
            console.log({ d })
            //window.location.reload();
            j(`[iddept=""${j('#delete').data('dept')}""]`).remove();

            j('#delete_modal').modal(");
            WriteLiteral(@"'hide');

        })
    }
    var saveEdit = () => {
        obj = {
            idDept: document.getElementById('eiddept').value,
            deptName: document.getElementById('edeptname').value,
            price: parseInt(document.getElementById('eprice').value),
            images: document.getElementById('emain').value
        }
        console.log(obj);
        j.post('/Admin/Department/Edit', { obj: obj }, (d) => {
            console.log({ d })
            //window.location.reload();
            showDepartment()
            j('#edit_specialities_details').modal('hide')
        })

    }
    var saveAdd = () => {
        obj = {
            idDept: document.getElementById('aiddept').value,
            deptName: document.getElementById('adeptname').value,
            price: document.getElementById('aprice').value,
            images: document.getElementById('amain').value
        }
        j.post('/Admin/Department/Create', { obj: obj }, (d) => {
            console.log({ d ");
            WriteLiteral(@"})
            if (d != 0) {
                obj = {
                    idDept: document.getElementById('aiddept').value,
                    deptName: document.getElementById('adeptname').value,
                    price: document.getElementById('aprice').value,
                    images: document.getElementById('amain').value
                }
                //window.location.reload();
                //let h2 = document.createElement('h2');
                //h2.classList.add('table-avatar');
                //j('#sheet').append(theImage);
                //j('#sheet').append(`<tr iddept=""${obj.idDept}"">
                //                    <td>${obj.idDept}</td>
                //                    <td>
                //                        <h2 class=""table-avatar"">
                //                         <img class=""avatar-img"" src="""" height=""50"" width=""50"" alt=""Hình gì đó"">
                //                          ${obj.deptName}
                //                        ");
            WriteLiteral(@"</h2>
                //                    </td>
                //                    <td>${obj.price}</td>
                //                    <td class=""text-right"">
                //                        <div class=""actions"">
                //                            <a class=""btn btn-sm bg-success-light"" data-toggle=""modal"" href=""#edit_specialities_details"">
                //                                <i class=""fe fe-pencil"" onclick=""fadeModal(${obj.idDept},${obj.deptName},${obj.price},${obj.images})""></i> Edit
                //                            </a>
                //                            <a data-toggle=""modal"" href=""#delete_modal"" class=""btn btn-sm bg-danger-light"">
                //                                <i class=""fe fe-trash""></i> Delete
                //                            </a>
                //                        </div>
                //                    </td>
                //                </tr>`)
                //docume");
            WriteLiteral(@"nt.getElementById('sheet').getElementsByTagName('img')[document.getElementById('sheet').getElementsByTagName('img').length - 1].src = ""/assets/img/specialities/"" + obj.images;
                //// sau khi nhap xong set value may cai trong modal add thanh rong het di em
                showDepartment()
                document.getElementById('aiddept').value = """"
                document.getElementById('adeptname').value = """"
                document.getElementById('aprice').value = """"
                document.getElementById('amain').value = """"
                document.getElementById('maindiv').classList.add('d-none');
                j('#Add_Specialities_details').modal('hide')
            }
        })
    }
    //neu la true thi xoa cho o modal edit
    var deleteImage = (id, t) => {
        if (t) {
            j.post('/Admin/Department/deleteimage', { 'id': id }, function (d) {
                console.log(d);
                document.getElementById('emain').value = """";
                //d");
            WriteLiteral(@"i.remove();
                document.getElementById('ecaiquan').innerHTML = `<div class=""image-area d-none"" id=""emaindiv"">
                                        <img src="""" alt=""Preview"" id=""emainimg"" />
                                        <a class=""remove-image"" t=""edit"" style=""display: inline;"">&#215;</a>
                                    </div>`
            });
        } else {
            j.post('/Admin/Department/deleteimage', { 'id': id }, function (d) {
                console.log(d);
                document.getElementById('amain').value = """";
                //di.remove();
                document.getElementById('caiquan').innerHTML = `<div class=""image-area d-none"" id=""maindiv"">
                                        <img src="""" alt=""Preview"" id=""mainimg"" />
                                        <a class=""remove-image"" id=""image1"" style=""display: inline;"">&#215;</a>
                                    </div>`
            });
        }

    }
    j(document).on('change',");
            WriteLiteral(@" '#mainimage', function () {
        let arr = document.getElementById('mainimg').src.split(""/"");
        let id = arr[arr.length - 1];
        if (id != """") {
            deleteImage(id, false);
        }
        var files = this.files;
        var formData = new FormData();
        formData.append(""f"", files[0]);
        var str = files[0].name.split("" "").join("""");
        console.log({ str })
        j.ajax(
            {
                url: ""/Admin/Department/upload"",
                data: formData,
                processData: false,
                contentType: false,
                type: ""POST"",
                success: function (d) {
                    document.getElementById('amain').value = str;
                    document.getElementById('mainimg').src = ""/assets/img/specialities/"" + str;
                    document.getElementById('maindiv').classList.remove('d-none');
                }
            });
    });
    j(document).on('change', '#emainimage', function () {
 ");
            WriteLiteral(@"       let arr = document.getElementById('emainimg').src.split(""/"");
        let id = arr[arr.length - 1];
        if (id != """") {
            deleteImage(id, true);
        }
        var files = this.files;
        var formData = new FormData();
        formData.append(""f"", files[0]);
        var str = files[0].name.split("" "").join("""");
        console.log({ str })
        j.ajax(
            {
                url: ""/Admin/Department/upload"",
                data: formData,
                processData: false,
                contentType: false,
                type: ""POST"",
                success: function (d) {
                    document.getElementById('emain').value = str;
                    document.getElementById('emainimg').src = ""/assets/img/specialities/"" + str;
                    document.getElementById('emaindiv').classList.remove('d-none');
                }
            });
    });
    j(document).on('click', '.remove-image', function (e) {
        var arr = this.previ");
            WriteLiteral(@"ousElementSibling.src.split(""/"");
        var id = arr[arr.length - 1];
        if (j(e).attr('t') == ""edit"") {
            deleteImage(id, true);
        }
        deleteImage(id, false);
    });
    j('form input').keydown((e) => {
        if (e.keyCode == 13) {
            e.preventDefault();
            return false;
        }
    })
</script>
<!-- /Delete Modal -->
<!-- /Main Wrapper -->
<!-- jQuery -->
<!-- Bootstrap Core JS -->
");
            WriteLiteral("<!-- Custom JS -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Areas.Admin.Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591