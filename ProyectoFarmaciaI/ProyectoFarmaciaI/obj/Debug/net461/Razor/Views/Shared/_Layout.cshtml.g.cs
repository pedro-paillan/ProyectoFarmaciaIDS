#pragma checksum "C:\Users\ERPyme\ProyectoFarmaciaI\ProyectoFarmaciaI\ProyectoFarmaciaI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "017379b35cdafe0bfcccb0162db34695ffe46520"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\ERPyme\ProyectoFarmaciaI\ProyectoFarmaciaI\ProyectoFarmaciaI\Views\_ViewImports.cshtml"
using ProyectoFarmaciaI;

#line default
#line hidden
#line 2 "C:\Users\ERPyme\ProyectoFarmaciaI\ProyectoFarmaciaI\ProyectoFarmaciaI\Views\_ViewImports.cshtml"
using ProyectoFarmaciaI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"017379b35cdafe0bfcccb0162db34695ffe46520", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7716f7d49d61f0c86e3b0c63f36cca8a0a9c65dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 1351, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32e75ddf03b34ae49f410191912f8e89", async() => {
                BeginContext(31, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(153, 17, false);
#line 6 "C:\Users\ERPyme\ProyectoFarmaciaI\ProyectoFarmaciaI\ProyectoFarmaciaI\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(170, 35, true);
                WriteLiteral(" - ProyectoFarmacia</title>\r\n\r\n    ");
                EndContext();
                BeginContext(205, 690, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03848fb91ead41b6923cead2a6dec068", async() => {
                    BeginContext(240, 166, true);
                    WriteLiteral("\r\n        <!-- <link rel=\"stylesheet\" href=\"~/lib/bootstrap/dist/css/bootstrap.css\" /> -->\r\n        <!-- <link rel=\"stylesheet\" href=\"~/css/site.css\" /> -->\r\n        ");
                    EndContext();
                    BeginContext(406, 68, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d40b8c99dd94ad3b000219eed6ead00", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(474, 407, true);
                    WriteLiteral(@"
          <link rel=""stylesheet"" href=""css/animate.css"" type=""text/css"" />
          <link rel=""stylesheet"" href=""css/font-awesome.min.css"" type=""text/css"" />
          <link rel=""stylesheet"" href=""css/font.css"" type=""text/css"" />
          <link rel=""stylesheet"" href=""js/calendar/bootstrap_calendar.css"" type=""text/css"" />
          <link rel=""stylesheet"" href=""css/app.css"" type=""text/css"" />
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(895, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(901, 466, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9503298903ab4e20ae9fd550588a01e6", async() => {
                    BeginContext(936, 417, true);
                    WriteLiteral(@"
        <!-- <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css""
              asp-fallback-href=""~/lib/bootstrap/dist/css/bootstrap.min.css""
              asp-fallback-test-class=""sr-only"" asp-fallback-test-property=""position"" asp-fallback-test-value=""absolute"" />
        <link rel=""stylesheet"" href=""~/css/site.min.css"" asp-append-version=""true"" /> -->
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1367, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1376, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1378, 14193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af19afbcd78d4ad7b7ef0dd2226f4c60", async() => {
                BeginContext(1384, 11643, true);
                WriteLiteral(@"
<section class=""vbox"" >
    <header class=""bg-dark dk header navbar navbar-fixed-top-xs"">
      <div class=""navbar-header aside-md"">
        <a class=""btn btn-link visible-xs"" data-toggle=""class:nav-off-screen,open"" data-target=""#nav,html"">
          <i class=""fa fa-bars""></i>
        </a>
        <a href=""#"" class=""navbar-brand"" data-toggle=""fullscreen""><img src=""images/logo.png"" class=""m-r-sm"">Mapa Farmacia</a>
        <a class=""btn btn-link visible-xs"" data-toggle=""dropdown"" data-target="".nav-user"">
          <i class=""fa fa-cog""></i>
        </a>
      </div>
   
      <ul class=""nav navbar-nav navbar-right m-n hidden-xs nav-user"">
        <li class=""dropdown"">
          <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
            <span class=""thumb-sm avatar pull-left"">
              <img src=""images/avatar.jpg"">
            </span>
            John.Smith <b class=""caret""></b>
          </a>
          <ul class=""dropdown-menu animated fadeInRight"">
            <span clas");
                WriteLiteral(@"s=""arrow top""></span>
            <li>
              <a href=""#"">Settings</a>
            </li>
            <li>
              <a href=""profile.html"">Profile</a>
            </li>
            <li>
              <a href=""#"">
                <span class=""badge bg-danger pull-right"">3</span>
                Notifications
              </a>
            </li>
            <li>
              <a href=""docs.html"">Help</a>
            </li>
            <li class=""divider""></li>
            <li>
              <a href=""modal.lockme.html"" data-toggle=""ajaxModal"" >Logout</a>
            </li>
          </ul>
        </li>
      </ul>      
    </header>


    <section>
      <section class=""hbox stretch"">
        <!-- .aside -->
        <aside class=""bg-dark lter aside-md hidden-print hidden-xs"" id=""nav"">          
          <section class=""vbox"">
            <header class=""header bg-primary lter text-center clearfix"">
              <div class=""btn-group"">
                <button type=""butt");
                WriteLiteral(@"on"" class=""btn btn-sm btn-dark btn-icon"" title=""New project""><i class=""fa fa-plus""></i></button>
                <div class=""btn-group hidden-nav-xs"">
                  <button type=""button"" class=""btn btn-sm btn-primary dropdown-toggle"" data-toggle=""dropdown"">
                    Switch Project
                    <span class=""caret""></span>
                  </button>
                  <ul class=""dropdown-menu text-left"">
                    <li><a href=""#"">Project</a></li>
                    <li><a href=""#"">Another Project</a></li>
                    <li><a href=""#"">More Projects</a></li>
                  </ul>
                </div>
              </div>
            </header>
            <section class=""w-f scrollable"">
              <div class=""slim-scroll"" data-height=""auto"" data-disable-fade-out=""true"" data-distance=""0"" data-size=""5px"" data-color=""#333333"">
                
                <!-- nav -->
                <nav class=""nav-primary hidden-xs"">
                  <ul class=");
                WriteLiteral(@"""nav"">
                    <li  class=""active"">
                      <a href=""index.html""   class=""active"">
                        <i class=""fa fa-dashboard icon"">
                          <b class=""bg-danger""></b>
                        </i>
                        <span class=""pull-right"">
                          <i class=""fa fa-angle-down text""></i>
                          <i class=""fa fa-angle-up text-active""></i>
                        </span>
                        <span>Mapa</span>
                      </a>
                      <ul class=""nav lt"">
                        <li  class=""active"">
                          <a href=""index.html""  class=""active"">                                                        
                            <i class=""fa fa-angle-right""></i>
                            <span>Dashboard v1</span>
                          </a>
                        </li>
                        <li >
                          <a href=""dashboard.html"" >       ");
                WriteLiteral(@"                                                 
                            <i class=""fa fa-angle-right""></i>
                            <span>Dashboard v2</span>
                          </a>
                        </li>
                      </ul>
                    </li>
                    <li >
                      <a href=""#layout""  >
                        <i class=""fa fa-columns icon"">
                          <b class=""bg-warning""></b>
                        </i>
                        <span class=""pull-right"">
                          <i class=""fa fa-angle-down text""></i>
                          <i class=""fa fa-angle-up text-active""></i>
                        </span>
                        <span>Farmacias</span>
                      </a>
                      <ul class=""nav lt"">
                        <li >
                          <a href=""layout-c.html"" >                                                        
                            <i class=""fa fa-ang");
                WriteLiteral(@"le-right""></i>
                            <span>Color option</span>
                          </a>
                        </li>
                        <li >
                          <a href=""layout-r.html"" >                                                        
                            <i class=""fa fa-angle-right""></i>
                            <span>Right nav</span>
                          </a>
                        </li>
                        <li >
                          <a href=""layout-h.html"" >                                                        
                            <i class=""fa fa-angle-right""></i>
                            <span>Hbox Layout</span>
                          </a>
                        </li>
                        <li >
                          <a href=""layout-boxed.html"" >                                                        
                            <i class=""fa fa-angle-right""></i>
                            <span>Boxed Layou");
                WriteLiteral(@"t</span>
                          </a>
                        </li>
                        <li >
                          <a href=""layout-fluid.html"" >                                                        
                            <i class=""fa fa-angle-right""></i>
                            <span>Fluid Layout</span>
                          </a>
                        </li>
                      </ul>
                    </li>
                    <li >
                      <a href=""#layout""  >
                        <i class=""fa fa-columns icon"">
                          <b class=""bg-warning""></b>
                        </i>
                        <span class=""pull-right"">
                          <i class=""fa fa-angle-down text""></i>
                          <i class=""fa fa-angle-up text-active""></i>
                        </span>
                        <span>Perfil</span>
                      </a>
                      <ul class=""nav lt"">
                        ");
                WriteLiteral(@"<li >
                          <a href=""layout-c.html"" >                                                        
                            <i class=""fa fa-angle-right""></i>
                            <span>Color option</span>
                          </a>
                        </li>
                        <li >
                          <a href=""layout-r.html"" >                                                        
                            <i class=""fa fa-angle-right""></i>
                            <span>Right nav</span>
                          </a>
                        </li>
                        <li >
                          <a href=""layout-h.html"" >                                                        
                            <i class=""fa fa-angle-right""></i>
                            <span>Hbox Layout</span>
                          </a>
                        </li>
                        <li >
                          <a href=""layout-boxed.html"" >   ");
                WriteLiteral(@"                                                     
                            <i class=""fa fa-angle-right""></i>
                            <span>Boxed Layout</span>
                          </a>
                        </li>
                        <li >
                          <a href=""layout-fluid.html"" >                                                        
                            <i class=""fa fa-angle-right""></i>
                            <span>Fluid Layout</span>
                          </a>
                        </li>
                      </ul>
                    </li>
                    
                  </ul>
                </nav>
                <!-- / nav -->
              </div>
            </section>
            
            <footer class=""footer lt hidden-xs b-t b-dark"">
              <div id=""chat"" class=""dropup"">
                <section class=""dropdown-menu on aside-md m-l-n"">
                  <section class=""panel bg-white"">
                  ");
                WriteLiteral(@"  <header class=""panel-heading b-b b-light"">Active chats</header>
                    <div class=""panel-body animated fadeInRight"">
                      <p class=""text-sm"">No active chats.</p>
                      <p><a href=""#"" class=""btn btn-sm btn-default"">Start a chat</a></p>
                    </div>
                  </section>
                </section>
              </div>
              <div id=""invite"" class=""dropup"">                
                <section class=""dropdown-menu on aside-md m-l-n"">
                  <section class=""panel bg-white"">
                    <header class=""panel-heading b-b b-light"">
                      John <i class=""fa fa-circle text-success""></i>
                    </header>
                    <div class=""panel-body animated fadeInRight"">
                      <p class=""text-sm"">No contacts in your lists.</p>
                      <p><a href=""#"" class=""btn btn-sm btn-facebook""><i class=""fa fa-fw fa-facebook""></i> Invite from Facebook</a></p>
     ");
                WriteLiteral(@"               </div>
                  </section>
                </section>
              </div>
              <a href=""#nav"" data-toggle=""class:nav-xs"" class=""pull-right btn btn-sm btn-dark btn-icon"">
                <i class=""fa fa-angle-left text""></i>
                <i class=""fa fa-angle-right text-active""></i>
              </a>
              <div class=""btn-group hidden-nav-xs"">
                <button type=""button"" title=""Chats"" class=""btn btn-icon btn-sm btn-dark"" data-toggle=""dropdown"" data-target=""#chat""><i class=""fa fa-comment-o""></i></button>
                <button type=""button"" title=""Contacts"" class=""btn btn-icon btn-sm btn-dark"" data-toggle=""dropdown"" data-target=""#invite""><i class=""fa fa-facebook""></i></button>
              </div>
            </footer>
          </section>
        </aside>
        <!-- /.aside -->


        <section id=""content"">
          <section class=""vbox"">          
            <section class=""scrollable padder"">
              <ul class=""breadcr");
                WriteLiteral(@"umb no-border no-radius b-b b-light pull-in"">
                <li><a href=""index.html""><i class=""fa fa-home""></i> Home</a></li>
                <li class=""active"">Workset</li>
              </ul>
              <div class=""m-b-md"">
                <h3 class=""m-b-none"">Workset</h3>
                <small>Welcome back, Noteman</small>
              </div>

              ");
                EndContext();
                BeginContext(13028, 12, false);
#line 272 "C:\Users\ERPyme\ProyectoFarmaciaI\ProyectoFarmaciaI\ProyectoFarmaciaI\Views\Shared\_Layout.cshtml"
         Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(13040, 244, true);
                WriteLiteral("\r\n              \r\n          </section>\r\n          <a href=\"#\" class=\"hide nav-off-screen-block\" data-toggle=\"class:nav-off-screen, open\" data-target=\"#nav,html\"></a>\r\n        </section>\r\n      </section>\r\n    </section>\r\n  </section>\r\n   \r\n    ");
                EndContext();
                BeginContext(13284, 1289, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc41a1c175414950ad94be1bcaa8f4ad", async() => {
                    BeginContext(13319, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(13329, 51, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5fff8ed0d8d49459e45f6312fe1e162", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(13380, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(13390, 60, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eb1f03ff3174106996f077d0a8c198b", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(13450, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(13460, 62, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b455459bd3549118e39565ee18faf9b", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 284 "C:\Users\ERPyme\ProyectoFarmaciaI\ProyectoFarmaciaI\ProyectoFarmaciaI\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(13522, 1037, true);
                    WriteLiteral(@"
        <script src=""js/jquery.min.js""></script>
          <!-- Bootstrap -->
          <script src=""js/bootstrap.js""></script>
          <!-- App -->
          <script src=""js/app.js""></script> 
          <script src=""js/slimscroll/jquery.slimscroll.min.js""></script>
            <script src=""js/charts/easypiechart/jquery.easy-pie-chart.js""></script>
          <script src=""js/charts/sparkline/jquery.sparkline.min.js""></script>
          <script src=""js/charts/flot/jquery.flot.min.js""></script>
          <script src=""js/charts/flot/jquery.flot.tooltip.min.js""></script>
          <script src=""js/charts/flot/jquery.flot.resize.js""></script>
          <script src=""js/charts/flot/jquery.flot.grow.js""></script>
          <script src=""js/charts/flot/demo.js""></script>

          <script src=""js/calendar/bootstrap_calendar.js""></script>
          <script src=""js/calendar/demo.js""></script>

          <script src=""js/sortable/jquery.sortable.js""></script>
          <script src=""js/app.plugin.js""></");
                    WriteLiteral("script>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14573, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(14579, 933, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cff7a4211fa426fa4ae5df596693370", async() => {
                    BeginContext(14614, 884, true);
                    WriteLiteral(@"
       <!--  <script src=""https://ajax.aspnetcdn.com/ajax/jquery/jquery-3.3.1.min.js""
                asp-fallback-src=""~/lib/jquery/dist/jquery.min.js""
                asp-fallback-test=""window.jQuery""
                crossorigin=""anonymous""
                integrity=""sha384-tsQFqpEReu7ZLhBV2VZlAu7zcOV+rXbYlF2cqB8txI/8aZajjp4Bqd+V6D5IgvKT"">
        </script>
        <script src=""https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""
                asp-fallback-src=""~/lib/bootstrap/dist/js/bootstrap.min.js""
                asp-fallback-test=""window.jQuery && window.jQuery.fn && window.jQuery.fn.modal""
                crossorigin=""anonymous""
                integrity=""sha384-aJ21OjlMXNL5UyIl/XNwTMqvzeRMZH2w8c5cRVpzpU8Y5bApTppSuUkhZXN0VxHd"">
        </script>
        <script src=""~/js/site.min.js"" asp-append-version=""true""></script> -->
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(15512, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(15521, 41, false);
#line 321 "C:\Users\ERPyme\ProyectoFarmaciaI\ProyectoFarmaciaI\ProyectoFarmaciaI\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(15562, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(15571, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
