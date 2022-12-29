using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SeezNet.Models;

public class DataLoad
{
    public DateTime Time { get; set; }
    public Candle Candle { get; set; }
    public BPRoData BProData { get; set; }
    public DeriveCalculations Calculations { get; set; }
}
