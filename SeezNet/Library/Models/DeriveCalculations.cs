using SeezNet.B;
using SeezNet.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeezNet.Models;

public class DeriveCalculations
{
    public Direction CtfTrailerSide { get; set; }

    // PIVOT Zone duration
    public byte BullPivotLevelDuration { get; set; }
    public byte BearPivotLevelDuration { get; set; }

    // EXHAUSTION Level duration
    public byte BullExhaustionPivotDuration { get; set; }
    public byte BearExhaustionPivotDuration { get; set; }

    // EXHAUSTION Re-established (touched) duration
    public byte BullExhaustionTouchDuration { get; set; }
    public byte BearExhaustionTouchDuration { get; set; }

    // STEP-LINE Consistent Move duration
    public byte StepLineBullRunDuration { get; set; }
    public byte StepLineBearRunDuration { get; set; }

}
