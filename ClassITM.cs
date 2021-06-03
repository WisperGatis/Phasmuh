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
class SpiritBox
{
    public bool SpiritBoxReaction {get; set;} = true;
    public var SpiritBoxRange {get; set;} = GhostArea;
    public int SpiritBoxPrice {get; set;} = 50;
}
class Encens
{
    public int MaxEncens {get; set;} = 4;
    public int EncensRange {get; set;} = GhostArea+1;
    public int EncensPrice {get; set;} = 10;
}
class FleetNSteel
{
    public int MaxFleetNSteel {get; set;} = 2;
    public bool FleetStatus {get; set;} = 1;
    public int FleetPrice {get; set;} = 10;
}
class lighter
{
    public bool LighterState {get; set;} = 0;
    public int LighterPrice {get; set;} =  15;
}