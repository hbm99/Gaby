﻿using System;
using Gaby.Client.Services.SharedServices;
using Gaby.Client.Shared;

namespace Gaby.Client.Services.SharedServices;

public class AlertService : IAlertService
{
    private const string _defaultId = "default-alert";
    public event Action<AlertModel> OnAlert;

    public void Success(string message, bool keepAfterRouteChange = false, bool autoClose = true)
    {
        this.Alert(new AlertModel
        {
            Type = AlertType.Success,
            Message = message,
            KeepAfterRouteChange = keepAfterRouteChange,
            AutoClose = autoClose
        });
    }

    public void Error(string message, bool keepAfterRouteChange = false, bool autoClose = true)
    {
        this.Alert(new AlertModel
        {
            Type = AlertType.Error,
            Message = message,
            KeepAfterRouteChange = keepAfterRouteChange,
            AutoClose = autoClose
        });
    }

    public void Info(string message, bool keepAfterRouteChange = false, bool autoClose = true)
    {
        this.Alert(new AlertModel
        {
            Type = AlertType.Info,
            Message = message,
            KeepAfterRouteChange = keepAfterRouteChange,
            AutoClose = autoClose
        });
    }

    public void Warn(string message, bool keepAfterRouteChange = false, bool autoClose = true)
    {
        this.Alert(new AlertModel
        {
            Type = AlertType.Warning,
            Message = message,
            KeepAfterRouteChange = keepAfterRouteChange,
            AutoClose = autoClose
        });
    }

    public void Alert(AlertModel alert)
    {
        alert.Id = alert.Id ?? _defaultId;
        this.OnAlert?.Invoke(alert);
    }

    public void Clear(string id = _defaultId)
    {
        this.OnAlert?.Invoke(new AlertModel { Id = id });
    }
}

