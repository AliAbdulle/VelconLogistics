#pragma checksum "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b90f0da5bf5971b4556c6f6bee07d8328385b12e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loads_Details), @"mvc.1.0.view", @"/Views/Loads/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Loads/Details.cshtml", typeof(AspNetCore.Views_Loads_Details))]
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
#line 1 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\_ViewImports.cshtml"
using VelconLogistics;

#line default
#line hidden
#line 2 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\_ViewImports.cshtml"
using VelconLogistics.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b90f0da5bf5971b4556c6f6bee07d8328385b12e", @"/Views/Loads/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c47f7cbd0ea75a27c1f1ca2497c55a79527153c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Loads_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VOLogistics.Models.Load>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 134, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Load</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n     \r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(212, 42, false);
#line 15 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(254, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(318, 38, false);
#line 18 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(356, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(419, 46, false);
#line 21 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PickupDate));

#line default
#line hidden
            EndContext();
            BeginContext(465, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(529, 42, false);
#line 24 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayFor(model => model.PickupDate));

#line default
#line hidden
            EndContext();
            BeginContext(571, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(634, 48, false);
#line 27 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeliverdDate));

#line default
#line hidden
            EndContext();
            BeginContext(682, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(746, 44, false);
#line 30 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeliverdDate));

#line default
#line hidden
            EndContext();
            BeginContext(790, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(853, 44, false);
#line 33 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(897, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(961, 40, false);
#line 36 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1064, 42, false);
#line 39 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Driver));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1170, 47, false);
#line 42 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayFor(model => model.Driver.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1280, 46, false);
#line 45 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDeliverd));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1390, 42, false);
#line 48 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDeliverd));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1479, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b90f0da5bf5971b4556c6f6bee07d8328385b12e9856", async() => {
                BeginContext(1529, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Ali Dhobey\workspace\Projects\VelconLogistics\VelconLogistics\VelconLogistics\Views\Loads\Details.cshtml"
                           WriteLiteral(Model.LoadId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1537, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1545, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b90f0da5bf5971b4556c6f6bee07d8328385b12e12215", async() => {
                BeginContext(1567, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1583, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VOLogistics.Models.Load> Html { get; private set; }
    }
}
#pragma warning restore 1591
