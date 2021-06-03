using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Crucifix
{
    public int crfxRange {get; set;} = 3;
    public int CruciPrice {get; set;} = 30;
}
class Thermometer
{
    public int ThRange {get; set;} = 5;
    public var ThValue {get; set;} = {-10, 27};
    public int ThermoPrice {get; set;} = 50;
}
class EMF
{
    public int EmfMinLevel {get; set;} = 1;
    public int EmfMaxLevel {get; set;} = 5;
    public int EmPrince {get; set;} = 45;
}