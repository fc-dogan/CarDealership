#pragma checksum "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Cars/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ed838b2abf13766387aa6178f96a7d4886318ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/Index.cshtml", typeof(AspNetCore.Views_Cars_Index))]
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
#line 1 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Cars/Index.cshtml"
using Dealership.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ed838b2abf13766387aa6178f96a7d4886318ca", @"/Views/Cars/Index.cshtml")]
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 25, true);
            WriteLiteral("\n<h1> Car List <h1>\n<ul>\n");
            EndContext();
#line 5 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Cars/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(76, 41, true);
            WriteLiteral("  <p> There are no cars in the list </p>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Cars/Index.cshtml"
}

#line default
#line hidden
            BeginContext(119, 11, true);
            WriteLiteral("</ul>\n<ul>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Cars/Index.cshtml"
   foreach (Car car in Model)
  {

#line default
#line hidden
            BeginContext(164, 15, true);
            WriteLiteral("    <li>Model: ");
            EndContext();
            BeginContext(180, 13, false);
#line 13 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Cars/Index.cshtml"
          Write(car.MakeModel);

#line default
#line hidden
            EndContext();
            BeginContext(193, 22, true);
            WriteLiteral("</li>\n    <li>Price:  ");
            EndContext();
            BeginContext(216, 9, false);
#line 14 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Cars/Index.cshtml"
           Write(car.Price);

#line default
#line hidden
            EndContext();
            BeginContext(225, 21, true);
            WriteLiteral("</li>\n    <li>Miles: ");
            EndContext();
            BeginContext(247, 9, false);
#line 15 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Cars/Index.cshtml"
          Write(car.Miles);

#line default
#line hidden
            EndContext();
            BeginContext(256, 20, true);
            WriteLiteral("</li>\n    <li>Info: ");
            EndContext();
            BeginContext(277, 8, false);
#line 16 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Cars/Index.cshtml"
         Write(car.Info);

#line default
#line hidden
            EndContext();
            BeginContext(285, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Cars/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(295, 5, true);
            WriteLiteral("</ul>");
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
