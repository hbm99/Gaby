using System;
using Gaby.Client.Shared;

namespace Gaby.Client.Services
{
	public interface IAlertService
	{
		event Action<AlertModel> OnAlert;
		void Success(string message, bool keepAfterRouteChange = false, bool autoClose = true);
		void Error(string message, bool keepAfterRouteChange = false, bool autoClose = true);
		void Info(string message, bool keepAfterRouteChange = false, bool autoClose = true);
		void Warn(string message, bool keepAfterRouteChange = false, bool autoClose = true);
		void Alert(AlertModel alert);
		void Clear(string id = "");
	}
}

