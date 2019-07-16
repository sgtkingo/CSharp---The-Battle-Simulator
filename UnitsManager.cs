using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleSimulator
{
    public class UnitsManager
    {
        ConsoleBox ConsoleBox;
        LandManager LandManager;
        List<IUnit> Ally;
        List<IUnit> Enemy;

        int LastID=0;
        int NextID{ get{ 
         return LastID++;
        }}

        public UnitsManager(ConsoleBox CB, LandManager LM){ 
            Ally= new List<IUnit>();
            Enemy=new List<IUnit>();

            ConsoleBox=CB;
            LandManager=LM;
            ConsoleBox.WriteLineToConsole("UnitManager READY!");
        }

        public IUnit CreateUnit(TypesEnums.UnitSide S, TypesEnums.UnitType T){
            IUnit U=null;
            if(T==TypesEnums.UnitType.Infantry)U=new UnitInfantry(NextID, (char)TypesEnums.UnitType.Infantry,TypesEnums.UnitType.Infantry);
            if(T==TypesEnums.UnitType.Archers)U=new UnitArchers(NextID, (char)TypesEnums.UnitType.Archers,TypesEnums.UnitType.Archers );
            if(T==TypesEnums.UnitType.Cavalerly)U=new UnitCavalerly(NextID, (char)TypesEnums.UnitType.Cavalerly,TypesEnums.UnitType.Cavalerly );

            if(U==null)throw new Exception("Error: Null IUnit object!");

            if(S==TypesEnums.UnitSide.Ally)Ally.Add(U);
            else Enemy.Add(U);

            U.MyLand=LandManager.ActualLandLand;
            U.MyWeather=LandManager.ActualWeather;
            U.MyDefPosition=null;
            ConsoleBox.WriteLineToConsole("New Unit CREATE!");
            return U;
        }

        public void RemoveItem(IUnit U){
            if(Ally.Contains(U))Ally.Remove(U);
            if(Enemy.Contains(U))Enemy.Remove(U);
            if(U.MyDefPosition!=null)U.MyDefPosition.UnloadUnit(U);
            ConsoleBox.WriteLineToConsole("Item "+U.ToString()+" removed...");
        }

        public List<IUnit> getUnitsList(TypesEnums.UnitSide S){
            if(S==TypesEnums.UnitSide.Ally)return Ally;
            else return Enemy;
        }

        public int getTotalForce(TypesEnums.UnitSide S){
            int tmp=0;
            if(S==TypesEnums.UnitSide.Ally){
                foreach(IUnit U in Ally){
                    tmp+=U.UnitTotalPower;
                }
            }
            else
                foreach(IUnit U in Enemy){
                    tmp+=U.UnitTotalPower;
                }
            return tmp;
        }
        public int getTotalAmount(TypesEnums.UnitSide S){ 
            int tmp=0;
            if(S==TypesEnums.UnitSide.Ally){
                foreach(IUnit U in Ally){
                    tmp+=U.UnitAmount;
                }
            }
            else
                foreach(IUnit U in Enemy){
                    tmp+=U.UnitAmount;
                }
            return tmp;
        }
        public void refresh(){ 
        foreach(IUnit U in Ally)U.CalcUnitPower();
        foreach(IUnit U in Enemy)U.CalcUnitPower(); 
        }
    }
}
