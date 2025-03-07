﻿using System;
using TwitchLib.EventSub.Webhooks.Core.Models.HypeTrain;

namespace TwitchLib.EventSub.Webhooks.Core.SubscriptionTypes.Channel
{
    /// <summary>
    /// HypeTrain End subscription type model
    /// <para>Description:</para>
    /// <para>A Hype Train ends on the specified channel.</para>
    /// </summary>
    public class HypeTrainEnd : HypeTrainBase
    {
        /// <summary>
        /// The time when the Hype Train cooldown ends so that the next Hype Train can start.
        /// </summary>
        public DateTime CooldownEndsAt { get; set; } = DateTime.MinValue;
        /// <summary>
        /// The time when the Hype Train ended.
        /// </summary>
        public DateTime EndedAt { get; set; } = DateTime.MinValue;
    }
}