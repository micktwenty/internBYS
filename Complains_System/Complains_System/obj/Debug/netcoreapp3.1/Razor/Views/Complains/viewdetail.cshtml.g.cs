#pragma checksum "D:\Github\internBYS\Complains_System\Complains_System\Views\Complains\viewdetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38c04fd1c06577911ea4a3d5a20f2568c8c0d5bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Complains_viewdetail), @"mvc.1.0.view", @"/Views/Complains/viewdetail.cshtml")]
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
#line 1 "D:\Github\internBYS\Complains_System\Complains_System\Views\_ViewImports.cshtml"
using Complains_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\internBYS\Complains_System\Complains_System\Views\_ViewImports.cshtml"
using Complains_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Github\internBYS\Complains_System\Complains_System\Views\Complains\viewdetail.cshtml"
using Complains_System.Catalog.Complains.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38c04fd1c06577911ea4a3d5a20f2568c8c0d5bf", @"/Views/Complains/viewdetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc8fe3b62841e00b0021adb7b9aba5d85f60f77", @"/Views/_ViewImports.cshtml")]
    public class Views_Complains_viewdetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComplainsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("blah"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "D:\Github\internBYS\Complains_System\Complains_System\Views\Complains\viewdetail.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <div class=\"mt-4\">\r\n                        <div class=\"form container\">\r\n                            <div class=\"form-title mb-4\">\r\n                                <p>");
#nullable restore
#line 14 "D:\Github\internBYS\Complains_System\Complains_System\Views\Complains\viewdetail.cshtml"
                              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <hr />\r\n");
            WriteLiteral("                            <div class=\"mb-3\">\r\n                                <label for=\"exampleFormControlInput1\" class=\"form-label\">Ngày đăng:</label>\r\n                                <input class=\"form-control\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1036, "\"", 1055, 1);
#nullable restore
#line 24 "D:\Github\internBYS\Complains_System\Complains_System\Views\Complains\viewdetail.cshtml"
WriteAttributeValue("", 1044, Model.Date, 1044, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled\r\n                                       readonly>\r\n                            </div>\r\n");
#nullable restore
#line 27 "D:\Github\internBYS\Complains_System\Complains_System\Views\Complains\viewdetail.cshtml"
                             if (@Url.Content(Model.picture) != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"mb-3\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38c04fd1c06577911ea4a3d5a20f2568c8c0d5bf5617", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1363, "~/ImgComplains/", 1363, 15, true);
#nullable restore
#line 30 "D:\Github\internBYS\Complains_System\Complains_System\Views\Complains\viewdetail.cshtml"
AddHtmlAttributeValue("", 1378, Url.Content(Model.picture), 1378, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 32 "D:\Github\internBYS\Complains_System\Complains_System\Views\Complains\viewdetail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <div class=""mb-3"">
                                <label class=""form-label"">Nội dung:</label>
                                <textarea class=""form-control"" rows=""5"" disabled
                                          readonly>");
#nullable restore
#line 37 "D:\Github\internBYS\Complains_System\Complains_System\Views\Complains\viewdetail.cshtml"
                                              Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </textarea>
                            </div>
                            <div class=""mb-3"">
                                <label class=""form-label"">Nội dung phản hồi:</label>
                                <textarea class=""form-control"" rows=""5"" disabled
                                          readonly>");
#nullable restore
#line 43 "D:\Github\internBYS\Complains_System\Complains_System\Views\Complains\viewdetail.cshtml"
                                               Write((Model.Reply == null)?"Chưa có phản hồi.":Model.Reply);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </textarea>
                            </div>


                        </div>


                    </div>
                


    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""
            integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous"">
    </script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""
            integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous"">
    </script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""
            integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous"">
    </script>
    <script>
        function readURL(input) {
            if (input.files && input.files[0");
            WriteLiteral(@"]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    $('#blah')
                        .attr('src', e.target.result);
                };

                reader.readAsDataURL(input.files[0]);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComplainsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
