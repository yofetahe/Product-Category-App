#pragma checksum "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbcae114ac860f5a8110369bb1fa076caced5c7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductDetail), @"mvc.1.0.view", @"/Views/Product/ProductDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductDetail.cshtml", typeof(AspNetCore.Views_Product_ProductDetail))]
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
#line 1 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\_ViewImports.cshtml"
using ProductsCategories;

#line default
#line hidden
#line 2 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\_ViewImports.cshtml"
using ProductsCategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbcae114ac860f5a8110369bb1fa076caced5c7e", @"/Views/Product/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e4049e3a00fb4c88848ea7768fe53642a68374b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_addCategory.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 28, true);
            WriteLiteral("\r\n<div class=\"header\">\r\n    ");
            EndContext();
            BeginContext(48, 23, false);
#line 4 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\ProductDetail.cshtml"
Write(Model.ProductModel.Name);

#line default
#line hidden
            EndContext();
            BeginContext(71, 100, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"item-list\">\r\n    <div class=\"block-title\">\r\n        Categories\r\n    </div>\r\n");
            EndContext();
#line 11 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\ProductDetail.cshtml"
     foreach(var ProdRel in @Model.ProductModel.ProdRel)
    {

#line default
#line hidden
            BeginContext(236, 25, true);
            WriteLiteral("        <p>\r\n            ");
            EndContext();
            BeginContext(262, 23, false);
#line 14 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\ProductDetail.cshtml"
       Write(ProdRel.Categories.name);

#line default
#line hidden
            EndContext();
            BeginContext(285, 16, true);
            WriteLiteral("\r\n        </p>\r\n");
            EndContext();
#line 16 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\ProductDetail.cshtml"
    }

#line default
#line hidden
            BeginContext(308, 41, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"form-div\">   \r\n    ");
            EndContext();
            BeginContext(349, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af4f4c8c97474c13a1b7362a977426e4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 20 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\ProductDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(401, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
