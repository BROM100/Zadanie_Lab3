#pragma checksum "C:\Users\barte\source\repos\Zadanie\Zadanie\Views\Form\Answer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9c8af9f6989e7d89a8aef4ce24c03b6e421cc56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_Answer), @"mvc.1.0.view", @"/Views/Form/Answer.cshtml")]
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
#line 1 "C:\Users\barte\source\repos\Zadanie\Zadanie\Views\_ViewImports.cshtml"
using Zadanie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\barte\source\repos\Zadanie\Zadanie\Views\_ViewImports.cshtml"
using Zadanie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c8af9f6989e7d89a8aef4ce24c03b6e421cc56", @"/Views/Form/Answer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f625bf271d7309ec371c0a78623e6ebbb4147471", @"/Views/_ViewImports.cshtml")]
    public class Views_Form_Answer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Zadanie.Models.FormModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\barte\source\repos\Zadanie\Zadanie\Views\Form\Answer.cshtml"
  
    ViewData["Title"] = "Form";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-left\">\r\n    <h1 class=\"display-4\">Wynik formularza</h1>\r\n    ");
#nullable restore
#line 8 "C:\Users\barte\source\repos\Zadanie\Zadanie\Views\Form\Answer.cshtml"
Write(Html.DisplayNameFor(model => model.imie));

#line default
#line hidden
#nullable disable
            WriteLiteral(":          ");
#nullable restore
#line 8 "C:\Users\barte\source\repos\Zadanie\Zadanie\Views\Form\Answer.cshtml"
                                                   Write(Html.DisplayFor(model => model.imie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n   \r\n    <p> ilo????_powtorze?? ");
#nullable restore
#line 11 "C:\Users\barte\source\repos\Zadanie\Zadanie\Views\Form\Answer.cshtml"
                   Write(Html.DisplayFor(model => model.belongs));

#line default
#line hidden
#nullable disable
            WriteLiteral(" do przedzia??u 1..5 </p>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\barte\source\repos\Zadanie\Zadanie\Views\Form\Answer.cshtml"
     for (int i = 0; i <= Model.ilosc_powtorzen; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 15 "C:\Users\barte\source\repos\Zadanie\Zadanie\Views\Form\Answer.cshtml"
      Write(Model.imie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\barte\source\repos\Zadanie\Zadanie\Views\Form\Answer.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zadanie.Models.FormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
