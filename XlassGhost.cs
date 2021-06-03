using System;
using System.Linq;
using System.IO;

class Proofs 
{
    public var EMF5 = false;
    public var NegativeTemp = false;
    public var Fingerprints = false;
    public var GhostWrite = false;
    public var GhostOrbs = false;
    public var SpiritBoxResponsive = false;
}

class Revenant
{
    public int viewRVT {get; set;} = 20.00;
    public int RangeRVT {get; set;} = 3;
    public int speedRVT {get; set;} = 1.5;
    public int speedChase {get; set;} = 4.00;
    public int ApparitionRateRVT {get; set;} = 10.00;
    public var ProffsRVT1 {get; set;} = +GhostWrite = true;
    public var ProffsRVT2 {get; set;} = +FingerPrint = true;
    public var ProffsRVT3 {get; set;} = +EMF5 = true;
}

class Banshee
{
    public int ViewBS {get; set;} = 20.00;
    public int RangeBS {get; set;} = 3;
    public int speedBS {get; set;} = 2;
    public int speedChaseBS {get; set;} = playerFocusedSpeed - 1;
    public int ApparitionRateBS {get; set;} = 10.00;
}
class phantom
{
    public int ViewPh {get; set;} = 20.00;
    public int rangeP {get; set;} = 3;
    public int speedPh {get; set;} = 2;
    public int speedChasePh {get; set;} = 2.5;
    public int ApparitionRatePh {get; set;} = 10.00;
    public var proofPh {get; set;} = emf5 = true;
    public var proofph1 {set; get;} = GhostOrbs = true;
    public var proofph2 {get; set;} = NegativeTemps = true;
}
class Yurei
{
    public int ViewYurei {get; set;} = 20.00;
    public int RangeYurei {get; set;} = 3;
    public int speedYurei {get; set;} = 2;
    public int speedChaseYurei {get; set;} = 2.5;
    public int ApparitionRateYurei {get; set;} = PlayerInteraction;
    
}
class hantu
{
    public int ViewHaT {get; set;} = 20.00;
    public int rangeHaT {get; set;} = 3;
    public int speedHat {get; set;} = 2;
    public int speedChaseHat {get; set;} = 2.5;
    public int ApparitionRateHat {get; set;} = PlayerInteraction;
}
class spirit
{
    public int ViewSpt {get; set;} = 20.00;
    public int rangeSpt {get; set;} = 3;
    public int speedSpt {get; set;} = 2;
    public int speedChaseSpt {get; set;} = 2.5;
    public int ApparitionRateSpt {get; set;} = 5.00;
}
class shadow
{
    public int Viewshd {get; set;} = 20.00;
    public int rangeShd {get; set;} = 3;
    public int speedshd {get; set;} = 2;
    public int SpeedChaseShd {get; set;} = 2.5;
    public Var ApparitionRateShd {get; set;} = GhostArea = isempty;
}
class Spectre
{
    public int ViewSpc {get; set;} = 20.00;
    public int RangeSpc {get; set;} = 3;
    public int SpeedSpc {get; set;} = 2;
    public int SpeedChaseSpc {get; set;} = 2.5;
    public int ApparitionRateSpc {get; set;} = 10.00;
}
class Demon
{
    public int ViewDm {get; set;} = 20.00;
    public int RangeDm {get; set;} = 3;
    public int SpeedDm {get; set;} = 2;
    public int SpeedChaseDm {get; set;} = 10.00;
    public int ApparitionRateDm {get; set;} = 20.00;
}
class poltergeist
{
    public int ViewPlt {get; set;} = 20.00;
    public int RangePlt {get; set;} = 3;
    public int SpeedPlt {get; set;} = 2;
    public int SpeedChasePlt {get; set;} = 2.5;
    public int ApparitionRateSpt {get; set;} = PlayerPresence;
}
class Nightmare
{
    public int ViewNgh {get; set;} = 20.00;
    public int rangeNgh {get; set;} = 3;
    public int SpeedNght {get; set;} = 2;
    public int SpeedChaseNgh {get; set;} = 2.5;
    public int ApparitionNgh {get; set;} = Light = false;
}
class Djinn
{
    public int ViewDjn {get; set;} = 20.00;
    public int RangeDjn {get; set;} = 3.00;
    public int SpeedDjn {get; set;} = 2;
    public int SpeedChaseDjn {get; set;} = 2.5;
    public var DjnPowerOnSpeed {get; set;} = PowerOnstate;
}