﻿using Newtonsoft.Json;

namespace MvvmCross.Plugins.Notifications.Presenter
{
    public abstract class RemoteNotificationIdProvider<TData> : IRemoteNotificationIdProvider where TData : class
    {
        public string GetNotificationId(string notificationJson)
        {
            return GetNotificationId(JsonConvert.DeserializeObject<TData>(notificationJson));
        }

        public abstract string GetNotificationId(TData data);
    }
}
