#pragma checksum "C:\Users\gothi\source\repos\ShopASPNETCore\ShopASPNETCore\Views\Tasks\ResultList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee67f0481fbf7c93cd4bbdfcb0ce242a79014a21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_ResultList), @"mvc.1.0.view", @"/Views/Tasks/ResultList.cshtml")]
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
#line 1 "C:\Users\gothi\source\repos\ShopASPNETCore\ShopASPNETCore\Views\_ViewImports.cshtml"
using ShopASPNETCore.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee67f0481fbf7c93cd4bbdfcb0ce242a79014a21", @"/Views/Tasks/ResultList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"700358472d51e1a5d37ee57124ab04faf201e1c7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tasks_ResultList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Все задачи</h2>\r\n<h3>");
#nullable restore
#line 2 "C:\Users\gothi\source\repos\ShopASPNETCore\ShopASPNETCore\Views\Tasks\ResultList.cshtml"
Write(Model.curList);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"list-group w-auto\">\r\n");
#nullable restore
#line 4 "C:\Users\gothi\source\repos\ShopASPNETCore\ShopASPNETCore\Views\Tasks\ResultList.cshtml"
  
    foreach(var tas in Model.allTasks)
    {
        //<div class="col lg-4">
        //    <h2>Задача: @tas.Text</h2>
        //    <p>Время дедлайна: @tas.DeadlineDate.ToString()</p>
        //</div>

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label class=\"list-group-item d-flex gap-3\">\r\n          <input class=\"form-check-input flex-shrink-0\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 416, "\"", 424, 0);
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 425, "\"", 435, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 1.375em;\">\r\n          <span class=\"pt-1 form-checked-content\">\r\n            <strong>");
#nullable restore
#line 14 "C:\Users\gothi\source\repos\ShopASPNETCore\ShopASPNETCore\Views\Tasks\ResultList.cshtml"
               Write(tas.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            <small class=\"d-block text-muted\">\r\n              Время дедлайна: ");
#nullable restore
#line 16 "C:\Users\gothi\source\repos\ShopASPNETCore\ShopASPNETCore\Views\Tasks\ResultList.cshtml"
                         Write(tas.DeadlineDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </small>\r\n          </span>\r\n        </label>\r\n");
#nullable restore
#line 20 "C:\Users\gothi\source\repos\ShopASPNETCore\ShopASPNETCore\Views\Tasks\ResultList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
