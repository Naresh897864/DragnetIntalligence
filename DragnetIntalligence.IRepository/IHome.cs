using Dragnet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dragnet.IRepository
{
    public interface IHome
    {
        public List<Home> GetActivitiesDailyCount();
        public List<Home> GetActivitiesMonthlyCount();
        public List<Home> GetMessagesCount();
    }
}
