#pragma checksum "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7e166641c3258b89c0d2fba6b3c9a07354cd791"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Shared.Componets
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
    public partial class MySettings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "id", "edit");
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                            LocalSettings

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                                           SaveLocalSettings

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "table");
                __builder2.AddAttribute(8, "class", "table");
                __builder2.OpenElement(9, "tr");
                __builder2.AddMarkupContent(10, "<td>习题个数</td>\r\n            ");
                __builder2.OpenElement(11, "td");
                __Blazor.PWA.Shared.Componets.MySettings.TypeInference.CreateInputNumber_0(__builder2, 12, 13, 
#nullable restore
#line 8 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                           LocalSettings.ProblemsNumber

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocalSettings.ProblemsNumber = __value, LocalSettings.ProblemsNumber)), 15, () => LocalSettings.ProblemsNumber);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __Blazor.PWA.Shared.Componets.MySettings.TypeInference.CreateValidationMessage_1(__builder2, 17, 18, 
#nullable restore
#line 10 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                () => LocalSettings.ProblemsNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "tr");
                __builder2.AddMarkupContent(21, "<td>运算符个数</td>\r\n            ");
                __builder2.OpenElement(22, "td");
                __Blazor.PWA.Shared.Componets.MySettings.TypeInference.CreateInputNumber_2(__builder2, 23, 24, 
#nullable restore
#line 13 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                           LocalSettings.OperatorsNumber

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocalSettings.OperatorsNumber = __value, LocalSettings.OperatorsNumber)), 26, () => LocalSettings.OperatorsNumber);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __Blazor.PWA.Shared.Componets.MySettings.TypeInference.CreateValidationMessage_3(__builder2, 28, 29, 
#nullable restore
#line 15 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                () => LocalSettings.OperatorsNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "tr");
                __builder2.AddMarkupContent(32, "<td>整数最小值</td>\r\n            ");
                __builder2.OpenElement(33, "td");
                __Blazor.PWA.Shared.Componets.MySettings.TypeInference.CreateInputNumber_4(__builder2, 34, 35, 
#nullable restore
#line 18 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                           LocalSettings.IntegerMinimize

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocalSettings.IntegerMinimize = __value, LocalSettings.IntegerMinimize)), 37, () => LocalSettings.IntegerMinimize);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __Blazor.PWA.Shared.Componets.MySettings.TypeInference.CreateValidationMessage_5(__builder2, 39, 40, 
#nullable restore
#line 20 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                () => LocalSettings.IntegerMinimize

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenElement(42, "tr");
                __builder2.AddMarkupContent(43, "<td>整数最大值</td>\r\n            ");
                __builder2.OpenElement(44, "td");
                __Blazor.PWA.Shared.Componets.MySettings.TypeInference.CreateInputNumber_6(__builder2, 45, 46, 
#nullable restore
#line 23 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                           LocalSettings.IntegerMaximum

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocalSettings.IntegerMaximum = __value, LocalSettings.IntegerMaximum)), 48, () => LocalSettings.IntegerMaximum);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __Blazor.PWA.Shared.Componets.MySettings.TypeInference.CreateValidationMessage_7(__builder2, 50, 51, 
#nullable restore
#line 25 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                () => LocalSettings.IntegerMaximum

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenElement(53, "tr");
                __builder2.AddMarkupContent(54, "<td>分母最大值</td>\r\n            ");
                __builder2.OpenElement(55, "td");
                __Blazor.PWA.Shared.Componets.MySettings.TypeInference.CreateInputNumber_8(__builder2, 56, 57, 
#nullable restore
#line 28 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                           LocalSettings.DenominationMaximum

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocalSettings.DenominationMaximum = __value, LocalSettings.DenominationMaximum)), 59, () => LocalSettings.DenominationMaximum);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __Blazor.PWA.Shared.Componets.MySettings.TypeInference.CreateValidationMessage_9(__builder2, 61, 62, 
#nullable restore
#line 30 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                () => LocalSettings.DenominationMaximum

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenElement(64, "tr");
                __builder2.AddMarkupContent(65, "<td>允许加法</td>\r\n            ");
                __builder2.OpenElement(66, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(67);
                __builder2.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                             LocalSettings.AllowPlus

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocalSettings.AllowPlus = __value, LocalSettings.AllowPlus))));
                __builder2.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => LocalSettings.AllowPlus));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenElement(72, "tr");
                __builder2.AddMarkupContent(73, "<td>允许减法</td>\r\n            ");
                __builder2.OpenElement(74, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(75);
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                             LocalSettings.AllowSubscribe

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocalSettings.AllowSubscribe = __value, LocalSettings.AllowSubscribe))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => LocalSettings.AllowSubscribe));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.OpenElement(80, "tr");
                __builder2.AddMarkupContent(81, "<td>允许乘法</td>\r\n            ");
                __builder2.OpenElement(82, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(83);
                __builder2.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                             LocalSettings.AllowMultiply

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocalSettings.AllowMultiply = __value, LocalSettings.AllowMultiply))));
                __builder2.AddAttribute(86, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => LocalSettings.AllowMultiply));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n        ");
                __builder2.OpenElement(88, "tr");
                __builder2.AddMarkupContent(89, "<td>允许除法</td>\r\n            ");
                __builder2.OpenElement(90, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(91);
                __builder2.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                             LocalSettings.AllowDivide

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocalSettings.AllowDivide = __value, LocalSettings.AllowDivide))));
                __builder2.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => LocalSettings.AllowDivide));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.OpenElement(96, "tr");
                __builder2.AddMarkupContent(97, "<td>允许括号</td>\r\n            ");
                __builder2.OpenElement(98, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(99);
                __builder2.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                             LocalSettings.AllowParentheses

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocalSettings.AllowParentheses = __value, LocalSettings.AllowParentheses))));
                __builder2.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => LocalSettings.AllowParentheses));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n        ");
                __builder2.OpenElement(104, "tr");
                __builder2.AddMarkupContent(105, "<td>允许分数</td>\r\n            ");
                __builder2.OpenElement(106, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(107);
                __builder2.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 53 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                                             LocalSettings.AllowFraction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LocalSettings.AllowFraction = __value, LocalSettings.AllowFraction))));
                __builder2.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => LocalSettings.AllowFraction));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n    ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "btn btn-group");
                __builder2.AddAttribute(114, "style", "display:table;margin:0 auto;");
                __builder2.AddMarkupContent(115, "<button type=\"submit\" class=\"btn btn-outline-primary\"><span class=\"oi oi-hard-drive\"></span> 保存设置\r\n        </button>\r\n        ");
                __builder2.OpenElement(116, "button");
                __builder2.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                           SetDefault

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(118, "class", "btn btn-outline-primary");
                __builder2.AddMarkupContent(119, "<span class=\"oi oi-trash\"></span> 恢复默认设置\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n        ");
                __builder2.OpenElement(121, "button");
                __builder2.AddAttribute(122, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "D:\TeamProgramming\ExercisesGenerator\PWA\Shared\Componets\MySettings.razor"
                           LoadLocalSettings

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(123, "class", "btn btn-outline-primary");
                __builder2.AddMarkupContent(124, "<span class=\"oi oi-data-transfer-upload\"></span> 加载设置\r\n        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
namespace __Blazor.PWA.Shared.Componets.MySettings
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591