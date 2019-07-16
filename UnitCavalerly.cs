using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleSimulator
{
    class UnitCavalerly:IUnit
    {
       int ID=0;
        int INC=0;
        int MOV=0;
        int MOV_HORSE=0;
        int LIFE=0;
        int LIFE_HORSE=0;
        int ATACK=0;
        int DEF=0;
        int DEF_HORSE=0;
        int LEVEL=0;
        int BONUS=0;

        bool LEADER;
        TypesEnums.UnitType Type;
        DefPos MyPosition;

        public char Mark { get; set;}

        public UnitCavalerly(int id, char M,TypesEnums.UnitType T){
            ID=id;
            Mark=M;
            Type=T;
        }
        public void SetStats(int Atack, int Defence, int Life, int Move, int Inc, int MaxLevel, int horse_def, int horse_life, int horse_move)
        {
                INC=Inc;
                MOV=Move;
                MOV_HORSE=horse_move;
                LIFE=Life;
                LIFE_HORSE=horse_life;
                ATACK=Atack;
                DEF=Defence;
                DEF_HORSE=horse_def;
                LEVEL=MaxLevel;
                BonusValue=0;
        }

        public int UnitAmount { get; set; }
        public int UnitPower { get; set; }
        public int UnitTotalPower { get{ return (UnitPower*UnitAmount); } }
        public string UnitName { get; set; }
        public DefPos MyDefPosition { get{ return MyPosition;} set{
                if(value==null){MyLeader=null; Leader=false;}
                MyPosition=value;
        } }

        public bool Leader{ set{
                LEADER=value;
                if(value){
                    CalcUnitBonus();
                    Mark='♦';
                }
                else {
                    BonusValue=0;
                    if(MyLeader!=null)BonusValue=MyLeader.BonusValue;
                    Mark=(char)Type; 
                }
         } }
        public IUnit MyLeader { get; set; }

        public int BonusValue{ 
        get{
              if(BONUS-(MyLand.getLandIndex/4)>0)
                return BONUS-(MyLand.getLandIndex/4);
              else return 1;
           } 
        set{ 
                BONUS=value;
           } 
        }

        public int DefBonusValue{ get{
                if(MyDefPosition!=null){
                    if((MyDefPosition.getDefence-(MyWeather.getWeatherIndex/4))>0)return (MyDefPosition.getDefence-(MyWeather.getWeatherIndex/4));
                    else return 1;
                }
                else return 1;
        }}

        public int UnitID { get{ return ID;} }

        public int UnitLevel { get{ return LEVEL;} }

        public int UnitType { get{ return (int)Type; } }

        public Weather MyWeather { get; set; }
        public Land MyLand { get; set; }

        public void CalcUnitBonus()
        {
            BonusValue=LEVEL/5;
        }

        public void CalcUnitPower()
        {
            UnitPower=((DefBonusValue*(ATACK+BonusValue)*(DEF+DEF_HORSE+BonusValue)*CalcIniciativity())+LIFE+LIFE_HORSE);
        }
        public override string ToString()
        {
            if(MyDefPosition!=null)
            return Mark+" | "+ID+","+UnitName+",OMP: "+UnitPower+" | "+UnitAmount+", D:"+MyDefPosition.getID;
            else
            return Mark+" | "+ID+","+UnitName+",OMP: "+UnitPower+" | "+UnitAmount+", D: -";
        }
        public string ToLongString(){ 
            return Mark+" Unit ID: "+ID+" Name ->"+UnitName+", OMP : "+UnitPower+", Total Power: "+UnitTotalPower+" ,UnitAmount: "+UnitAmount;   
        }
        public string ToShortString()
        {
            return Mark+" Unit ID: "+ID+" Name ->"+UnitName;
        }
        public int CalcIniciativity()
        {
            int tmp_inc=1, tmp_mov=1;

            if(INC+(MOV+MOV_HORSE)<=0) return 1;
            if(INC > 0)tmp_inc=INC;
            if(MOV > 0)tmp_mov=MOV;

            if((tmp_inc*tmp_mov)+(MOV_HORSE-MyLand.getLandIndex)>(MyLand.getLandIndex+MyWeather.getWeatherIndex)/6)
            return (tmp_inc*tmp_mov)+(MOV_HORSE-MyLand.getLandIndex)-((MyLand.getLandIndex+MyWeather.getWeatherIndex)/6);
            else return 1;
        }

        public bool IsLeader()
        {
            return LEADER;
        }

        public void SetStats(int A, int D, int L, int M, int I, int ML){
            throw new NotImplementedException();
        }

        public void SetStats(int Atack, int Defence, int Life, int Move, int Inc, int MaxLevel, int range)
        {
            throw new NotImplementedException();
        }
    }
}
