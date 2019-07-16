using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleSimulator
{
    public class Battle
    {
        SimulatorManager PrimalSimulator=null;

        public bool Winner{ get; set;}
        public bool Done{ get; set;}
        public int BestShot{ get; set;}
        public int ID{ get; set;}

        public int AllyBattlePower{ get;set;}
        public int EnemyBattlePower{ get;set;}
        public double Balance{ get;set;}

        Random rng=new Random(System.DateTime.Now.Millisecond);

        int LuckIndex=0;
        public int AllyLuck=0;
        public int EnemyLuck=0;

        int AllyAmount=0;
        int EnemyAmount=0;

        public Battle(SimulatorManager PM, int luck, int id){ 
            PrimalSimulator=PM;
            LuckIndex=luck;
            ID=id;
            Done=false;

            AllyAmount=PrimalSimulator.UnitManager.getTotalAmount(TypesEnums.UnitSide.Ally);
            EnemyAmount=PrimalSimulator.UnitManager.getTotalAmount(TypesEnums.UnitSide.Enemy);

        }

        public void SimulateBattle(){

            if(AllyAmount==0 || EnemyAmount==0){
                PrimalSimulator.CancelSimulation=true;
                return;
            } 
            int LuckCounter=1;
            if((AllyAmount*EnemyAmount)<1000000)LuckCounter=(AllyAmount*EnemyAmount);
            else LuckCounter=(AllyAmount+EnemyAmount);

            AllyLuck=LuckGenerator(rng.Next(LuckCounter));
            EnemyLuck=LuckGenerator(rng.Next(LuckCounter));
 
            AllyBattlePower=AllyLuck+PrimalSimulator.UnitManager.getTotalForce(TypesEnums.UnitSide.Ally);
            EnemyBattlePower=EnemyLuck+PrimalSimulator.UnitManager.getTotalForce(TypesEnums.UnitSide.Enemy);
            if(AllyBattlePower>EnemyBattlePower){
                Balance=((double)EnemyBattlePower/(double)AllyBattlePower);
                Winner=true;
            }else { 
                Balance=((double)AllyBattlePower/(double)EnemyBattlePower);
                Winner=false;
            }
            Done=true;
        }

        public int LuckGenerator(int x){
            int tmp=0, total=0;

            for(int i=0; i<x; i++){ 
                while(tmp%6==0){ 
                    tmp+=rng.Next(1,LuckIndex+1);    
                }
                if(tmp>BestShot)BestShot=tmp;
                total+=tmp;
                tmp=0;
            }
            return total;
        }

    }
}
