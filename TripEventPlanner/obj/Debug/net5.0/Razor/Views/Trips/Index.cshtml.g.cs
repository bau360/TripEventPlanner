#pragma checksum "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97339b4a990788d500d3effc0932d26a32b73572"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trips_Index), @"mvc.1.0.view", @"/Views/Trips/Index.cshtml")]
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
#line 1 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\_ViewImports.cshtml"
using TripEventPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\_ViewImports.cshtml"
using TripEventPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97339b4a990788d500d3effc0932d26a32b73572", @"/Views/Trips/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da44cc650cd304ab64d65c9ef881dc5706f69b6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Trips_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TripEventPlanner.Models.Trip>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section>\r\n    <h1>My Trips</h1>\r\n</section>\r\n\r\n<section class=\"my-trip\">\r\n");
#nullable restore
#line 12 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <section class=\"trip-location\">\r\n            <section class=\"trip-location-imageUrl\">\r\n                <figure>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 356, "\"", 414, 1);
#nullable restore
#line 17 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
WriteAttributeValue("", 362, Html.DisplayFor(modelItem => item.Country.ImageUrl), 362, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\"");
            BeginWriteAttribute("class", " class=\"", 436, "\"", 444, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <figcaption>");
#nullable restore
#line 18 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</figcaption>\r\n                </figure>\r\n                <p> ");
#nullable restore
#line 20 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 20 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </section>\r\n        </section>\r\n");
#nullable restore
#line 23 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97339b4a990788d500d3effc0932d26a32b735726878", async() => {
                WriteLiteral("Create Trip");
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
            WriteLiteral("\r\n    </p>\r\n</section>\r\n<section>\r\n    <h3>My Activities</h3>\r\n</section>\r\n");
#nullable restore
#line 31 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
     foreach (var location in item.Country.Locations)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
         foreach (var locationItem in location.Activities)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <section class=\"trip-activities\">\r\n                <section class=\"trip-activity-imageUrl\">\r\n                    <figure>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1191, "\"", 1236, 2);
            WriteAttributeValue("", 1197, "/Images/activity/", 1197, 17, true);
#nullable restore
#line 40 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
WriteAttributeValue("", 1214, locationItem.ImageUrl, 1214, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1237, "\"", 1261, 1);
#nullable restore
#line 40 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
WriteAttributeValue("", 1243, locationItem.Name, 1243, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"trip-image\" />\r\n                    </figure>\r\n                </section>\r\n                <section class=\"trip-activity-info\">\r\n                    <span class=\"info-span\"><strong> Country: </strong>");
#nullable restore
#line 44 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                  Write(item.Country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"info-span\"><strong> Activitytype: </strong></span>\r\n                    <span class=\"info-span\"><strong> Activity Name: </strong>");
#nullable restore
#line 46 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                        Write(locationItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"info-span\"><strong> Description: </strong>");
#nullable restore
#line 47 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                      Write(locationItem.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"info-span\"><strong> Adress: </strong>");
#nullable restore
#line 48 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                 Write(locationItem.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"info-span\"><strong> Price: </strong>");
#nullable restore
#line 49 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                Write(locationItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"info-span\"><strong> Date: </strong>");
#nullable restore
#line 50 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                               Write(locationItem.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 50 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                                         Write(locationItem.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </section>\r\n            </section>\r\n");
#nullable restore
#line 53 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
         

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "E:\School Folder\PBA Webdevelopment\Semester1\Backendprogrammering\src\TripEventPlanner\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97339b4a990788d500d3effc0932d26a32b7357214195", async() => {
                WriteLiteral("Add Activity");
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
            WriteLiteral("\r\n</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TripEventPlanner.Models.Trip>> Html { get; private set; }
    }
}
#pragma warning restore 1591
