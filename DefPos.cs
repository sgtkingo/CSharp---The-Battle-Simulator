using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleSimulator
{
    public class DefPos
    {
        public int WeightPosition{ get;set;}
        public int HeightPosition{ get;set;}
        public int TallPosition{ get;set;}
        public int DefencePosition{ get;set;}
        public int WeightWall{ get;set;}
        public int HeightWall{ get;set;}
        public int TallWall{ get;set;} 
        public int DefenceWall{ get;set;}

        List<IUnit> unitsList=new List<IUnit>();

        int Defence=0;
        int Capacity=0;
        int actualCapacity=0;


        private int ID;

        public DefPos(int nextID)
        {
            this.ID = nextID;
        }
        public int getID{get{ return ID;} }

        public int getDefence{get{;
                return Defence;} }

        public int getCapacity{get{;
                return Capacity;} }

        public int getActualCapacity{get{;
                return actualCapacity;} }

        public string DefPosName{ get;set;}

        public bool LoadUnit(IUnit U){
            if(!CheckCapacity())return false;
            if(getCapacity<(U.UnitAmount+actualCapacity)){
                return false;
            }
            if(U.MyDefPosition!=null){
              U.MyDefPosition.UnloadUnit(U);
            } 
            unitsList.Add(U);
            actualCapacity+=U.UnitAmount;
            U.MyDefPosition=this;

            refreshLeaders();
            return true;
        }
        public void UnloadUnit(IUnit U){
            if(unitsList.Contains(U)){
                actualCapacity-=U.UnitAmount;
                U.MyDefPosition=null;

                unitsList.Remove(U);
                refreshLeaders();
            }
        }
        public void UnloadAllUnits(){
            foreach(IUnit U in unitsList){
                U.MyDefPosition=null;
            }
            unitsList.Clear();
        }
        public bool CheckCapacity(){ 
            CalcDefenceAndCapacity();
            if(actualCapacity>Capacity){
                return false;
            }else return true;
       }
        private void refreshLeaders(){
            IUnit leaderCandidate=null;
            int maxLevel=0;
            foreach(IUnit U in unitsList){
                if(maxLevel<U.UnitLevel){
                    maxLevel=U.UnitLevel;
                    leaderCandidate=U;
                } 
            }
            if(leaderCandidate!=null){
                leaderCandidate.Leader=true;
                foreach(IUnit U in unitsList){ 
                     if(U!=leaderCandidate){
                     U.MyLeader=leaderCandidate;
                     U.Leader=false;
                     }
                }
            }
        }

        public void SetPositionStats(int W, int H, int T, int D){ 
            WeightPosition=W;
            HeightPosition=H;
            TallPosition=T;
            DefencePosition=D;
        }
        public void SetWallStats(int W, int H, int T, int D){ 
            WeightWall=W;
            HeightWall=H;
            TallWall=T;
            DefenceWall=D;
        }
        public void CalcDefenceAndCapacity(){ 
            Defence=DefencePosition+DefenceWall;
            Capacity=0;
            Capacity+=(WeightPosition*HeightPosition*TallPosition)/10;
            Capacity+=(WeightWall*HeightWall*TallWall)/10;
            actualCapacity=0;
            foreach(IUnit U in unitsList){ 
                actualCapacity+=U.UnitAmount;    
            }
        }
        public override string ToString()
        {
            return getID+"-> "+DefPosName+", "+getDefence+" | "+getActualCapacity+"/"+getCapacity;
        }
        public string ToShortString(){
            return getID+"-> "+DefPosName;
        }
        public string getLeader(){
            IUnit tmp=null;
            foreach(IUnit U in unitsList.Where(U => U.IsLeader()))tmp=U;
            if(tmp!=null)
            return tmp.ToShortString();
            else return "-";
        }
        public List<IUnit> getUnitsList(){ 
         return unitsList;    
        }
    }
}
