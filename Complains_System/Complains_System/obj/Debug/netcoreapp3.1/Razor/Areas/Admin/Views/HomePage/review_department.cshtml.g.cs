#pragma checksum "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f768343c53fe17928123cd1b02b493b0754e5b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HomePage_review_department), @"mvc.1.0.view", @"/Areas/Admin/Views/HomePage/review_department.cshtml")]
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
#line 1 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
using Complains_System.Catalog.Department;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f768343c53fe17928123cd1b02b493b0754e5b2", @"/Areas/Admin/Views/HomePage/review_department.cshtml")]
    public class Areas_Admin_Views_HomePage_review_department : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Complains_System.Catalog.Admin.ComplainsManagement.ReportForDepartment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/statistical/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "get-list-complains", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout2.cshtml";
    var parms = new Dictionary<string, string>();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f768343c53fe17928123cd1b02b493b0754e5b25145", async() => {
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
#line 16 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
     using (Html.BeginForm("ReportforDepartment", "HomePage", "POST"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\r\n        <div class=\"row date-group\">\r\n\r\n            <div class=\"mt-2 getdate\">\r\n                <b>Từ Ngày:</b>\r\n                <input class=\"input-date\" type=\"date\" name=\"startdate\"");
            BeginWriteAttribute("value", " value=\"", 789, "\"", 810, 1);
#nullable restore
#line 23 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
WriteAttributeValue("", 797, DateTime.Now, 797, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""mt-2 getdate"">
                <b>Đến Ngày:</b>
                <input class=""input-date"" type=""date"" name=""enddate"">
            </div>

            <div class=""mt-2 getdate"">
                <button style=""font-weight:600"" type=""submit"" class=""btn btn-primary "">LỌC DỮ LIỆU</button>
            </div>
        </div>

    </div>
");
#nullable restore
#line 36 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
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
#line 49 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
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
#line 66 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
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
#line 83 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
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
#line 100 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
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
#line 117 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
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
    <div class=""table-responsive row mr-1 ml-1 "">
        <table class=""table table-hover"">
            <thead>
                <tr class=""table-info"">
                    <th style=""text-align:center"" scope=""col"">Phòng Ban</th>
                    <th style=""text-align:center"" scope=""col"">Đã Xử Lý</th>
                    <th style=""text-align:center"" scope=""col"">Spam</th>
                    <th style=""text-align:center"" scope=""col"">Đã Huỷ</th>
                    <th style=""text-align:center"" scope=""col"">Chờ Duyệt</thstyle=""text-align:center"">
                    <th style=""text-align:center"" scope=""col"">Hành Động</th>
                    <th style=""text-align:center"" scope=""col""");
            WriteLiteral(">Tổng Cộng</th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n\r\n");
#nullable restore
#line 146 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
                 for (int i = 0; i < Model.Total_dep; i++)
                {
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th style=\"text-align:center\"  scope=\"row\">");
#nullable restore
#line 150 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
                                                              Write(Model.Departments[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 151 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
                         for (int j = 0; j < 6; j++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"text-align:center\">\r\n\r\n");
#nullable restore
#line 155 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
                                 if (j == 4)
                                {
                                    {
                                        parms = new Dictionary<string, string>
                                                    {
                                                        { "id", Model.Departments[i].Id.ToString() },
                                                        { "start", Model.startdate.ToString() },
                                                        { "end", Model.enddate.ToString()},
                                                        {"Status", Model.Status[j] }
                                                    };
                                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <u><a");
            BeginWriteAttribute("href", " href=\"", 7412, "\"", 7452, 2);
            WriteAttributeValue("", 7419, "SendMail/", 7419, 9, true);
#nullable restore
#line 167 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
WriteAttributeValue("", 7428, Model.Departments[i].Id, 7428, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i style=\"color:red\" class=\"fa-solid fa-triangle-exclamation fa-2x\"></i></a></u>\r\n");
#nullable restore
#line 168 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
                                }
                                else if (j == 5)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f768343c53fe17928123cd1b02b493b0754e5b217637", async() => {
#nullable restore
#line 171 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
                                                                                            Write(Model.thongke[i, j - 1]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 171 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = parms;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 172 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
                                }
                                else
                                {
                                    {
                                        parms = new Dictionary<string, string>
                                                    {
                                                        { "id", Model.Departments[i].Id.ToString() },
                                                        { "start", Model.startdate.ToString() },
                                                        { "end", Model.enddate.ToString()},
                                                        {"Status", Model.Status[j] }
                                                    };
                                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f768343c53fe17928123cd1b02b493b0754e5b220579", async() => {
#nullable restore
#line 185 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
                                                                                            Write(Model.thongke[i, j]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 185 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = parms;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 186 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n");
#nullable restore
#line 188 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"


                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 192 "D:\Github\internBYS\Complains_System\Complains_System\Areas\Admin\Views\HomePage\review_department.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <!--foreach (var item in Model.Complains_list)
    {
        <div class=""mt-4"">
            <div class=""card shadow border-0"">
                <div class=""card-body "">
                    <div class=""row"">
                        <div class=""post-title col-12"">
                            <a href=""#"">
                                <div class=""card-title row"">
                                    <div class=""col-10"">
                                        <b>item.Title</b>
                                    </div>
                                    <div class=""col-2 blockquote-footer"">
                                        Trạng thái: item.Status
                                    </div>
                                </div>
                            </a>
                        </div>
                    </div>
                    <footer class=""blockquote-footer"">item.Date </footer>
                </div>
            </div");
            WriteLiteral(">\r\n        </div>\r\n    }-->\r\n");
            WriteLiteral(@"    <!--<div class=""mt-10 row d-flex justify-content-center"">
        Html.PagedListPager(Model.Complains_list, page => Url.Action(""Index"", new { page }), new PagedListRenderOptions
    {
        LiElementClasses = new string[] { ""page-item"" },
        PageClasses = new string[] { ""page-link"" }
    })
    </div>-->
");
            WriteLiteral(@"
    <script>
        // Data Picker Initialization
        config = {
            enableTime: true,
            dateFormat: ""Y-m-d""
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
            integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous"">
    </script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/");
            WriteLiteral(@"popper.js/1.14.7/umd/popper.min.js""
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
