using DragnetIntalligence.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragnetIntalligence.IRepository
{
    public interface ICourt
    {
        public bool InsertCourt(InsertCourt court);
    }
}
