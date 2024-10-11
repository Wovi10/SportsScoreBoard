﻿using Microsoft.AspNetCore.Components;
using Recurop;

namespace SportsScoreBoard.Components.Shared;

public partial class Timer : IDisposable
{
    [Inject] private RecurringOperationsManager Recurop { get; set; }
    private RecurringOperation _timerOperation;
    TimeSpan _displayTime = TimeSpan.Zero;
    private int _elapsedSeconds;

    protected override void OnInitialized()
    {
        _timerOperation = new("timer");
        _timerOperation.Operation = IncrementTime;
        _timerOperation.OperationFaulted += LogError;
    }

    private async void IncrementTime()
    {
        await InvokeAsync(() =>
        {
            _elapsedSeconds++;
            _displayTime = TimeSpan.FromSeconds(_elapsedSeconds);
            StateHasChanged();
        });
    }

    private void LogError(Exception ex)
        => Console.WriteLine(ex.Message);

    private void StartButtonClicked()
    {
        Recurop.StartRecurring(_timerOperation, TimeSpan.FromSeconds(1));
    }

    private void PauseButtonClicked()
    {
        Recurop.PauseRecurring(_timerOperation);
    }

    private void ResumeButtonClicked()
    {
        Recurop.ResumeRecurring(_timerOperation);
    }

    private void StopButtonClicked()
    {
        _displayTime = TimeSpan.Zero;
        _elapsedSeconds = 0;
        Recurop.CancelRecurring(_timerOperation);
    }

    public void Dispose()
        => Recurop.CancelRecurring(_timerOperation);

    private void OnTimerStateChanged()
    {
        if (_timerOperation.IsRecurring)
        {
            PauseButtonClicked();
        }
        else
        {
            if (_displayTime == TimeSpan.Zero)
            {
                StartButtonClicked();
            }
            else
            {
                ResumeButtonClicked();
            }
        }
    }

    private void ResetTimer()
        => StopButtonClicked();
}