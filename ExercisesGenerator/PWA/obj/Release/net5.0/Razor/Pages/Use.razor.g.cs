#pragma checksum "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bddc517b5d2ff00825dd7079fe8a9acd7c9739e"
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
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using PWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using PWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using PWA.Shared.Componets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\TeamProgramming\ExercisesGenerator\PWA\_Imports.razor"
using PWA.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/use")]
    public partial class Use : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-header");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn btn-outline-primary");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
                                                           ChangeSettingDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, 
#nullable restore
#line 5 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
                                                                                   new MarkupString(SettingTitle)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 7 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
     if (ShowSetting)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenComponent<PWA.Shared.Componets.MySettings>(10);
            __builder.AddAttribute(11, "LocalSettings", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PWA.Shared.Models.WebSettings>(
#nullable restore
#line 10 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
                                        setting

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 12 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-header");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-outline-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
                                                           ChangeGeneratorDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, 
#nullable restore
#line 16 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
                                                                                     new MarkupString(GeneratorTitle)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
     if (ShowGenerator)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body");
            __builder.OpenComponent<PWA.Shared.Componets.MyGenerator>(23);
            __builder.AddAttribute(24, "Exercises", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Tools.TableData>(
#nullable restore
#line 21 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
                                     tableData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "LocalSettings", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PWA.Shared.Models.WebSettings>(
#nullable restore
#line 21 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
                                                                setting

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 23 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "card-header");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-outline-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
                                                           ChangeCheckerDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, 
#nullable restore
#line 27 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
                                                                                   new MarkupString(CheckerTitle)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
     if (ShowChecker)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "card-body");
            __builder.OpenComponent<PWA.Shared.Componets.MyChecker>(37);
            __builder.AddAttribute(38, "Exercises", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Tools.CheckerData>(
#nullable restore
#line 32 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
                                   Exercises

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\TeamProgramming\ExercisesGenerator\PWA\Pages\Use.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591