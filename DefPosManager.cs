using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleSimulator
{
    public class DefPosManager
    {
        ConsoleBox ConsoleBox;
        List<DefPos> AllyDefPosts;
        List<DefPos> EnemyDefPosts;

        int LastID=0;
        int NextID{ get{ 
         return LastID++;
        }}

        public DefPosManager(ConsoleBox CB){ 
            ConsoleBox=CB;
            AllyDefPosts= new List<DefPos>();
            EnemyDefPosts= new List<DefPos>();
            ConsoleBox.WriteLineToConsole("Defence Position Manager READY!");
        }
        public DefPos CreateDefPos(TypesEnums.UnitSide S){
            DefPos D=new DefPos(NextID);

            if(S==TypesEnums.UnitSide.Ally){ 
              AllyDefPosts.Add(D);
              ConsoleBox.WriteLineToConsole("New ALLY DefencePosition CREATE!");
            } 
            else {EnemyDefPosts.Add(D);
            ConsoleBox.WriteLineToConsole("New ENEMY DefencePosition CREATE!"); 
            }
            return D;
        }

        public void RemoveItem(DefPos D){
            if(AllyDefPosts.Contains(D))AllyDefPosts.Remove(D);
            if(EnemyDefPosts.Contains(D))EnemyDefPosts.Remove(D);
            D.UnloadAllUnits();
            ConsoleBox.WriteLineToConsole("Item "+D.ToString()+" removed...");
        }

        public List<DefPos> getDefPosList(TypesEnums.UnitSide S){
            if(S==TypesEnums.UnitSide.Ally)return AllyDefPosts;
            else return EnemyDefPosts;
        }
        public void refresh(){ 
            foreach(DefPos D in AllyDefPosts){ 
            D.CalcDefenceAndCapacity();    
            }
            foreach(DefPos D in EnemyDefPosts){ 
            D.CalcDefenceAndCapacity();    
            }
        }

        public void WriteAllDefposToConsole(ConsoleBox CB){
            CB.WriteLineToConsole("\t\t ALLY DEFENCE POSITION",ConsoleBox.LineType.Bold);
            foreach(DefPos D in AllyDefPosts){
                CB.WriteLineToConsole(D.ToString(),ConsoleBox.LineType.Star);
                foreach(IUnit U in D.getUnitsList()){ 
                    CB.WriteLineToConsole(U.ToLongString());    
                }    
            }
            CB.WriteLineToConsole("\t\t ENEMY DEFENCE POSITION",ConsoleBox.LineType.Bold);
            foreach(DefPos D in EnemyDefPosts){
                CB.WriteLineToConsole(D.ToString(),ConsoleBox.LineType.Star);
                foreach(IUnit U in D.getUnitsList()){ 
                    CB.WriteLineToConsole(U.ToLongString());    
                }    
            }
        }
        public string WriteAllDefposAsString(){
            string data="";
            data+="***ALLY DEFPOS*** \n";
            foreach(DefPos D in AllyDefPosts){
                data+=D.ToString()+"\n";
                foreach(IUnit U in D.getUnitsList()){ 
                    data+=U.ToLongString()+"\n";  
                }    
            }
            data+="***ENEMY DEFPOS*** \n";
            foreach(DefPos D in EnemyDefPosts){
                data+=D.ToString()+"\n";
                foreach(IUnit U in D.getUnitsList()){ 
                     data+=U.ToLongString()+"\n";    
                }    
            }
            return data;
        }
    }
}
