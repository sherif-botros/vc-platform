﻿using VirtoCommerce.Platform.Core.Events;

namespace VirtoCommerce.Platform.Core.Security.Events
{
    public class UserPasswordChangedEvent : DomainEvent
    {
        public UserPasswordChangedEvent(string userId)
        {
            UserId = userId;
        }

        public string UserId { get; set; }
    }
}
