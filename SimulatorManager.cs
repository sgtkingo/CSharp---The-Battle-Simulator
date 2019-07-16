using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBattleSimulator
{
    public class SimulatorManager
    {
        public UnitsManager UnitManager{ get;}
        public DefPosManager DefenceManager{ get;}
        public LandManager LandManager{ get;}

        public CheckedListBox DefenceBoxA{ get{ return DefPosBoxA;} }
        public CheckedListBox UnitBoxA{ get{ return UnitsBoxA;} }
        public CheckedListBox DefenceBoxE{ get{ return DefPosBoxE;} }
        public CheckedListBox UnitBoxE{ get{ return UnitsBoxE;} }

        List<Battle> MyBattleList=new List<Battle>();
        int BattleCounter;
        int processbarModulo=1;
        int processbarIndex=1;

        public DefPos tempDefPos { get; set;}

        private CheckedListBox DefPosBoxA;
        private CheckedListBox UnitsBoxA;
        private CheckedListBox DefPosBoxE;
        private CheckedListBox UnitsBoxE;

        public ConsoleBox ConsoleBox;

        
        public delegate void SimulationDoneEventDelegate();
        public event SimulationDoneEventDelegate OnSimulationDone;

        public ConsoleBox SimulatorConsoleBox{ get;set;}
        public System.Windows.Forms.ProgressBar ProgressBar { get;set;}
        public bool CancelSimulation{ get;set;}
        public bool ShowDetail{ get;set;}
        public bool Winner{ get;set;}

        public SimulatorManager(ConsoleBox CB, CheckedListBox DBA, CheckedListBox UBA,CheckedListBox DBB, CheckedListBox UBB){
            ConsoleBox=CB;
            DefPosBoxA=DBA;
            UnitsBoxA=UBA;
            DefPosBoxE=DBB;
            UnitsBoxE=UBB;

            LandManager=new LandManager(ConsoleBox);
            UnitManager=new UnitsManager(ConsoleBox,LandManager);
            DefenceManager=new DefPosManager(ConsoleBox);

            OnSimulationDone+=ProcessResult;

            ConsoleBox.WriteLineToConsole("Simulator Manager READY!");
            ConsoleBox.WriteLineToConsole("SYSTEM READY!",ConsoleBox.LineType.Bold);
        }
        public void refreshAll(){
            UnitManager.refresh();
            DefenceManager.refresh();

            UnitBoxA.Items.Clear();
            foreach(IUnit U in UnitManager.getUnitsList(TypesEnums.UnitSide.Ally)){ 
                UnitsBoxA.Items.Add(U);
            }
            UnitBoxE.Items.Clear();
            foreach(IUnit U in UnitManager.getUnitsList(TypesEnums.UnitSide.Enemy)){ 
                UnitsBoxE.Items.Add(U);
            }

            DefenceBoxA.Items.Clear();
            foreach(DefPos D in DefenceManager.getDefPosList(TypesEnums.UnitSide.Ally)){ 
                DefenceBoxA.Items.Add(D);
            }
            DefenceBoxE.Items.Clear();
            foreach(DefPos D in DefenceManager.getDefPosList(TypesEnums.UnitSide.Enemy)){ 
                DefenceBoxE.Items.Add(D);
           }
        }
        public bool CheckBattlesResult(){
            foreach(Battle B in MyBattleList){ 
                if(!B.Done)return false;
            }
            return true;
        }
        public bool StartSimulation(int N, int luck){ 
            CancelSimulation=false;
            ProgressBar.Value=BattleCounter=0;
            processbarModulo=1;
            processbarIndex=1;

            if(N>100)processbarModulo=N/100;
            if(N<100)processbarIndex=100/N;

            MyBattleList.Clear();

            SimulatorConsoleBox.WriteLineToConsole("Prepare units...and...FIGHT!",ConsoleBox.LineType.Star);
            for(int i=0; i<N; i++){
                Battle battle=new Battle(this,luck,i);
                MyBattleList.Add(battle);
                Thread t = new Thread(new ThreadStart(battle.SimulateBattle));
                t.Start();

                if(CancelSimulation){
                  SimulatorConsoleBox.WriteLineToConsole("SIMULATOR DETECT ERROR OR STOP!",ConsoleBox.LineType.Star);
                  return false;  
                }
                if(i%4==0)t.Join();
                if(i%processbarModulo==0 && ProgressBar.Value<100)ProgressBar.Value+=processbarIndex;
                Thread.Sleep(1);
            }
            SimulatorConsoleBox.WriteLineToConsole("End...",ConsoleBox.LineType.Star);
            while(!CheckBattlesResult())Thread.Sleep(1);

            OnSimulationDone();
            return true;
        }
        public void ProcessResult(){
            
            int AW=0, EW=0;
            double AverageBalance=0;
            int BestShot=0;
            int Counter=0;
            SimulatorConsoleBox.WriteLineToConsole("Search for body...",ConsoleBox.LineType.Star);
            foreach(Battle B in MyBattleList.Where(B => B.Done)) { 
                if(B.Winner)AW++;
                else EW++;
                AverageBalance+=B.Balance;
                if(B.BestShot>BestShot)BestShot=B.BestShot;
                Counter++;
                if(ShowDetail){ 
                    SimulatorConsoleBox.WriteLineToConsole(B.ID+"-> "+B.AllyBattlePower+" VS "+B.EnemyBattlePower+" ("+B.Balance+")"+" >"+B.AllyLuck+" VS "+B.EnemyLuck+"<",ConsoleBox.LineType.Bold);
                } 
            }
            AverageBalance/=Counter;

            WriteResult(AW,EW,AverageBalance,BestShot);
            
        }
        public void WriteResult(int AW, int EW, double AvgBalance, int BestShot){
            SimulatorConsoleBox.WriteLineToConsole(("Ally wins "+AW+" , enemy wins: "+EW+" -> total balance: "+AvgBalance),ConsoleBox.LineType.Bold);
            SimulatorConsoleBox.WriteLineToConsole(("Best Shot: "+BestShot),ConsoleBox.LineType.Bold);
            if(AW>EW){ 
                Winner=true;
                SimulatorConsoleBox.WriteLineToConsole("\t\tWINNER: ALLY",ConsoleBox.LineType.Bold);
                SimulatorConsoleBox.WriteLineToConsole("\t\t\tLOSSES:",ConsoleBox.LineType.Bold);
                foreach(IUnit U in UnitManager.getUnitsList(TypesEnums.UnitSide.Ally)){
                    int tmp=U.UnitAmount;
                    U.UnitAmount-=(int)((double)U.UnitAmount*AvgBalance);
                    SimulatorConsoleBox.WriteLineToConsole("-"+(tmp-U.UnitAmount)+" -> "+U.ToLongString()+"/"+tmp,ConsoleBox.LineType.Star);
                    U.UnitAmount=tmp;
                }
            }else { 
                Winner=false;
                SimulatorConsoleBox.WriteLineToConsole("\t\tWINNER: ENEMY",ConsoleBox.LineType.Bold);
                SimulatorConsoleBox.WriteLineToConsole("\t\t\tLOSSES:",ConsoleBox.LineType.Bold);
                foreach(IUnit U in UnitManager.getUnitsList(TypesEnums.UnitSide.Enemy)){
                    int tmp=U.UnitAmount;
                    U.UnitAmount-=(int)((double)U.UnitAmount*AvgBalance);
                    SimulatorConsoleBox.WriteLineToConsole("-"+(tmp-U.UnitAmount)+" -> "+U.ToLongString()+"/"+tmp,ConsoleBox.LineType.Star);
                    U.UnitAmount=tmp;
                }
            }
        }
        public void SaveResultToFile(string nf){
            SimulatorConsoleBox.SaveToFile(nf+".txt");        
        }
    }
}
