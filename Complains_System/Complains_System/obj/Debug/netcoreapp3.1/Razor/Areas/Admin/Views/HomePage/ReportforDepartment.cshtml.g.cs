#pragma checksum "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c5ce8c44f3bdbb0b3e9031c63f4a1ddafca3e11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HomePage_ReportforDepartment), @"mvc.1.0.view", @"/Areas/Admin/Views/HomePage/ReportforDepartment.cshtml")]
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
#line 1 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
using Complains_System.Catalog.Department;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c5ce8c44f3bdbb0b3e9031c63f4a1ddafca3e11", @"/Areas/Admin/Views/HomePage/ReportforDepartment.cshtml")]
    public class Areas_Admin_Views_HomePage_ReportforDepartment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Complains_System.Catalog.Admin.ComplainsManagement.ReportForDepartment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/statistical/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c5ce8c44f3bdbb0b3e9031c63f4a1ddafca3e114635", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 13 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
     using (Html.BeginForm("ReportforDepartment", "HomePage", "POST"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row date-group\">\r\n\r\n            <div class=\"getdate\">\r\n                <b>Từ Ngày:</b>\r\n                <input class=\"input-date\" type=\"date\" name=\"startdate\"");
            BeginWriteAttribute("value", " value=\"", 642, "\"", 669, 2);
#nullable restore
#line 19 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
WriteAttributeValue("", 650, DateTime.Now.Year, 650, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 668, "/", 668, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""getdate"">
                <b>Đến Ngày:</b>
                <input class=""input-date"" type=""date"" name=""enddate"">
            </div>

            <div class=""getdate"">
                <button type=""submit"" class=""btn btn-primary "">Lọc Dữ Liệu</button>
            </div>
        </div>
");
#nullable restore
#line 30 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <hr>
    <div class=""row d-flex justify-content-lg-around"">
        <div class=""col-xl-2 col-md-3 mb-4"">
            <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">
                                Đã Xử Lý
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 43 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                                                                           Write(Model.Done);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fa-solid fa-ban fa-2x text-gray-800""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-2 col-md-3 mb-4"">
            <div class=""card border-left-danger shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-danger text-uppercase mb-1"">
                                Spam
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 60 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                                                                           Write(Model.Spam);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-comments fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-2 col-md-3 mb-4"">
            <div class=""card border-left-secondary shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-secondary text-uppercase mb-1"">
                                Đã Huỷ
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 77 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                                                                           Write(Model.Cancel);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-calendar fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-2 col-md-3 mb-4"">
            <div class=""card border-left-warning shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">
                                Chờ Duyệt
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 94 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                                                                           Write(Model.Request);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fa-solid fa-circle-plus fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-2 col-md-3 mb-4"">
            <div class=""card border-left-info shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">
                                Tổng Cộng
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 111 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                                                                           Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fa-solid fa-circle-plus fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <hr>
    <div class=""row mr-1 ml-1 "">
        <table class=""table table-hover"">
            <thead>
                <tr class=""table-info"">
                    <th scope=""col"">Phòng Ban</th>
                    <th scope=""col"">Đã Xử Lý</th>
                    <th scope=""col"">Spam</th>
                    <th scope=""col"">Đã Huỷ</th>
                    <th scope=""col"">Chờ Duyệt</th>
                    <th scope=""col"">Tổng Cộng</th>
                </tr>
            </thead>

            <tbody>

");
#nullable restore
#line 139 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                 for (int i = 0; i < Model.Total_dep; i++)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 143 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                                   Write(Model.Departments[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 144 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                         for (int j = 0; j < 5; j++)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                ");
#nullable restore
#line 148 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                           Write(Model.thongke[i, j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 149 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                                 if (j == 3)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <u><b><a style=\"color:red;\"");
            BeginWriteAttribute("href", " href=\"", 6302, "\"", 6342, 2);
            WriteAttributeValue("", 6309, "SendMail/", 6309, 9, true);
#nullable restore
#line 152 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
WriteAttributeValue("", 6318, Model.Departments[i].Id, 6318, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">   Warning!</a></b></u>\r\n");
#nullable restore
#line 153 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n");
#nullable restore
#line 155 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"


                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 159 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 163 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
     foreach (var item in Model.Complains_list)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""mt-4"">
            <div class=""card shadow border-0"">
                <div class=""card-body "">
                    <div class=""row"">
                        <div class=""post-title col-12"">
                            <a href=""#"">
                                <div class=""card-title row"">
                                    <div class=""col-10"">
                                        <b>");
#nullable restore
#line 173 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                    </div>\r\n                                    <div class=\"col-2 blockquote-footer\">\r\n                                        Trạng thái: ");
#nullable restore
#line 176 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                    <footer class=\"blockquote-footer\">");
#nullable restore
#line 182 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
                                                 Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </footer>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 186 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("    <div class=\"mt-10 row d-flex justify-content-center\">\r\n        ");
#nullable restore
#line 191 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\ReportforDepartment.cshtml"
   Write(Html.PagedListPager(Model.Complains_list, page => Url.Action("ReportforDepartment", new {Model.date, page }), new PagedListRenderOptions
   {
       LiElementClasses = new string[] { "page-item" },
       PageClasses = new string[] { "page-link" }
   }));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral(@"
    <script>
            // Data Picker Initialization
            config = {
                enableTime: true,
                dateFormat: ""Y-m-d H:i"",
            }
            flatpickr(""input[type=datetime-local]"", {})
    </script>


    <script>
            ""use strict"";
            const menus = document.querySelectorAll('.menu');
            menus.forEach(menu => {
                const menuItems = menu.querySelectorAll('.menu-item');
                menuItems.forEach((item) => {
                    item.addEventListener('click', e => {
                        menuItems.forEach(item => item.classList.remove('active'));
                        const target = e.target;
                        target.classList.add('active');
                    });
                });
            });
    </script>
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""
            integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymo");
            WriteLiteral(@"us"">
    </script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""
            integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous"">
    </script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""
            integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous"">
    </script>
    <!-- flatpickr -->
    <script src=""https://cdn.jsdelivr.net/npm/flatpickr""></script>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Complains_System.Catalog.Admin.ComplainsManagement.ReportForDepartment> Html { get; private set; }
    }
}
#pragma warning restore 1591
