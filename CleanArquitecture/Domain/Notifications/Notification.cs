﻿namespace CleanArquitecture.Domain.Notifications
{
    public abstract class Notification
    {
        public abstract void Send(string message);
    }
}
