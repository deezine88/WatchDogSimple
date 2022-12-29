using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeezNet.Models
{
    public class BPRoData
    {
        public decimal HtfTrailerTrend { get; set; }
        public decimal CtfTrailerTrend { get;  set; }
        public decimal HtfTrailerChange { get;  set; }
        public decimal CtfTrailerChange { get;  set; }
        public decimal CoreBaseLine { get;  set; }
        public decimal AtrHighBandTop { get;  set; }
        public decimal AtrHighBandBottom { get;  set; }
        public decimal AtrLowBandTop { get;  set; }
        public decimal AtrLowBandBottom { get;  set; }
        public decimal BullExhaustionPivot { get;  set; }
        public decimal BearExhaustionPivot { get;  set; }
        public decimal BullPivotPoint { get;  set; }
        public decimal BearPivotPoint { get;  set; }
        public decimal BullPivotLevel { get;  set; }
        public decimal BearPivotLevel { get;  set; }
        public decimal ScalperStepLine { get;  set; }
        public decimal ScalperFilterBaseLine { get;  set; }
        public decimal ScalperBullSignal { get;  set; }
        public decimal ScalperBearSignal { get;  set; }

    }

}
}
