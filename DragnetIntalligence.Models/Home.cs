using System;
using System.Collections.Generic;
using System.Text;

namespace Dragnet.Models
{
   public class Home
    {
        public string DailyCount { get; set; }
        public string ContinousCount { get; set; }
        public string PeriscopeCount { get; set; }
        public string VipCount { get; set; }
        public string TotalCount { get; set; }
        public string MessagesReceived { get; set; }
        public string MessagesViewed { get; set; }
        public string MessagesSent { get; set; }
        public string MessagesSentViewed { get; set; }
    }
}
