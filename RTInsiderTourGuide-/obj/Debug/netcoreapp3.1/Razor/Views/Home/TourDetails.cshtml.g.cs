#pragma checksum "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02c669f2a96c0fb8422bc8ef2996ad828a2e8a4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TourDetails), @"mvc.1.0.view", @"/Views/Home/TourDetails.cshtml")]
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
#line 1 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/_ViewImports.cshtml"
using RTInsiderTourGuide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/_ViewImports.cshtml"
using RTInsiderTourGuide.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c669f2a96c0fb8422bc8ef2996ad828a2e8a4d", @"/Views/Home/TourDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8874b0b419974924cf310dba7596ea851544849e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TourDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToPayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("booking-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""/"">Runtime Terror</a>
        <ul class=""navbar-nav"">
            <li class=""nav-item active"">
                <a class=""nav-link"" href=""/"">Home</a>
            </li>
");
#nullable restore
#line 9 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
              
              if (Context.Session.GetInt32("userId") != null)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"nav-item\">\n                        <a class=\"nav-link\" href=\"/userdashboard\">My Dashboard</a>\n                  </li>\n");
#nullable restore
#line 15 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
              }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
              
              if (Context.Session.GetInt32("userId") == 1)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"nav-item\">\n                        <a class=\"nav-link\" href=\"/admin\">Admin Dashboard</a>\n                  </li>\n");
#nullable restore
#line 23 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
              }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-item\">\n                <a class=\"nav-link\" href=\"/SearchTours\">Search For Tours</a>\n            </li>\n            <li class=\"nav-item\">\n                <a class=\"nav-link\" href=\"#\">Contact Us</a>\n            </li>\n");
#nullable restore
#line 31 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
              
              if (Context.Session.GetInt32("userId") != null)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"login\">\n                    <a class=\"nav-link\" href=\"/logout\">Logout</a>\n                  </li>\n");
#nullable restore
#line 37 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
              }
              else
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"login\">\n                  <a class=\"nav-link\" href=\"/login\">Login</a>\n                </li>\n");
#nullable restore
#line 43 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
              }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>
</nav>

<div id=""toursCarousel"" class=""carousel slide container"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
      <li data-target=""#toursCarousel"" data-slide-to=""0"" class=""active""></li>
      <li data-target=""#toursCarousel"" data-slide-to=""1""></li>
      <li data-target=""#toursCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
");
#nullable restore
#line 56 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
        
        int i = 0;
            foreach (Image img in ViewBag.selectedTour.ImagesOfTour)
            {
                if ( i == 0 )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item active\">\n                      <img");
            BeginWriteAttribute("src", " src=\"", 2137, "\"", 2151, 1);
#nullable restore
#line 63 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
WriteAttributeValue("", 2143, img.Url, 2143, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100 carousel-img\">\n");
#nullable restore
#line 64 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                        i = i+1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n");
#nullable restore
#line 66 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\n                      <img");
            BeginWriteAttribute("src", " src=\"", 2381, "\"", 2395, 1);
#nullable restore
#line 70 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
WriteAttributeValue("", 2387, img.Url, 2387, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100 carousel-img\">\n                    </div>\n");
#nullable restore
#line 72 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                }
            }
      

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <a class=""carousel-control-prev"" href=""#toursCarousel"" role=""button"" data-slide=""prev"">
      <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
      <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#toursCarousel"" role=""button"" data-slide=""next"">
      <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
      <span class=""sr-only"">Next</span>
    </a>
    </div>
</div>

<main class=""container body "">
    <div class=""tour"">
        <h3 class=""title"" >");
#nullable restore
#line 88 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                      Write(ViewBag.selectedTour.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p>Includes transportation, the mentioned meals, and a tour</p>\n        <p>Availability : ");
#nullable restore
#line 90 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                     Write(ViewBag.selectedTour.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" day/s.</p>\n    </div>\n\n    <h3><u>Details:</u></h3>\n    <div class=\"details\">\n        <div class=\"accordion\" id=\"accordionTour\">\n\n");
#nullable restore
#line 97 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
            

            int j = 1;
            foreach (Activity a in ViewBag.selectedTour.TourActivities)
            {
              if (j == 1)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <div class=\"card\">\n                  <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\"", 3570, "\"", 3586, 2);
            WriteAttributeValue("", 3575, "heading", 3575, 7, true);
#nullable restore
#line 105 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
WriteAttributeValue("", 3582, j, 3582, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <h2 class=\"mb-0\">\n                      <button class=\"btn btn-block text-left dayBtn collapsed\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collaps");
#nullable restore
#line 107 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                                                                                                                                     Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 3791, "\"", 3818, 2);
            WriteAttributeValue("", 3807, "collaps", 3807, 7, true);
#nullable restore
#line 107 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
WriteAttributeValue("", 3814, j, 3814, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <i class=\"fas fa-chevron-right orange down\"></i> Day ");
#nullable restore
#line 108 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                                                                        Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                      </button>\n                    </h2>\n                  </div>\n                  <div");
            BeginWriteAttribute("id", " id=\"", 4006, "\"", 4022, 2);
            WriteAttributeValue("", 4011, "collaps", 4011, 7, true);
#nullable restore
#line 112 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
WriteAttributeValue("", 4018, j, 4018, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse show\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 4045, "\"", 4074, 2);
            WriteAttributeValue("", 4063, "heading", 4063, 7, true);
#nullable restore
#line 112 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
WriteAttributeValue("", 4070, j, 4070, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordionTour\">\n                    <div class=\"card-body\">\n                        <h4>");
#nullable restore
#line 114 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                       Write(a.TourActivity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                        <pre>\n");
#nullable restore
#line 116 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
Write(a.TourActivityDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </pre>\n                    </div>\n                  </div>\n");
#nullable restore
#line 120 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                    j = j+1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n");
#nullable restore
#line 122 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
              }
              else
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\n                  <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\"", 4520, "\"", 4536, 2);
            WriteAttributeValue("", 4525, "heading", 4525, 7, true);
#nullable restore
#line 126 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
WriteAttributeValue("", 4532, j, 4532, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <h2 class=\"mb-0\">\n                      <button class=\"btn btn-block text-left dayBtn collapsed\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collaps");
#nullable restore
#line 128 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                                                                                                                                     Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 4741, "\"", 4768, 2);
            WriteAttributeValue("", 4757, "collaps", 4757, 7, true);
#nullable restore
#line 128 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
WriteAttributeValue("", 4764, j, 4764, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <i class=\"fas fa-chevron-right orange\"></i> Day ");
#nullable restore
#line 129 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                                                                   Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                      </button>\n                    </h2>\n                  </div>\n                  <div");
            BeginWriteAttribute("id", " id=\"", 4951, "\"", 4967, 2);
            WriteAttributeValue("", 4956, "collaps", 4956, 7, true);
#nullable restore
#line 133 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
WriteAttributeValue("", 4963, j, 4963, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 4985, "\"", 5014, 2);
            WriteAttributeValue("", 5003, "heading", 5003, 7, true);
#nullable restore
#line 133 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
WriteAttributeValue("", 5010, j, 5010, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordionTour\">\n                    <div class=\"card-body\">\n                        <h4>");
#nullable restore
#line 135 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                       Write(a.TourActivity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                        <pre>\n");
#nullable restore
#line 137 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
Write(a.TourActivityDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </pre>\n                    </div>\n                  </div>\n");
#nullable restore
#line 141 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                    j = j+1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n");
#nullable restore
#line 143 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
              }
            }
          

#line default
#line hidden
#nullable disable
            WriteLiteral("\n          </div>\n");
#nullable restore
#line 148 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
            
            if (ViewBag.IsBooked == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"book\">\n                <div class=\"book-card\">\n                    <div class=\"book-header\">\n                        <p class=\"book-price\">$");
#nullable restore
#line 154 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                                          Write(ViewBag.selectedTour.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <p class=""info"">* The Price is for one Adult, Childern will be half the Price.</p>
                    </div>
                    <div class=""book-body"">
                        <p class=""date""><i class=""far fa-calendar-alt""></i>");
#nullable restore
#line 158 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                                                                      Write(ViewBag.selectedTour.Date.Date.ToString("MMM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02c669f2a96c0fb8422bc8ef2996ad828a2e8a4d21243", async() => {
                WriteLiteral("\n                          <div class=\"form-input\">\n                              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02c669f2a96c0fb8422bc8ef2996ad828a2e8a4d21582", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 161 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NumberOfAdults);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<br>\n                              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02c669f2a96c0fb8422bc8ef2996ad828a2e8a4d23158", async() => {
                    WriteLiteral("<i class=\"fas fa-user\"></i> Number of Adults");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 162 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NumberOfAdults);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02c669f2a96c0fb8422bc8ef2996ad828a2e8a4d24744", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 163 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NumberOfAdults);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                          </div>\n                          <div class=\"form-input\">\n                              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02c669f2a96c0fb8422bc8ef2996ad828a2e8a4d26415", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 166 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NumberOfChildern);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<br>\n                              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02c669f2a96c0fb8422bc8ef2996ad828a2e8a4d27993", async() => {
                    WriteLiteral("<i class=\"fas fa-child\"></i>Number of Childern");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 167 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NumberOfChildern);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02c669f2a96c0fb8422bc8ef2996ad828a2e8a4d29583", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 168 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NumberOfChildern);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                          </div>\n                          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02c669f2a96c0fb8422bc8ef2996ad828a2e8a4d31198", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 170 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TourId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 170 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
                                             WriteLiteral(ViewBag.selectedTour.TourId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                          <button class=\"proceedBtn mt-4\"><i class=\"fas fa-check-circle\"></i>Proceed Booking</button>\n                      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 176 "/Users/zaid/Desktop/RTInsiderTourGuide-Zaid/Views/Home/TourDetails.cshtml"
            }
          

#line default
#line hidden
#nullable disable
            WriteLiteral("            \n    </div>\n    \n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
