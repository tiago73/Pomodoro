#pragma checksum "C:\Dev\Pomodoro\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bcdb0798a60b3e6bed6592be8ab4e18095af666"
// <auto-generated/>
#pragma warning disable 1591
namespace Pomodoro.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\Pomodoro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Pomodoro\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\Pomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\Pomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\Pomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\Pomodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\Pomodoro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\Pomodoro\_Imports.razor"
using Pomodoro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\Pomodoro\_Imports.razor"
using Pomodoro.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\Pomodoro\_Imports.razor"
using Pomodoro.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "ten columns centered");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "ul");
            __builder.AddAttribute(7, "class", "button-group even three-up");
            __builder.AddAttribute(8, "id", "timer_selection");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "li");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "button" + " active" + "  " + (
#nullable restore
#line 6 "C:\Dev\Pomodoro\Pages\Index.razor"
                                                _timerType == TimerType.Pomodro? "selected-pomodoro-option":"pomodoro-button"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "id", "pomodoro");
            __builder.AddAttribute(14, "type", "submit");
            __builder.AddAttribute(15, "value", "Pomodoro");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Dev\Pomodoro\Pages\Index.razor"
                                                                                                                                                                                       SetToPomodoro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Pomodoro");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "li");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "button" + " " + (
#nullable restore
#line 7 "C:\Dev\Pomodoro\Pages\Index.razor"
                                        _timerType == TimerType.PausaCurta? "selected-pomodoro-option":"pomodoro-button"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "id", "short_break");
            __builder.AddAttribute(23, "type", "submit");
            __builder.AddAttribute(24, "value", "Short Break");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Dev\Pomodoro\Pages\Index.razor"
                                                                                                                                                                                        SetToShortBreak

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Pausa Curta");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "li");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "button" + " " + (
#nullable restore
#line 8 "C:\Dev\Pomodoro\Pages\Index.razor"
                                        _timerType == TimerType.PausaLonga? "selected-pomodoro-option":"pomodoro-button"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "id", "long_break");
            __builder.AddAttribute(32, "type", "submit");
            __builder.AddAttribute(33, "value", "Long Break");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Dev\Pomodoro\Pages\Index.razor"
                                                                                                                                                                                      SetToLongBreak

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Pausa Longa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "text-center");
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row text-center");
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-12 text-center");
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row");
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-8 offset-2 box-pomodoro");
            __builder.AddMarkupContent(54, "\r\n\r\n                    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row text-center");
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col-8 offset-2 text-center");
            __builder.AddMarkupContent(60, "\r\n\r\n                            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row");
            __builder.AddMarkupContent(63, "\r\n                                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "timer-pomodoro col-12 text-center");
            __builder.AddMarkupContent(66, "\r\n\r\n                                    ");
            __builder.OpenElement(67, "h1");
            __builder.AddContent(68, " ");
            __builder.OpenElement(69, "span");
            __builder.AddContent(70, 
#nullable restore
#line 25 "C:\Dev\Pomodoro\Pages\Index.razor"
                                                _timeLeft.ToString("mm:ss")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "row");
            __builder.AddMarkupContent(76, "\r\n                                ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "six columns centered");
            __builder.AddMarkupContent(79, "\r\n                                   \r\n");
#nullable restore
#line 31 "C:\Dev\Pomodoro\Pages\Index.razor"
                                     if (_PomodoroConfig == null)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "                                        ");
            __builder.AddMarkupContent(81, "<span class=\"custom-message\">Em primeiro lugar, configure o tempo para Pomodoro, Pausa Curta e Pausa Longa em Configurações</span>\r\n");
#nullable restore
#line 34 "C:\Dev\Pomodoro\Pages\Index.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "                                        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "four columns");
            __builder.AddMarkupContent(85, "                                             \r\n                                            ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "class", "success radius large button");
            __builder.AddAttribute(88, "type", "button");
            __builder.AddAttribute(89, "value", 
#nullable restore
#line 38 "C:\Dev\Pomodoro\Pages\Index.razor"
                                                                                                             _timerHasStarted? "Stop":"Start"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Dev\Pomodoro\Pages\Index.razor"
                                                                                                                                                          SetTimer

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
            __builder.AddContent(93, "                                        ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "four columns");
            __builder.AddMarkupContent(96, "\r\n\r\n                                           ");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "class", "radius large secondary button");
            __builder.AddAttribute(99, "type", "button");
            __builder.AddAttribute(100, "value", "Reset");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Dev\Pomodoro\Pages\Index.razor"
                                                                                                                              ResetTimer

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 45 "C:\Dev\Pomodoro\Pages\Index.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Dev\Pomodoro\Pages\Index.razor"
       

    private PomodoroConfig _PomodoroConfig;
    private bool _timerHasStarted;
    private static System.Timers.Timer _aTimer;
    private DateTime _timeLeft = new DateTime();
    private TimerType _timerType;


    protected override async Task OnInitializedAsync()
    {
         _timerType = TimerType.Pomodro;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {

        var json = await localStorage.GetItemAsync<string>("pomodoroSettings");

        if (json != null)
        {
            _PomodoroConfig = System.Text.Json.JsonSerializer.Deserialize<PomodoroConfig>(json);

            StateHasChanged();
        }

    }

    private void SetToPomodoro()
    {
        _timerHasStarted = false;
        _timeLeft = new DateTime();
        _timerType = TimerType.Pomodro;
        _timeLeft = _timeLeft.AddMinutes(_PomodoroConfig.PomodoroDuration);
        StateHasChanged();
    }

    private void SetToShortBreak()
    {
        _timerHasStarted = false;
        _timeLeft = new DateTime();
        _timerType = TimerType.PausaCurta;
        _timeLeft = _timeLeft.AddMinutes(_PomodoroConfig.PausaCurta);
        StateHasChanged();
    }

    private void SetToLongBreak()
    {
        _timerHasStarted = false;
        _timeLeft = new DateTime();
        _timerType = TimerType.PausaLonga;
        _timeLeft = _timeLeft.AddMinutes(_PomodoroConfig.PausaLonga);
    }

    private void ResetTimer()
    {
        _timerHasStarted = false;

        switch (_timerType)
        {
            case TimerType.Pomodro:
                SetToPomodoro();
                break;
            case TimerType.PausaCurta:
                SetToShortBreak();
                break;
            case TimerType.PausaLonga:
                SetToLongBreak();
                break;
        }
    }


    private void SetTimer()
    {
        if (_timerHasStarted)
        {
            _timerHasStarted = false;
        }
        else
        {
            if (_aTimer != null)
            {
                _aTimer.Dispose();
            }
            _timerHasStarted = true;
            _aTimer = new System.Timers.Timer(1000);
            _aTimer.Elapsed += OnTimedEvent;
            _aTimer.AutoReset = true;
            _aTimer.Enabled = true;
        }

        StateHasChanged();
    }


    private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        if (_timerHasStarted)
        {
            try
            {
                _timeLeft = _timeLeft.AddSeconds(-1);
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }

        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591