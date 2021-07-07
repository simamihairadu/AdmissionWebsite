#pragma checksum "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06d5fa0ab16a9cda52b9421868685f6cf5d3d9f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_Index), @"mvc.1.0.view", @"/Views/Session/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06d5fa0ab16a9cda52b9421868685f6cf5d3d9f3", @"/Views/Session/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a5eb55211a67d80d48cd85c91b956bab80c59e", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdmissionWebsiteFinal.Models.SessionViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Sessions</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06d5fa0ab16a9cda52b9421868685f6cf5d3d9f34379", async() => {
                WriteLiteral("Add session");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 12 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Current Active Session</h3>\r\n");
#nullable restore
#line 14 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
 if (SessionViewModel.CurrentActiveSession != null)
{
    string tableColor = "table-success";

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
     if (SessionViewModel.CurrentActiveSession.Expired)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-danger\">\r\n            Session expired.\r\n        </p>\r\n");
#nullable restore
#line 23 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
        tableColor = "table-danger";
    }
    else if (SessionViewModel.CurrentActiveSession.ConfirmationStage)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-warning\">\r\n            Confirmation stage has started.\r\n        </p>\r\n");
#nullable restore
#line 30 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
        tableColor = "table-warning";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container mb-5\">\r\n        <table");
            BeginWriteAttribute("class", " class=\"", 842, "\"", 882, 3);
            WriteAttributeValue("", 850, "table", 850, 5, true);
            WriteAttributeValue(" ", 855, "table-bordered", 856, 15, true);
#nullable restore
#line 34 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
WriteAttributeValue(" ", 870, tableColor, 871, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <thead>
                <tr>
                    <th>
                        Id
                    </th>
                    <th>
                        Start Date
                    </th>
                    <th>
                        End Date
                    </th>
                    <th>
                        Active
                    </th>
                    <th>
                        Confirmation Stage
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        ");
#nullable restore
#line 58 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
                   Write(SessionViewModel.CurrentActiveSession.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
                   Write(SessionViewModel.CurrentActiveSession.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
                   Write(SessionViewModel.CurrentActiveSession.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
                    Write(SessionViewModel.CurrentActiveSession.Active ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
                    Write(SessionViewModel.CurrentActiveSession.ConfirmationStage ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06d5fa0ab16a9cda52b9421868685f6cf5d3d9f310284", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
                                                  WriteLiteral(SessionViewModel.CurrentActiveSession.Id);

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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 79 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3 class=\"mb-5\">\r\n    Session History\r\n</h3>\r\n<table class=\"table text-nowrap table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 87 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 90 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 93 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 96 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 102 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 106 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 109 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 112 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 115 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
                Write(item.Active?"Yes":"No");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06d5fa0ab16a9cda52b9421868685f6cf5d3d9f316058", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
                                              WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06d5fa0ab16a9cda52b9421868685f6cf5d3d9f318254", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
                                             WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 122 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Session\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdmissionWebsiteFinal.Models.SessionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
