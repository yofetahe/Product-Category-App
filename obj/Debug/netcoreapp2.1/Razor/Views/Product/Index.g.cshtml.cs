#pragma checksum "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f1ff4f2b96c3422310993d2b09ce6db3b47fa18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f1ff4f2b96c3422310993d2b09ce6db3b47fa18", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e4049e3a00fb4c88848ea7768fe53642a68374b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_createProduct.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(19, 119, true);
            WriteLiteral("<div class=\"header\">\r\n    Products | <a href=\"GetCategoriesList\">Categories</a>\r\n</div>\r\n\r\n<div class=\"form-div\">\r\n    ");
            EndContext();
            BeginContext(138, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f6efa72e3f4847c4aacc94de8f57414c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 7 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.ProductModel;

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
            BeginContext(205, 107, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"item-list\">\r\n    <div class=\"block-title\">\r\n        Existing Products\r\n    </div>\r\n");
            EndContext();
#line 14 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\Index.cshtml"
     foreach(var product in Model.Products)
    {

#line default
#line hidden
            BeginContext(364, 48, true);
            WriteLiteral("        <div class=\"list-group\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 412, "\"", 454, 2);
            WriteAttributeValue("", 419, "GetProductDetail/", 419, 17, true);
#line 17 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\Index.cshtml"
WriteAttributeValue("", 436, product.ProductId, 436, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(455, 66, true);
            WriteLiteral(" class=\"list-group-item list-group-item-action\">\r\n                ");
            EndContext();
            BeginContext(522, 12, false);
#line 18 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\Index.cshtml"
           Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(534, 36, true);
            WriteLiteral("\r\n            </a>\r\n        </div>\r\n");
            EndContext();
#line 21 "C:\Users\yofet\Desktop\Practice-Projects\Coding Dojo Info\4. DotNet Stack\3. ORMs\ProductsCategories\Views\Product\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(577, 6, true);
            WriteLiteral("</div>");
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
