#pragma checksum "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eee492a7555151ea701712259d4d42c37169c38a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pets_Details), @"mvc.1.0.view", @"/Views/Pets/Details.cshtml")]
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
#line 1 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\_ViewImports.cshtml"
using Where_is_my_Fluffymoon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\_ViewImports.cshtml"
using Where_is_my_Fluffymoon.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
using Where_is_my_Fluffymoon.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eee492a7555151ea701712259d4d42c37169c38a", @"/Views/Pets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb63ced82bbcb7077a0a8bce398b916c3b16ba33", @"/Views/_ViewImports.cshtml")]
    public class Views_Pets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Where_is_my_Fluffymoon.Models.Pet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CommentsCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("EncType", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CommentDeleteConfirmed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
  
    string CalculateRelativeTime(DateTime date)
    {
        TimeSpan ts = DateTime.Now - date;
        if (ts.TotalMinutes < 1)//seconds ago
            return "just now";
        if (ts.TotalHours < 1)//min ago
            return ts.TotalMinutes == 1 ? "1 Minute ago" : (int)ts.TotalMinutes + " Minutes ago";
        if (ts.TotalDays < 1)//hours ago
            return ts.TotalHours == 1 ? "1 Hour ago" : (int)ts.TotalHours + " Hours ago";
        if (ts.TotalDays < 7)//days ago
            return ts.TotalDays == 1 ? "1 Day ago" : (int)ts.TotalDays + " Days ago";
        if (ts.TotalDays < 30.4368)//weeks ago
            return (ts.TotalDays / 7) == 1 ? "1 Week ago" : (int)(ts.TotalDays / 7) + " Weeks ago";
        if (ts.TotalDays < 365.242)//months ago
            return (ts.TotalDays / 30.4368) == 1 ? "1 Month ago" : (int)(ts.TotalDays / 30.4368) + " Months ago";
        //years ago
        return (ts.TotalDays / 365.242) == 1 ? "1 Year ago" : (int)(ts.TotalDays / 365.242) + " Years ago";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script");
            BeginWriteAttribute("src", " src=\"", 1327, "\"", 1366, 1);
#nullable restore
#line 35 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
WriteAttributeValue("", 1333, Url.Content("~/scripts/maps.js"), 1333, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></script>

<style>
    .date {
        font-size: 11px
    }

    .comment-text {
        font-size: 12px
    }

    .fs-12 {
        font-size: 12px
    }

    .shadow-none {
        box-shadow: none
    }

    .name {
        color: #007bff
    }

    .cursor:hover {
        color: blue
    }

    .cursor {
        cursor: pointer
    }

    .textarea {
        resize: none
    }
</style>


<h1>Details</h1>

<div>
    <hr />

    <div class=""row"">
        <div class=""col-sm-4"">
");
#nullable restore
#line 79 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
         if(Model.ImagePath != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"card-img\"");
            BeginWriteAttribute("src", " src=\"", 1983, "\"", 2049, 1);
#nullable restore
#line 81 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
WriteAttributeValue("", 1989, Url.Content(string.Format("~/PetImages/{0}.jpg", Model.Id)), 1989, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"pet-image\">\r\n");
#nullable restore
#line 82 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img class=\"card-img\"");
            BeginWriteAttribute("src", " src=\"", 2138, "\"", 2185, 1);
#nullable restore
#line 85 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
WriteAttributeValue("", 2144, Url.Content("~/HelperImages/no-pet.jpg"), 2144, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"no-pet-image\">\r\n");
#nullable restore
#line 86 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-sm-8\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 91 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 94 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                    Created at\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 100 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
               Write(Html.DisplayFor(model => model.Created_at));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-3\">\r\n                   Updated at\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 106 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
               Write(Html.DisplayFor(model => model.Updated_at));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <a target=\"_blank\"");
            BeginWriteAttribute("href", "  href=\'", 3036, "\'", 3145, 1);
#nullable restore
#line 109 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
WriteAttributeValue("", 3044, string.Format("https://www.google.com/maps/?q={0},{1}", Model.CoordinatesLat, Model.CoordinatesLong), 3044, 101, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">I was there</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee492a7555151ea701712259d4d42c37169c38a14634", async() => {
                WriteLiteral("Back to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee492a7555151ea701712259d4d42c37169c38a15883", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 117 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
     if (Convert.ToString(Model.ApplicationUser.Id) == Convert.ToString(ViewData["userId"]))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee492a7555151ea701712259d4d42c37169c38a17451", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee492a7555151ea701712259d4d42c37169c38a19705", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 121 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<hr />\r\n<h4>Add a comment</h4>\r\n<div class=\"row\">\r\n    <div class=\"col-md-6 card h-100\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee492a7555151ea701712259d4d42c37169c38a22300", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\" hidden>\r\n                <input name=\"PetId\" for=\"PetId\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3977, "\"", 3994, 1);
#nullable restore
#line 130 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
WriteAttributeValue("", 3985, Model.Id, 3985, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></input>
            </div>
            <div class=""d-flex flex-row add-comment-section mt-4 mb-4"">
                <input name=""CoordinatesLong"" for=""CoordinatesLong"" class=""form-control mr-3"" placeholder=""longitude"" id=""long"" type=""number"" step=""any"" />
                <input name=""CoordinatesLat"" for=""CoordinatesLat"" class=""form-control mr-3"" placeholder=""latitude"" id=""lat"" type=""number"" step=""any"" />
                <button name=""gps-button"" class=""btn btn-info"" type=""button"" onclick=""setGPSCoords()"">GPS</button>
            </div>
            <div class=""d-flex flex-row add-comment-section mt-4 mb-4"">
                <input runat=""server"" type=""file"" for=""ImagePath"" class=""form-control"" id=""customFile"" name=""customFile"" />
            </div>
            <div class=""d-flex flex-row add-comment-section mt-4 mb-4"">
                <input name=""Message"" for=""Message"" class=""form-control mr-3"" placeholder=""Add comment"" />
                <button class=""btn btn-primary"" type=""submit"">Comment</butt");
                WriteLiteral("on>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\" style=\"min-height: 400px;\">\r\n        <div id=\"map\" style=\"width:100%; height: 100%;\"></div>\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n\r\n<div class=\"comment-bottom bg-white p-2 px-4\">\r\n");
#nullable restore
#line 154 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
     foreach (var item in ViewBag.comments)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container mt-5"">
            <div class=""d-flex justify-content-center row"">
                <div class=""col-md-8"">
                    <div class=""d-flex flex-column comment-section shadow p-1"">
                        <div class=""bg-white p-2"">
                            <div class=""d-flex flex-row user-info"">
                                <div class=""d-flex flex-column justify-content-start""><span class=""d-block font-weight-bold name"">");
#nullable restore
#line 162 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                                                                                                             Write(UserManager.FindByIdAsync(item.ApplicationUserId).Result.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 162 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                                                                                                                                                                                 Write(UserManager.FindByIdAsync(item.ApplicationUserId).Result.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"date text-black-50\">Shared publicly - ");
#nullable restore
#line 162 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                                                                                                                                                                                                                                                                                                             Write(CalculateRelativeTime(item.Created_at));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                            </div>\r\n                            <div class=\"mt-2\">\r\n                                <p class=\"comment-text\">");
#nullable restore
#line 165 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                                   Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 166 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                 if (item.ImagePath != null && item.ImagePath.ToString() != "null-path")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img class=\"card-img\"");
            BeginWriteAttribute("src", " src=\"", 6398, "\"", 6451, 1);
#nullable restore
#line 168 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
WriteAttributeValue("", 6404, Url.Content("~/CommentImages/"+item.Id+".jpg"), 6404, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"comment-image\" />\r\n");
#nullable restore
#line 169 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                        <div class=\"bg-white\">\r\n                            <div class=\"d-flex flex-row fs-12\">\r\n                                <div class=\"like cursor ml-1\"><span>\r\n");
#nullable restore
#line 175 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                     if ((item.CoordinatesLong != null && item.CoordinatesLat != null)

#line default
#line hidden
#nullable disable
#nullable restore
#line 177 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                                                                                                                           )
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\'", 7250, "\'", 7356, 1);
#nullable restore
#line 179 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
WriteAttributeValue("", 7257, string.Format("https://www.google.com/maps/?q={0},{1}", item.CoordinatesLat, item.CoordinatesLong), 7257, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">I was there</a>\r\n");
#nullable restore
#line 180 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </span></div>\r\n                                <div class=\"like cursor ml-1\"><span>\r\n");
#nullable restore
#line 183 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                     if (item.ApplicationUserId.ToString() == UserManager.GetUserAsync(User).Result.Id || UserManager.GetUserAsync(User).Result.Id == Model.ApplicationUserId.ToString())
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee492a7555151ea701712259d4d42c37169c38a32078", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eee492a7555151ea701712259d4d42c37169c38a32381", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#nullable restore
#line 186 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 186 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            <input type=\"submit\" value=\"Delete\" class=\"btn btn-outline-danger\" />\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 189 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </span></div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 197 "C:\Users\Subaru\source\repos\Where_is_my_Fluffymoon\Where_is_my_Fluffymoon\Views\Pets\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Where_is_my_Fluffymoon.Models.Pet> Html { get; private set; }
    }
}
#pragma warning restore 1591
