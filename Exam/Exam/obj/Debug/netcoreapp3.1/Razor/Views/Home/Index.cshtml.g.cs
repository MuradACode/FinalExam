#pragma checksum "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c9f7f2f24ccf065cb99564fa49e37cb3d8278f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\Exam\Exam\Views\_ViewImports.cshtml"
using Exam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\Exam\Exam\Views\_ViewImports.cshtml"
using DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\Exam\Exam\Views\_ViewImports.cshtml"
using Exam.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c9f7f2f24ccf065cb99564fa49e37cb3d8278f0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12ad9abbd6583c86dc35fc4345d4c86118b73b8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
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
            WriteLiteral("\r\n<section class=\"container-fluid heroSection\">\r\n");
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
     foreach(Hero hero in Model.Hero)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"textDiv\">\r\n                <h2 class=\"textTitle\">");
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                                 Write(hero.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <h4 class=\"textSubtitle\">");
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                                    Write(hero.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h5>");
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
               Write(hero.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n");
#nullable restore
#line 11 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""buttonDiv"">
                <button type=""button"" class=""btn"">DOWNLOAD THIS TEMPLATE NOW !</button>
            </div>
        </section>
        <section class=""container featureSection"">
            <h2>OUR SERVICES :</h2>
            <div class=""row serviceDiv"">
                <div class=""col-lg-5 col-md-12 serviceCard"">
                    <h5 class=""serviceTitle"">Lorem ipsum dolor sit amet</h5>
                    <p class=""serviceDesc"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl
                        odio. Mauris vehicula
                        at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl
                        odio. Mauris vehicula at nunc id posuere.</p>
                </div>
                <div class=""col-lg-5 col-md-12 "">
                    <h5 class=""serviceTitle"">Lorem ipsum dolor sit amet</h5>
                    <p class=""serviceDesc"">Lorem ipsum dolor sit amet, cons");
            WriteLiteral(@"ectetur adipiscing elit. Curabitur nec nisl
                        odio. Mauris vehicula
                        at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl
                        odio. Mauris vehicula at nunc id posuere.</p>
                </div>
            </div>
            <div class=""row cardDiv"">

");
#nullable restore
#line 36 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                for (var i = 0; i < Model.Features.Count; i++)
               {
                   
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                 if (i == 2)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   <div class=""col-lg-4 col-md-12 featureCard mb-3"">
                    <i class=""fa-solid fa-display""></i>
                    <h3>Sure Quique Menu</h3>
                    <p class=""py-3"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio.
                        Mauris vehicula
                        at nunc id posuere.</p>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                </div>
");
#nullable restore
#line 49 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-12 featureCard me-5 mb-3\">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 2503, "\"", 2534, 1);
#nullable restore
#line 53 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
WriteAttributeValue("", 2511, Model.Features[1].Icon, 2511, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                    <h3>");
#nullable restore
#line 54 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                   Write(Model.Features[1].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"py-3\">");
#nullable restore
#line 55 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                               Write(Model.Features[1].Desc1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 56 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                  Write(Model.Features[1].Desc2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 58 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""pt-5"">
                <h3 class=""pb-3 fw-normal"">Lorem ipsum dolor sit amet</h3>
                <p class=""description"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio.
                    Mauris vehicula at
                    nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio.
                    Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                    Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur
                    adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit
                    amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at
                ");
            WriteLiteral("    nunc id posuere.</p>\r\n            </div>\r\n        </section>\r\n        <section class=\"achivementsTop container-fluid\">\r\n            <div class=\"container achivementsDiv\">\r\n                <div class=\"row\">\r\n                    \r\n");
#nullable restore
#line 79 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                     foreach (AchivementTop achivement in Model.TopAchivements)
                   {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                        if (achivement.IsSmall)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <div class=\"col-lg-3 col-md-12 achivementNumbers\">\r\n                        <h2>");
#nullable restore
#line 84 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                       Write(achivement.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h5>");
#nullable restore
#line 85 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                       Write(achivement.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\n");
#nullable restore
#line 87 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-lg-9 col-md-12 achivementText\">\r\n                        <h2>");
#nullable restore
#line 91 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                       Write(achivement.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h5>");
#nullable restore
#line 92 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                       Write(achivement.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n");
#nullable restore
#line 94 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </section>\r\n        <section class=\"achivementsBottom container-fluid\">\r\n            <div class=\"container achivementsDiv\">\r\n                <div class=\"row\">\r\n\r\n");
#nullable restore
#line 104 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                     foreach (AchivementBottom achivementBottom in Model.BottomAchivements)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <div class=\"col-lg-3 col-md-12 achivementText\">\r\n                        <h2>");
#nullable restore
#line 107 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                       Write(achivementBottom.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h5>");
#nullable restore
#line 108 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                       Write(achivementBottom.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\n");
#nullable restore
#line 110 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </section>\r\n        <section class=\"container contactSection\">\r\n            <h2>CONTACT US :</h2>\r\n            <div class=\"row mt-5\">\r\n\r\n");
#nullable restore
#line 119 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                 foreach (Contact contact in Model.Contacts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-5 col-md-12 contactCard\">\r\n                    <h5 class=\"contactTitle\">");
#nullable restore
#line 122 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                                        Write(contact.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"contactDesc\">");
#nullable restore
#line 123 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                                      Write(contact.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\n");
#nullable restore
#line 125 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row mt-3\">\r\n                <div class=\"col-lg-6 col-md-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c9f7f2f24ccf065cb99564fa49e37cb3d8278f015875", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <input class=""col-4 me-5"" type=""text"" placeholder=""name"">
                            <input class=""col-4"" type=""email"" placeholder=""Email address"">
                        </div>
                        <div class=""row"">
                            <textarea placeholder=""Message"" class=""col-9 mt-3"" cols=""60"" rows=""3""></textarea>
                        </div>
                        <div class=""row"">
                            <button type=""submit"" class=""btn p-1 px-3 mt-3 contactSubmitButton"">Submit Request</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-lg-5 col-md-12 ms-3 mt-4\">\r\n                    \r\n");
#nullable restore
#line 145 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                     foreach (ContactAddress address in Model.ContactAddresses)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"contactAdress\">\r\n                        <span class=\"fw-bold\">");
#nullable restore
#line 148 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                                         Write(address.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </span>\r\n                        <span>");
#nullable restore
#line 149 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                         Write(address.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\n");
#nullable restore
#line 151 "C:\Users\Administrator\source\repos\Exam\Exam\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
