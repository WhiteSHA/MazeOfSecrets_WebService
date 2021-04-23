#pragma checksum "C:\Users\Arpine\Desktop\Arsen_Diplomayin\MazeOfSecrets_WebService\MazeOfSecrets_WebService\Views\Home\ControlPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ae1b9ef63ec5be3987e56cdefffd822fbe3e240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ControlPanel), @"mvc.1.0.view", @"/Views/Home/ControlPanel.cshtml")]
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
#line 1 "C:\Users\Arpine\Desktop\Arsen_Diplomayin\MazeOfSecrets_WebService\MazeOfSecrets_WebService\Views\_ViewImports.cshtml"
using MazeOfSecrets_WebService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arpine\Desktop\Arsen_Diplomayin\MazeOfSecrets_WebService\MazeOfSecrets_WebService\Views\_ViewImports.cshtml"
using MazeOfSecrets_WebService.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ae1b9ef63ec5be3987e56cdefffd822fbe3e240", @"/Views/Home/ControlPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead63f70ba2a6642f10c2ad87db3e88be952b5e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ControlPanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/AddQuiz.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Arpine\Desktop\Arsen_Diplomayin\MazeOfSecrets_WebService\MazeOfSecrets_WebService\Views\Home\ControlPanel.cshtml"
  
    ViewData["Title"] = "Insert Table";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 5 "C:\Users\Arpine\Desktop\Arsen_Diplomayin\MazeOfSecrets_WebService\MazeOfSecrets_WebService\Views\Home\ControlPanel.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

    <br />

    <h4>
        The data that you entered is displayed here.<br /> This data will be received by the player when he starts the game.
    </h4>

    <br />

    <label id=""warningLabel"" style=""color:red; font-size: 16px;""></label>

    <br />

    <label for=""id"" style=""width:100px; height:30px; text-align: center;"">Question id : </label>
    <input type=""number"" name=""id"" id=""id"" min=""1"" max=""500"" style=""width:200px; height:30px; text-align: center;"" readonly=""readonly"">

    <label for=""userId"" style=""width:100px; height:30px"" ; text-align: center;>User id : </label>
    <input type=""number"" name=""userId"" id=""userId"" min=""1"" max=""500"" style=""width:200px; height:30px; text-align: center;"">

    <br />
    <br />

    <label for=""question"" style=""width:100px; height:70px; vertical-align: top;"">Question : </label>
    <textarea id=""question"" name=""question"" rows=""4"" cols=""50"" style=""width:200px; height:70px"" ;></textarea>

    <label for=""corrAnswer"" style=""width:10");
            WriteLiteral(@"0px; height:70px; vertical-align: top;"">Correct Answer : </label>
    <textarea id=""corrAnswer"" name=""corrAnswer"" rows=""4"" cols=""50"" style=""width:200px; height:70px"" ;></textarea>

    <br />
    <br />

    <label for=""wrongAns1"" style=""width:100px; height:70px; vertical-align: top;"">Wrong Answer 1 : </label>
    <textarea id=""wrongAns1"" name=""wrongAns1"" rows=""4"" cols=""50"" style=""width:200px; height:70px"" ;></textarea>

    <label for=""wrongAns2"" style=""width:100px; height:70px; vertical-align: top;"">Wrong Answer 2 : </label>
    <textarea id=""wrongAns2"" name=""wrongAns2"" rows=""4"" cols=""50"" style=""width:200px; height:70px"" ;></textarea>

    <br />
    <br />

    <button id=""submitBtn"" onclick=""PostNewQuiz()"">Submit</button>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ae1b9ef63ec5be3987e56cdefffd822fbe3e2406110", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
