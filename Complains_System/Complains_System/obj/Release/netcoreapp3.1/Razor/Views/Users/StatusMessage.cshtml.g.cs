#pragma checksum "D:\Github\internBYS\Complains_System\Complains_System\Views\Users\StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdc462d1f4c5c291ec1ede080ed3708655426ffc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_StatusMessage), @"mvc.1.0.view", @"/Views/Users/StatusMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc462d1f4c5c291ec1ede080ed3708655426ffc", @"/Views/Users/StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc8fe3b62841e00b0021adb7b9aba5d85f60f77", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Github\internBYS\Complains_System\Complains_System\Views\Users\StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 262, "\"", 319, 4);
            WriteAttributeValue("", 270, "alert", 270, 5, true);
            WriteAttributeValue(" ", 275, "alert-", 276, 7, true);
#nullable restore
#line 9 "D:\Github\internBYS\Complains_System\Complains_System\Views\Users\StatusMessage.cshtml"
WriteAttributeValue("", 282, statusMessageClass, 282, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 301, "alert-dismissible", 302, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\"\r\n            aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n    ");
#nullable restore
#line 14 "D:\Github\internBYS\Complains_System\Complains_System\Views\Users\StatusMessage.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n\r\n</div>\r\n");
#nullable restore
#line 18 "D:\Github\internBYS\Complains_System\Complains_System\Views\Users\StatusMessage.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591