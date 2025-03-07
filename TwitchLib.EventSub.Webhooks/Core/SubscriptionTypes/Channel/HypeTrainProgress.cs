﻿using System;
using TwitchLib.EventSub.Webhooks.Core.Models.HypeTrain;

namespace TwitchLib.EventSub.Webhooks.Core.SubscriptionTypes.Channel
{
    /// <summary>
    /// HypeTrain Progress subscription type model
    /// <para>Description:</para>
    /// <para>A Hype Train makes progress on the specified channel.</para>
    /// </summary>
    public class HypeTrainProgress : HypeTrainBase
    {
        /// <summary>
        /// The number of points contributed to the Hype Train at the current level.
        /// </summary>
        public int Progress { get; set; }
        /// <summary>
        /// The number of points required to reach the next level.
        /// </summary>
        public int Goal { get; set; }
        /// <summary>
        /// The most recent contribution.
        /// </summary>
        public HypeTrainContribution[] LastContribution { get; set; } = Array.Empty<HypeTrainContribution>();
        /// <summary>
        /// The time when the Hype Train expires. The expiration is extended when the Hype Train reaches a new level.
        /// </summary>
        public DateTime ExpiresAt { get; set; } = DateTime.MinValue;
    }
}