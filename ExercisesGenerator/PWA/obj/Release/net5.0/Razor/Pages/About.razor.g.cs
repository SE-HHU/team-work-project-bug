#pragma checksum "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ca65e03d115839996b5e06efc4cb8382d7de661"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using IndexedDB.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using PWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using PWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using PWA.Shared.Componets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using PWA.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Tools;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/about")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AntDesign.Affix>(0);
            __builder.AddAttribute(1, "OffsetTop", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                    0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Button>(3);
                __builder2.AddAttribute(4, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                   ButtonType.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Shape", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                    ButtonShape.Circle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                     () => NavigationManager.NavigateTo("")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Icon>(8);
                    __builder3.AddAttribute(9, "Type", "home");
                    __builder3.AddAttribute(10, "Theme", "outline");
                    __builder3.AddAttribute(11, "Style", "font-size:x-large");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Button>(13);
                __builder2.AddAttribute(14, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                   ButtonType.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Shape", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                    ButtonShape.Circle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                     () => NavigationManager.NavigateTo("settings")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Icon>(18);
                    __builder3.AddAttribute(19, "Type", "setting");
                    __builder3.AddAttribute(20, "Theme", "outline");
                    __builder3.AddAttribute(21, "Style", "font-size:x-large");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Button>(23);
                __builder2.AddAttribute(24, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                   ButtonType.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Shape", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                    ButtonShape.Circle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                     () => NavigationManager.NavigateTo("generator")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Icon>(28);
                    __builder3.AddAttribute(29, "Type", "profile");
                    __builder3.AddAttribute(30, "Theme", "outline");
                    __builder3.AddAttribute(31, "Style", "font-size:x-large");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Button>(33);
                __builder2.AddAttribute(34, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                   ButtonType.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Shape", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                    ButtonShape.Circle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                     () => NavigationManager.NavigateTo("exercise")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Icon>(38);
                    __builder3.AddAttribute(39, "Type", "edit");
                    __builder3.AddAttribute(40, "Theme", "outline");
                    __builder3.AddAttribute(41, "Style", "font-size:x-large");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Button>(43);
                __builder2.AddAttribute(44, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                   ButtonType.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "Shape", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                    ButtonShape.Circle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                     () => NavigationManager.NavigateTo("wrongs")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Icon>(48);
                    __builder3.AddAttribute(49, "Type", "close-square");
                    __builder3.AddAttribute(50, "Theme", "outline");
                    __builder3.AddAttribute(51, "Style", "font-size:x-large");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Button>(53);
                __builder2.AddAttribute(54, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                   ButtonType.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "Shape", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                    ButtonShape.Circle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\About.razor"
                     () => NavigationManager.NavigateTo("statist")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Icon>(58);
                    __builder3.AddAttribute(59, "Type", "line-chart");
                    __builder3.AddAttribute(60, "Theme", "outline");
                    __builder3.AddAttribute(61, "Style", "font-size:x-large");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.AddMarkupContent(63, "<h3>关于本应用</h3>\r\n");
            __builder.AddMarkupContent(64, "<p>四则运算习题生成器 <small>V 2.0.0</small></p>\r\n");
            __builder.AddMarkupContent(65, @"<div class=""card"" id=""developers""><div class=""card-header""><span class=""oi oi-list""></span> 开发人员</div>
    <div class=""card-body""><ul class=""list-group""><li class=""list-group-item""><span class=""oi oi-chevron-right""></span> 许正正
                <span class=""badge badge-info""><a href=""https://jiafeimiao.top/"" target=""_blank"">Blog</a></span></li>
            <li class=""list-group-item""><span class=""oi oi-chevron-right""></span> 吴宁
                <span class=""badge badge-info""><a href=""https://www.baidu.com"" target=""_blank"">Blog</a></span></li>
            <li class=""list-group-item""><span class=""oi oi-chevron-right""></span> 陈妍洁
                <span class=""badge badge-info""><a href=""https://www.baidu.com"" target=""_blank"">Blog</a></span></li>
            <li class=""list-group-item""><span class=""oi oi-chevron-right""></span> 赵悦
                <span class=""badge badge-info""><a href=""https://www.baidu.com"" target=""_blank"">Blog</a></span></li>
            <li class=""list-group-item""><span class=""oi oi-chevron-right""></span> 施睿
                <span class=""badge badge-info""><a href=""https://www.baidu.com"" target=""_blank"">Blog</a></span></li>
            <li class=""list-group-item""><span class=""oi oi-chevron-right""></span> 李秀吉
                <span class=""badge badge-info""><a href=""https://www.baidu.com"" target=""_blank"">Blog</a></span></li></ul></div></div>
");
            __builder.AddMarkupContent(66, @"<div class=""card"" id=""conect""><div class=""card-header""><span class=""oi oi-list""></span> 联系我们</div>
    <div class=""card-body""><ul class=""list-group""><li class=""list-group-item""><a href=""mailto:xuzhengzheng@outlook.com"" target=""_blank""><span class=""oi oi-envelope-open""></span> 邮箱1
                </a><br>
                <a href=""mailto:wn913457335@163.com"" target=""_blank""><span class=""oi oi-envelope-open""></span> 邮箱2
                </a></li>
            <li class=""list-group-item""><a href=""https://github.com/JiaFeiMiao-K-Cat/Setting/issues"" target=""_blank""><span class=""oi oi-link-intact""></span> Github Issues
                </a></li></ul></div></div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
