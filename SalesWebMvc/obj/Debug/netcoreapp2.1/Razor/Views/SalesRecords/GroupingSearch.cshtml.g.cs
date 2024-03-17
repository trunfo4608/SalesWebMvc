#pragma checksum "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "547d3d0ce3e593abeec49c4f5ba8f521294cbcd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_GroupingSearch), @"mvc.1.0.view", @"/Views/SalesRecords/GroupingSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/GroupingSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_GroupingSearch))]
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
#line 1 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"547d3d0ce3e593abeec49c4f5ba8f521294cbcd6", @"/Views/SalesRecords/GroupingSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_GroupingSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Departament,SalesRecord>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
  

    ViewData["Title"] = "Grouping Search";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
            BeginContext(253, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(260, 17, false);
#line 10 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(277, 86, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"nav navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(363, 589, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "547d3d0ce3e593abeec49c4f5ba8f521294cbcd65122", async() => {
                BeginContext(415, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 630, "", 657, 1);
#line 18 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 637, ViewData["minDate"], 637, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(657, 204, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 861, "", 888, 1);
#line 22 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 868, ViewData["maxDate"], 868, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(888, 57, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(952, 24, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
            EndContext();
#line 29 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
 foreach (var departamentGroup in Model)
{

#line default
#line hidden
            BeginContext(1021, 112, true);
            WriteLiteral("<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Departamens ");
            EndContext();
            BeginContext(1134, 25, false);
#line 33 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                       Write(departamentGroup.Key.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1159, 16, true);
            WriteLiteral(", Total Sales = ");
            EndContext();
            BeginContext(1176, 64, false);
#line 33 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                                                                 Write(departamentGroup.Key.TotalSales(minDate, maxDate).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 554, true);
            WriteLiteral(@" </h3>
    </div>
    <div class=""panel-body"">
        <table class=""table table-striped"" table-hover>
            <thead>
                <tr>
                    <th>
                        Date
                    </th>
                    <th>
                        Amount
                    </th>
                    <th>
                        Seller
                    </th>
                    <th>
                        Status
                    </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 54 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                 foreach (var item in departamentGroup)
                {

#line default
#line hidden
            BeginContext(1870, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1955, 39, false);
#line 58 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1994, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2086, 41, false);
#line 61 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(itemModel => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2219, 46, false);
#line 64 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(itemModel => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2265, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2357, 41, false);
#line 67 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(itemModel => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2398, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 70 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(2477, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 75 "C:\Users\trunf\source\repos\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Departament,SalesRecord>>> Html { get; private set; }
    }
}
#pragma warning restore 1591