#pragma checksum "D:\SteppenWolf\ASP.NET\SBlog-master\Views\Blog\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "430b41cb81ab721329bbbcd5520eaa13efd3243d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Post), @"mvc.1.0.view", @"/Views/Blog/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Post.cshtml", typeof(AspNetCore.Views_Blog_Post))]
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
#line 1 "D:\SteppenWolf\ASP.NET\SBlog-master\Views\_ViewImports.cshtml"
using MVC_Intro;

#line default
#line hidden
#line 2 "D:\SteppenWolf\ASP.NET\SBlog-master\Views\_ViewImports.cshtml"
using MVC_Intro.Models;

#line default
#line hidden
#line 3 "D:\SteppenWolf\ASP.NET\SBlog-master\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\SteppenWolf\ASP.NET\SBlog-master\Views\_ViewImports.cshtml"
using MVC_Intro.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"430b41cb81ab721329bbbcd5520eaa13efd3243d", @"/Views/Blog/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ffad4740a89dc1f62f8c885c42a1c2a85a9e1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 118, true);
            WriteLiteral("<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col\">\n            <h2>Post</h2>\n                <h3>");
            EndContext();
            BeginContext(119, 11, false);
#line 5 "D:\SteppenWolf\ASP.NET\SBlog-master\Views\Blog\Post.cshtml"
               Write(Model.title);

#line default
#line hidden
            EndContext();
            BeginContext(130, 22, true);
            WriteLiteral("</h3>\n                ");
            EndContext();
            BeginContext(152, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "430b41cb81ab721329bbbcd5520eaa13efd3243d3859", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 162, "~/img/", 162, 6, true);
#line 6 "D:\SteppenWolf\ASP.NET\SBlog-master\Views\Blog\Post.cshtml"
AddHtmlAttributeValue("", 168, Model.img, 168, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\SteppenWolf\ASP.NET\SBlog-master\Views\Blog\Post.cshtml"
AddHtmlAttributeValue("", 185, Model.title, 185, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(201, 20, true);
            WriteLiteral("\n                <p>");
            EndContext();
            BeginContext(222, 14, false);
#line 7 "D:\SteppenWolf\ASP.NET\SBlog-master\Views\Blog\Post.cshtml"
              Write(Model.fullPost);

#line default
#line hidden
            EndContext();
            BeginContext(236, 24, true);
            WriteLiteral("</p>\n                <p>");
            EndContext();
            BeginContext(261, 12, false);
#line 8 "D:\SteppenWolf\ASP.NET\SBlog-master\Views\Blog\Post.cshtml"
              Write(Model.author);

#line default
#line hidden
            EndContext();
            BeginContext(273, 40, true);
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
