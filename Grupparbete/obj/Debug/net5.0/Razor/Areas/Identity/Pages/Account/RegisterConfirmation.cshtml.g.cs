#pragma checksum "C:\Workspace\ECUtbildning\C#\Grupparbete\Grupparbete\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56d45dd22176a54d2b59beda937084f8e695d4f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Workspace\ECUtbildning\C#\Grupparbete\Grupparbete\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\ECUtbildning\C#\Grupparbete\Grupparbete\Areas\Identity\Pages\_ViewImports.cshtml"
using Grupparbete.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Workspace\ECUtbildning\C#\Grupparbete\Grupparbete\Areas\Identity\Pages\_ViewImports.cshtml"
using Grupparbete.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Workspace\ECUtbildning\C#\Grupparbete\Grupparbete\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Grupparbete.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56d45dd22176a54d2b59beda937084f8e695d4f7", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18aa1d993e1c91cef71a00e52fdd326302ed5acc", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a01cfff0fcd30806840c553051cd4ccdb5fcd93", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Workspace\ECUtbildning\C#\Grupparbete\Grupparbete\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"font-family: \'Alatsi\', sans-serif; text-transform: uppercase; font-weight: bold; color: white; text-shadow: 0px 0px 12px #000;\">");
#nullable restore
#line 7 "C:\Workspace\ECUtbildning\C#\Grupparbete\Grupparbete\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                                                                                                                                      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "C:\Workspace\ECUtbildning\C#\Grupparbete\Grupparbete\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p style=""font-family: 'Alatsi', sans-serif; text-transform: uppercase; font-weight: bold; color: white; text-shadow: 0px 0px 12px #000;"">
    This app does not currently have a real email sender registered, see <a style=""color: wheat; text-decoration: underline;"" href=""https://aka.ms/aspaccountconf"">these docs</a> for how to configure a real email sender.
    Normally this would be emailed: <a style=""color: wheat; text-decoration: underline;"" id=""confirm-link""");
            BeginWriteAttribute("href", " href=\"", 785, "\"", 819, 1);
#nullable restore
#line 13 "C:\Workspace\ECUtbildning\C#\Grupparbete\Grupparbete\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 792, Model.EmailConfirmationUrl, 792, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here to confirm your account</a>\r\n</p>\r\n");
#nullable restore
#line 15 "C:\Workspace\ECUtbildning\C#\Grupparbete\Grupparbete\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p style=\"font-family: \'Alatsi\', sans-serif; text-transform: uppercase; font-weight: bold; color: white; text-shadow: 0px 0px 12px #000;\">\r\n        Please check your email to confirm your account.\r\n</p>\r\n");
#nullable restore
#line 21 "C:\Workspace\ECUtbildning\C#\Grupparbete\Grupparbete\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591