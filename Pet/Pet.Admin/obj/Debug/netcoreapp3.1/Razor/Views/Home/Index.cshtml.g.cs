#pragma checksum "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13f592b9969580677b569cfea4c55943c0ca0d94"
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
#line 1 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\_ViewImports.cshtml"
using Pet.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\_ViewImports.cshtml"
using Pet.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\Home\Index.cshtml"
using Pet.Core.Dto.AppSettings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f592b9969580677b569cfea4c55943c0ca0d94", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ad429dee22a9b76a4037ca328041f72e1fa8bb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form layui-form-pane"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-layout-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "学生信息管理系统1.0";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13f592b9969580677b569cfea4c55943c0ca0d945435", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title>");
#nullable restore
#line 10 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\Home\Index.cshtml"
      Write(L["Pet.Admin"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <meta name=""renderer"" content=""webkit|ie-comp|ie-stand"">
    <meta http-equiv=""hg-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no"">
    <meta http-equiv=""Cache-Control"" content=""no-siteapp"" />
    <link rel=""stylesheet"" href=""./css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""./lib/layui/css/layui.css"" media=""all"">
    <link rel=""stylesheet"" href=""./lib/admin/admin.css"" media=""all"">
    <link rel=""stylesheet"" href=""./lib/Scrollbar/jquery.scrollbar.css"">
    <script type=""text/javascript"" src=""./lib/admin/jquery-1.9.1.min.js""></script>
    <script type=""text/javascript"" src=""./lib/Scrollbar/jquery.scrollBar.js""></script>
    <script type=""text/javascript"" src=""./lib/layui/layui.js""></script>
    <script type=""text/javascript"" src=""./lib/admin/admin.js""></script>
    <script src=""./js/Utils/Util.Prompt.js""></script>
    <script src=""./js/Utils/Util.Reponse.js""></script>
  ");
                WriteLiteral(@"  <script src=""./js/Utils/Util.Request.js""></script>
    <!-- 请求进度条插件 -->
    <script src='./lib/nprogress/nprogress.js'></script>
    <link rel='stylesheet' href='./lib/nprogress/nprogress.css' />
    <!-- 让IE8/9支持媒体查询，从而兼容栅格 -->
    <!--[if lt IE 9]>
          <script src=""https://cdn.staticfile.org/html5shiv/r29/html5.min.js""></script>
          <script src=""https://cdn.staticfile.org/respond.js/1.4.2/respond.min.js""></script>
        <![endif]-->
    <script>
        /^http(s*):\/\//.test(location.href) || alert('请先部署到 localhost 下再访问');
    </script>
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13f592b9969580677b569cfea4c55943c0ca0d948352", async() => {
                WriteLiteral(@"
    <div class=""layui-layout layui-layout-admin"">
        <!-- 顶部 -->
        <div class=""layui-header"">
            <div class=""logo"">
                <a href=""javascript:;"" onclick=""$('.layui-tab-title .home').eq(0).click();"">
                    <img src=""images/logo.png"" class=""layui-nav-img"">
                    <span class=""layui-hide-xs"">");
#nullable restore
#line 46 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\Home\Index.cshtml"
                                           Write(L["Pet.Admin"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                </a>
            </div>
            <ul class=""layui-nav left layui-hide-xs"" lay-filter=""nav-top"">
                <li meun_id=""0"" class=""layui-nav-item layui-this""><a href=""javascript:;"">UI组件</a></li>
                <li meun_id=""1"" class=""layui-nav-item""><a href=""javascript:;"">Demo</a></li>
                <li class=""layui-nav-item"">
                    <a href=""javascript:;"">新页面</a>
                    <dl class=""layui-nav-child"">
                        <!-- 二级菜单 -->
                        <dd lay-unselect>
                            <a onclick=""hg.open('最大化','http://www.baidu.com','','',true)"">
                                <i class=""fa fa-window-maximize fa-fw""></i>弹出最大化
                            </a>
                        </dd>
                        <dd lay-unselect>
                            <a onclick=""hg.open('弹出自动宽高','http://www.baidu.com')"">
                                <i class=""fa fa-window-restore fa-fw""></i>弹出自动宽高
                       ");
                WriteLiteral(@"     </a>
                        </dd>
                        <dd lay-unselect>
                            <a onclick=""hg.open('弹出指定宽高','http://www.baidu.com',500,300)"">
                                <i class=""fa fa-clone fa-fw""></i>弹出指定宽高
                            </a>
                        </dd>
                        <dd lay-unselect>
                            <a onclick=""hg.add_tab('在tab打开','member-list.html')"">
                                <i class=""fa fa-tag fa-fw""></i>在tab打开
                            </a>
                        </dd>
                        <dd lay-unselect>
                            <a onclick=""hg.add_tab('在tab打开刷新','member-del.html',true)"">
                                <i class=""fa fa-tags fa-fw""></i>在tab打开刷新
                            </a>
                        </dd>
                    </dl>
                </li>
            </ul>
            <ul class=""layui-nav left layui-hide-sm layui-hide-md layui-hide-lg"" lay-filter=""nav-top"">
   ");
                WriteLiteral("             <li class=\"layui-nav-item\">\r\n                    <a href=\"javascript:;\">菜单</a>\r\n                    <dl class=\"layui-nav-child\">\r\n                        <dd meun_id=\"0\" lay-unselect><a");
                BeginWriteAttribute("onclick", " onclick=\"", 4449, "\"", 4459, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-pencil-square fa-fw\"></i>UI组件</a></dd>\r\n                        <dd meun_id=\"1\" lay-unselect><a");
                BeginWriteAttribute("onclick", " onclick=\"", 4572, "\"", 4582, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-sign-out fa-fw""></i>Demo</a></dd>
                    </dl>
                </li>
            </ul>
            <ul class=""layui-nav right"">
                <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                    <a href=""javascript:;"" hg-event=""fullscreen"" title=""全屏"">
                        <i class=""fa fa-arrows-alt fa-lg""></i>
                    </a>
                </li>
                <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                    <a href=""javascript:;"" onclick=""cleancache()"" hg-event=""delSkinConfig"" title=""清除缓存"">
                        <i class=""fa fa-trash-o fa-lg""></i>
                    </a>
                </li>
                <li class=""layui-nav-item"">
                    <a href=""javascript:;""><span>");
#nullable restore
#line 105 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\Home\Index.cshtml"
                                            Write(ViewBag.CurrentLanuageCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span></a>\r\n                    <dl class=\"layui-nav-child\">\r\n");
#nullable restore
#line 107 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\Home\Index.cshtml"
                          
                            foreach (var item in ViewBag.Languages as List<LanguageModel>)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <dd lay-unselect><a href=\"javascript:void(0);\" hg-event=\"setLanguage\"");
                BeginWriteAttribute("hg-data", " hg-data=\"", 5734, "\"", 5754, 1);
#nullable restore
#line 110 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 5744, item.Code, 5744, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 110 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\Home\Index.cshtml"
                                                                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></dd>\r\n");
#nullable restore
#line 111 "D:\Documents\GitHub\Pet\Pet\Pet.Admin\Views\Home\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a href=""javascript:;""><img src=""./images/touxiang.jpg"" class=""layui-nav-img""><span>一如既往</span></a>
                    <dl class=""layui-nav-child"">
                        <dd lay-unselect>
                            <a onclick=""hg.add_tab('修改密码','page/changePwd.html')"">
                                <i class=""fa fa-pencil-square fa-fw""></i>修改密码
                            </a>
                        </dd>
                        <dd lay-unselect><a href=""./login.html""><i class=""fa fa-sign-out fa-fw""></i>退出</a></dd>
                    </dl>
                </li>

                <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                    <a href=""javascript:;"" hg-event=""skinConfig"">
                        <i class=""fa fa-ellipsis-v fa-lg""></i>
                    </a>
                </li>
            </ul>
        </div>

        <!-- 左侧菜单 -->
        <d");
                WriteLiteral(@"iv class=""layui-left-nav scrollBox"">
            <div id=""side-nav"">
                <!-- meun_id=0；UI组件 -->
                <ul id=""nav"" class=""layui-tab-item layui-show"">
                    <li class=""open"">
                        <a class=""border active"">
                            <i class=""fa fa-cog fa-fw""></i><cite>系统管理</cite><i class=""fa fa-angle-up fa-fw nav_right""></i>
                        </a>
                        <ul class=""sub-menu"" style=""display: block;"">
                            <li class=""sub-tab"" hg-title=""按钮"" hg-nav=""/Identity/user/index"">
                                <a><i class=""fa fa-tag fa-fw""></i><cite>按钮</cite></a>
                            </li>
                            <li>
                                <a>
                                    <i class=""fa fa-pencil-square-o fa-fw""></i><cite>账号管理</cite><i class=""fa fa-angle-down fa-fw nav_right""></i>
                                </a>
                                <ul class=""sub-menu"">
      ");
                WriteLiteral(@"                              <li class=""sub-tab"" hg-title=""用户管理"" hg-nav=""/Identity/user/index?id=1"">
                                        <a><i class=""fa fa-file-text fa-fw""></i><cite>用户管理</cite></a>
                                    </li>
                                    <li class=""sub-tab"" hg-title=""角色管理"" hg-nav=""component/form/group.html"">
                                        <a><i class=""fa fa-file-text fa-fw""></i><cite>角色管理</cite></a>
                                    </li>
                                    <li class=""sub-tab"" hg-title=""权限管理"" hg-nav=""component/form/group.html"">
                                        <a><i class=""fa fa-file-text fa-fw""></i><cite>权限管理</cite></a>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                </ul>
                <!-- meun_id=1；Demo -->
                <ul id=""nav"" class=""layui-tab-item"">
               ");
                WriteLiteral(@"     <li class=""open"">
                        <a class=""border active"">
                            <i class=""fa fa-database fa-fw""></i><cite>数据表格</cite><i class=""fa fa-angle-up fa-fw nav_right""></i>
                        </a>
                        <ul class=""sub-menu"" style=""display: block;"">
                            <li class=""sub-tab"" hg-title=""数据表格一"" hg-nav=""DataGrid.html"">
                                <a><i class=""fa fa-file-text fa-fw""></i><cite>基本数据表格一</cite></a>
                            </li>
                            <li class=""sub-tab"" hg-title=""数据表格二"" hg-nav=""DataGrid1.html"">
                                <a><i class=""fa fa-file-text fa-fw""></i><cite>基本数据表格二</cite></a>
                            </li>
                            <li class=""sub-tab"" hg-title=""数据表格三"" hg-nav=""DataGrid2.html"">
                                <a><i class=""fa fa-file-text fa-fw""></i><cite>基础数据表格三</cite></a>
                            </li>
                            <li class=""sub-tab"" ");
                WriteLiteral(@"hg-title=""数据表格四"" hg-nav=""DataGrid3.html"">
                                <a><i class=""fa fa-file-text fa-fw""></i><cite>基础数据表格四</cite></a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a>
                            <i class=""fa fa-sitemap fa-fw""></i><cite>树形组件</cite><i class=""fa fa-angle-down fa-fw nav_right""></i>
                        </a>
                        <ul class=""sub-menu"">
                            <li class=""sub-tab"" hg-title=""树形组件"" hg-nav=""Tree1.html"">
                                <a><i class=""fa fa-file-text fa-fw""></i><cite>树形组件</cite></a>
                            </li>
                            <li class=""sub-tab"" hg-title=""树形组件"" hg-nav=""Tree.html"">
                                <a><i class=""fa fa-file-text fa-fw""></i><cite>树形组件大数据</cite></a>
                            </li>
                        </ul>
                    </li>
                    <li>
          ");
                WriteLiteral(@"              <a>
                            <i class=""fa fa-tasks fa-fw""></i><cite>城市联动</cite><i class=""fa fa-angle-down fa-fw nav_right""></i>
                        </a>
                        <ul class=""sub-menu"">
                            <li class=""sub-tab"" hg-title=""三级地区联动"" hg-nav=""city.html"">
                                <a><i class=""fa fa-ticket fw""></i><cite>三级地区联动</cite></a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a>
                            <i class=""fa fa-cogs fa-fw""></i><cite>其它页面</cite><i class=""fa fa-angle-down fa-fw nav_right""></i>
                        </a>
                        <ul class=""sub-menu"">
                            <li>
                                <a href=""login.html"" target=""_blank"">
                                    <i class=""fa fa-user-circle fa-fw""></i><cite>登录页</cite>
                                </a>
                            </li>");
                WriteLiteral(@"
                            <li class=""sub-tab"" hg-title=""404页面"" hg-nav=""404.html"">
                                <a><i class=""fa fa-internet-explorer fa-fw""></i><cite>404页面</cite></a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>

        <!-- 内容 -->
        <div class=""layui-page-content"">
            <div class=""layui-tab tab"" lay-unauto lay-allowClose=""true"" lay-filter=""xbs_tab"">
                <span class=""indent-tab left"" title=""侧边伸缩""><i class=""fa fa-dedent fa-lg""></i></span>
                <div class=""indent-tab left fa fa-step-backward fa-fw""></div>
                <ul class=""layui-nav"">
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;""><i class=""fa fa-dot-circle-o fa-fw""></i> 页面操作</a>
                        <dl class=""layui-nav-child"">
                            <dd lay-unselect data-page-close=""this"">
                              ");
                WriteLiteral(@"  <a href=""javascript:;""><i class=""fa fa-refresh fa-fw""></i> 刷新当前</a>
                            </dd>
                            <dd lay-unselect data-page-close=""other"">
                                <a href=""javascript:;""><i class=""fa fa-ban fa-fw""></i> 关闭其他</a>
                            </dd>
                            <dd lay-unselect data-page-close=""all"">
                                <a href=""javascript:;""><i class=""fa fa-power-off fa-fw""></i> 关闭全部</a>
                            </dd>
                        </dl>
                    </li>
                </ul>
                <div class=""indent-tab right fa fa-step-forward fa-fw""></div>
                <ul class=""layui-tab-title"">
                    <li class=""home layui-this""><i class=""fa fa-home fa-fw""></i></li>
                </ul>

                <div class=""layui-tab-content"">
                    <div class=""layui-tab-item layui-show"">
                        <iframe src='./home.html' frameborder=""0"" scrolling=""yes");
                WriteLiteral(@""" class=""hg-iframe""></iframe>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <div class=""hg-config"" style=""display: none;"">
        <div class=""layui-fluid"">
            <div class=""layui-row"">
                <div class=""layui-col-md12"">
                    <fieldset class=""layui-elem-field layui-field-title""><legend>主题</legend></fieldset>
                    <div class=""layui-col-md12"">
                        <ul class=""skin"">
                        </ul>
                    </div>
                </div>
                <div class=""layui-col-md12"">
                    <fieldset class=""layui-elem-field layui-field-title""><legend>字号</legend></fieldset>
                    <div class=""layui-col-md12"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13f592b9969580677b569cfea4c55943c0ca0d9424130", async() => {
                    WriteLiteral("\r\n                            <div class=\"layui-form-item\"");
                    BeginWriteAttribute("pane", " pane=\"", 14947, "\"", 14954, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                                <div class=""layui-input-line"">
                                    <input type=""radio"" name=""fontsize"" value=""lg"" title=""大号"">
                                    <input type=""radio"" name=""fontsize"" value=""md"" title=""默认"">
                                    <input type=""radio"" name=""fontsize"" value=""sm"" title=""小号"">
                                    <input type=""radio"" name=""fontsize"" value=""xs"" title=""超小"">
                                </div>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <script type=""text/javascript"" src=""./lib/layui/lay/modules/form.js""></script>
    </div>


    <script>
        //注意：element未作封装处理，使用layui.use引用
        layui.use(['element'], function () {
            var element = layui.element;
            console.log('触发了layui.element');

        });
        function cleancache() {
            var a = hg.load(function () {
                var that = this;
                setTimeout(function () {
                    //that.close(); //关闭加载层
                    a.close();
                    hg.msghide('清除服务器缓存成功.');
                }, 2000);
            })
        }
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer L { get; private set; }
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
