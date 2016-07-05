using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSorting.Conveyor.Events
{
    public class NewUnitEventArgs : EventArgs
    {
        public int Index { get; set; }
        public long ProcessingStartedTime { get; set; }
    }
}
