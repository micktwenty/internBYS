#pragma checksum "E:\internBYS\Complains_System\Complains_System\Areas\Admin\Views\UsersManagement\usermanager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0fbc64ed6c06be8c691c110563bb21300b23019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_UsersManagement_usermanager), @"mvc.1.0.view", @"/Areas/Admin/Views/UsersManagement/usermanager.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0fbc64ed6c06be8c691c110563bb21300b23019", @"/Areas/Admin/Views/UsersManagement/usermanager.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_UsersManagement_usermanager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/admin/manage_user/css/style.css  />\r\n    <link rel="), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("integrity", new global::Microsoft.AspNetCore.Html.HtmlString("sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("crossorigin", new global::Microsoft.AspNetCore.Html.HtmlString("anonymous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\internBYS\Complains_System\Complains_System\Areas\Admin\Views\UsersManagement\usermanager.cshtml"
  
    ViewData["Title"] = "usermanager";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0fbc64ed6c06be8c691c110563bb21300b230195300", async() => {
                WriteLiteral("\r\n\r\n    <title>Trang Quản Lý Tài Khoản Người Dùng</title>\r\n    <!-- Required meta tags -->\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <!-- Bootstrap CSS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0fbc64ed6c06be8c691c110563bb21300b230195818", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("stylesheet\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0fbc64ed6c06be8c691c110563bb21300b230198293", async() => {
                WriteLiteral(@"
    <div class=""d-flex align-items-center"">
        <div class=""col-8"">
            <form class=""d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"">
                <div class=""input-group"">
                    <input id=""search-height"" type=""text"" class=""form-control bg-light border-0 small""
                           placeholder=""Tìm kiếm..."" aria-label=""Search"" aria-describedby=""basic-addon2"">
                    <div class=""input-group-append"">
                        <button id=""btn-search"" class=""btn btn-primary"" type=""button"">
                            <i class=""fas fa-search fa-sm""></i>
                        </button>
                    </div>
                </div>
            </form>
        </div>
        <div class=""col-4 d-flex justify-content-center"" style=""margin: 0 0 0 0"">
            <button class=""btn btn-success btn-save"" type=""submit"">LƯU</button>
        </div>

    </div>


    <div class=""row mr-4 ml-4"">
        <table cl");
                WriteLiteral(@"ass=""table table-hover table-bordered"">
            <thead>
                <tr class=""table-info"">
                    <th scope=""col"">Tên tài khoản</th>
                    <th scope=""col"">Tình trạng</th>
                    <th scope=""col"" colspan=""3"">Hành động</th>
                </tr>

            </thead>
            <tbody>
                <tr>
                    <th scope=""row"">nqthanh452@gmail.com</th>
                    <td>
                        <div class=""custom-control custom-switch"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""customSwitch1"" checked>
                            <label class=""custom-control-label"" for=""customSwitch1""></label>
                        </div>
                    </td>
                    <td><label for=""nav-input"" class=""btn btn-primary"">Cấp quyền</label></td>
                    <td><button class=""btn btn-warning"">Đặt lại mật khẩu</button></td>
                    <td><button class=""btn btn-danger"">X");
                WriteLiteral(@"oá</td>
                </tr>


        </table>
    </div>
    <input hidden class=""form-check-input"" type=""checkbox"" id=""nav-input"">
    <label for=""nav-input"" class=""over_lay""></label>
    <div id=""content"" class=""gb-1"">
        <label id=""btn-close"" for=""nav-input"" class=""close_form"">
            <i class=""fa-2x fa-solid fa-square-xmark""></i>
        </label>
        <div class=""form_table "">
            <table class=""open_form table table-hover table-bordered"">

                <thead>
                    <tr class=""table-info"">
                        <th scope=""row"" rowspan=""2"">
                            nqthanh452@gmail.com
                        </th>
                        <th scope=""col"">ADMIN</th>
                        <th scope=""col"">BAN GIÁM HIỆU</th>
                        <th scope=""col"">NHÂN VIÊN PHÒNG BAN</th>
                        <th scope=""col"">SINH VIÊN</th>
                    </tr>
                    <tr>
                        <th scope=""row""><inpu");
                WriteLiteral("t class=\"form-check-input\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 3807, "\"", 3815, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"defaultCheck1\"></th>\r\n                        <th scope=\"row\"><input class=\"form-check-input\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 3930, "\"", 3938, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"defaultCheck1\"></th>\r\n                        <th scope=\"row\"><input class=\"form-check-input\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 4053, "\"", 4061, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"defaultCheck1\"></th>\r\n                        <th scope=\"row\"><input class=\"form-check-input\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 4176, "\"", 4184, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""defaultCheck1""></th>
                    </tr>
                </thead>

            </table>
        </div>

    </div>


    <!-- JS cho hien popup -->
    <script>
        document.getElementById(""btn-fix"").onclick = function () {
            document.getElementById(""content"").style.display = 'block ';
        };

        document.getElementById(""btn-close"").onclick = function () {
            document.getElementById(""content"").style.display = 'none';
        };


    </script>

");
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
            WriteLiteral(@"

<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591