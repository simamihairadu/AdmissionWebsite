#pragma checksum "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00b2c82f8abf42cf518e02677138c28f3ee8a469"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Standings_Index), @"mvc.1.0.view", @"/Views/Standings/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00b2c82f8abf42cf518e02677138c28f3ee8a469", @"/Views/Standings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a5eb55211a67d80d48cd85c91b956bab80c59e", @"/Views/_ViewImports.cshtml")]
    public class Views_Standings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdmissionWebsiteFinal.Models.StandingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Standings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StandingsToPdf", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EntryDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b2c82f8abf42cf518e02677138c28f3ee8a4695003", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 6 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
       Write(Html.DropDownListFor(m => m.OptionId, new SelectList(Model.Options, "Id", "Specialization.Name"), "Select Specialization", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 9 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
       Write(Html.DropDownList("filterMethod",new List<SelectListItem>{
                                              new SelectListItem{ Text = "All",Value ="1" },
                                              new SelectListItem{ Text = "Confirmed",Value ="2"},},"Select Filter", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Get\" class=\"btn btn-primary\" />\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"float-right\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b2c82f8abf42cf518e02677138c28f3ee8a4697710", async() => {
                WriteLiteral("Export to PDF.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<h1>Buget</h1>
<table class=""table text-nowrap table-bordered"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Score
            </th>
            <th>
                CNP
            </th>
            <th>
                First Name
            </th>
            <th>
                Last Name
            </th>
            <th>
                Date Created
            </th>
            <th></th>
        </tr>
    </thead>
");
#nullable restore
#line 46 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
     if (Model.BugetEntries != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n");
#nullable restore
#line 49 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
             foreach (var item in Model.BugetEntries)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=", 1626, "", 1675, 1);
#nullable restore
#line 51 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
WriteAttributeValue("", 1633, item.ConfirmedOption?"table-success":"", 1633, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EntryScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ContestantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <th class=\"font-weight-normal\">\r\n                        ");
#nullable restore
#line 62 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Contestant.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"font-weight-normal\">\r\n                        ");
#nullable restore
#line 65 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Contestant.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b2c82f8abf42cf518e02677138c28f3ee8a46912918", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 74 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n");
#nullable restore
#line 76 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>

<h1>Taxa</h1>
<table class=""table text-nowrap table-bordered"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Score
            </th>
            <th>
                CNP
            </th>
            <th>
                First Name
            </th>
            <th>
                Last Name
            </th>
            <th>
                Date Created
            </th>
            <th></th>
        </tr>
    </thead>
");
#nullable restore
#line 104 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
     if (Model.TaxaEntries != null)
    {
        int i = 0;
        string tableColor = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<tbody>\r\n");
#nullable restore
#line 109 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
     foreach (var item in Model.TaxaEntries)
    {
        if (item.ConfirmedOption == true)
        {
            tableColor = "table-success";
        }
        if (i >= Model.Option.LocuriTaxa)
        {
            tableColor = "table-warning";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("class", " class=", 3642, "", 3660, 1);
#nullable restore
#line 119 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
WriteAttributeValue("", 3649, tableColor, 3649, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EntryScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContestantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <th class=\"font-weight-normal\">\r\n                ");
#nullable restore
#line 130 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contestant.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"font-weight-normal\">\r\n                ");
#nullable restore
#line 133 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contestant.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b2c82f8abf42cf518e02677138c28f3ee8a46919700", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 139 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 142 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
        i++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n");
#nullable restore
#line 145 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>

<h2>Locuri Rrom</h2>
<table class=""table text-nowrap table-bordered"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Score
            </th>
            <th>
                CNP
            </th>
            <th>
                First Name
            </th>
            <th>
                Last Name
            </th>
            <th>
                Date Created
            </th>
            <th></th>
        </tr>
    </thead>
");
#nullable restore
#line 173 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
     if (Model.RromEntries != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n");
#nullable restore
#line 176 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
             foreach (var item in Model.RromEntries)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=", 5219, "", 5268, 1);
#nullable restore
#line 178 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
WriteAttributeValue("", 5226, item.ConfirmedOption?"table-success":"", 5226, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        ");
#nullable restore
#line 180 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 183 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EntryScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 186 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ContestantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <th class=\"font-weight-normal\">\r\n                        ");
#nullable restore
#line 189 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Contestant.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"font-weight-normal\">\r\n                        ");
#nullable restore
#line 192 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Contestant.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <td>\r\n                        ");
#nullable restore
#line 195 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b2c82f8abf42cf518e02677138c28f3ee8a46926466", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 198 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 201 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n");
#nullable restore
#line 203 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>

<h2>Locuri Romani de pretutindeni</h2>
<table class=""table text-nowrap table-bordered "">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Score
            </th>
            <th>
                CNP
            </th>
            <th>
                First Name
            </th>
            <th>
                Last Name
            </th>
            <th>
                Date Created
            </th>
            <th></th>
        </tr>
    </thead>
");
#nullable restore
#line 231 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
     if (Model.RDPEntries != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n");
#nullable restore
#line 234 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
             foreach (var item in Model.RDPEntries)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=", 7022, "", 7071, 1);
#nullable restore
#line 236 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
WriteAttributeValue("", 7029, item.ConfirmedOption?"table-success":"", 7029, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        ");
#nullable restore
#line 238 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 241 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EntryScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 244 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ContestantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <th class=\"font-weight-normal\">\r\n                        ");
#nullable restore
#line 247 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Contestant.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"font-weight-normal\">\r\n                        ");
#nullable restore
#line 250 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Contestant.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <td>\r\n                        ");
#nullable restore
#line 253 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b2c82f8abf42cf518e02677138c28f3ee8a46933275", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 256 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 259 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n");
#nullable restore
#line 261 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Standings\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdmissionWebsiteFinal.Models.StandingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
