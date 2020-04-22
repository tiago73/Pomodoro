#pragma checksum "C:\Dev\Pomodoro\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bcdb0798a60b3e6bed6592be8ab4e18095af666"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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