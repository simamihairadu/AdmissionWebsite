#pragma checksum "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98485939f9f50a6cdc067888442e18fe16a8522d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admission_EntryDetails), @"mvc.1.0.view", @"/Views/Admission/EntryDetails.cshtml")]
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
#line 1 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\_ViewImports.cshtml"
using AdmissionWebsiteFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\_ViewImports.cshtml"
using AdmissionWebsiteFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98485939f9f50a6cdc067888442e18fe16a8522d", @"/Views/Admission/EntryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a5eb55211a67d80d48cd85c91b956bab80c59e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admission_EntryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdmissionWebsiteFinal.Models.AdmissionEntryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
  
    ViewData["Title"] = "EntryDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Entry Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ContestantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.ContestantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.EntryScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.EntryScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Contestant.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.Contestant.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Contestant.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.Contestant.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Contestant.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.Contestant.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Contestant.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.Contestant.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Contestant.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.Contestant.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Contestant.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.Contestant.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 61 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.RromSpot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.RromSpot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 67 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.RDPSpot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 70 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.RDPSpot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 73 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 76 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 79 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 82 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <h4>Options</h4>\r\n");
#nullable restore
#line 88 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
     if (Model.Options != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table text-nowrap table-bordered table-striped\">\r\n            <tbody>\r\n");
#nullable restore
#line 92 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
                 foreach (var item in Model.Options)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 96 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
                        Write(item.Specialization.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 99 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 102 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98485939f9f50a6cdc067888442e18fe16a8522d14224", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 105 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\EntryDetails.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98485939f9f50a6cdc067888442e18fe16a8522d16392", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdmissionWebsiteFinal.Models.AdmissionEntryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
