using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleSimulator
{
    public interface IUnit
    {
        DefPos MyDefPosition{ get;set;}
        Weather MyWeather{ get;set;}
        Land MyLand{ get;set;}

        int UnitAmount { get;set;}
        int UnitPower{ get; set;}
        int UnitTotalPower{ get;}

        string UnitName{ get;set;}
        int UnitID{ get;}
        char Mark { get; set;}
        int UnitType{ get;}

        bool Leader{ set;}
        IUnit MyLeader{ get; set; }
        int UnitLevel{ get;}
        int BonusValue{ get; set;}

        bool IsLeader();
        void SetStats(int Atack, int Defence, int Life, int Move, int Inc, int MaxLevel);
        void SetStats(int Atack, int Defence, int Life, int Move, int Inc, int MaxLevel,int horse_def, int horse_life, int horse_move);
        void SetStats(int Atack, int Defence, int Life, int Move, int Inc, int MaxLevel, int range);
        void CalcUnitPower();

        string ToShortString();
        string ToLongString();
    }
}
