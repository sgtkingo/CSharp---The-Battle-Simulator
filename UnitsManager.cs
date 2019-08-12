using System;
using System.Collections.Generic;
using System.IO;
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
        List<UnitPrototype> Prototype;

        int LastID=0;
        int NextID{ get{ 
         return LastID++;
        }}

        public UnitsManager(ConsoleBox CB, LandManager LM){ 
            Ally= new List<IUnit>();
            Enemy=new List<IUnit>();
            Prototype=new List<UnitPrototype>();

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
        public List<UnitPrototype> getPrototypeUnitsList(){
             LoadUnitsFromFile();
             return Prototype;
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

        public void LoadUnitsFromFile()
        {
            string path = @"units\unitList.txt";
            UnitPrototype UT;
            Prototype.Clear();

            ConsoleBox.WriteLineToConsole("Try load units from file...");
            if (!File.Exists(path))
            {
            return;
            }
            foreach(string unitName in DecodeUnitNames(path)){
                string fileName=@"units\"+unitName+".txt";
                if (File.Exists(fileName))
                {
                    UT=DecodeUnitByName(fileName);
                    if(UT!=null){
                    Prototype.Add(UT);
                    ConsoleBox.WriteLineToConsole("Unit "+UT.UnitName+" load!");
                    }
                }else  ConsoleBox.WriteLineToConsole("Unit "+unitName+" does not exist!");     
            }
            ConsoleBox.WriteLineToConsole("LOAD COMPLETE!",ConsoleBox.LineType.Bold);
        }

        private List<string> DecodeUnitNames(string file){ 
            List<string> unitnames= new List<string>();
            
            //Open the file.
            using (FileStream fs = new FileStream(file,FileMode.Open))
            {
            fs.Seek(0,SeekOrigin.Begin);
                StreamReader sr=new StreamReader(fs);
                while(!sr.EndOfStream)
                unitnames.Add(sr.ReadLine());

                sr.Close();
                fs.Close();
            }  
            return unitnames;          
        }
        private UnitPrototype DecodeUnitByName(string file){
            UnitPrototype UT=new UnitPrototype();
            using (FileStream fs = new FileStream(file,FileMode.Open))
            {
            fs.Seek(0,SeekOrigin.Begin);
                StreamReader sr=new StreamReader(fs,Encoding.UTF8);
                while(!sr.EndOfStream)if(!RecognizeUnitData(sr.ReadLine(),UT)){ 
                    ConsoleBox.WriteLineToConsole("File "+file+" is corrupt or cant be opened!");
                    UT=null;
                    break;
                }                
                sr.Close();
                fs.Close();
            } 
            return UT;
        }
        private bool RecognizeUnitData(string data, UnitPrototype UT){
            
            string [] parseData=data.Split(new char[]{ '=' });
            if(parseData.Length>2)return false;

            if(parseData[0]=="NAME")UT.UnitName=parseData[1];
            if(parseData[0]=="INFO")UT.UnitInfo=parseData[1];
            if(parseData[0]=="TYPE"){
                string tmp=parseData[1];
                UT.Type=(TypesEnums.UnitType)tmp[0]; 
            }
            if(parseData[0]=="FORCE")UT.UnitForce=ConvertStringToInt(parseData[1]);
            if(parseData[0]=="INC")UT.INC=ConvertStringToInt(parseData[1]);
            if(parseData[0]=="MOV")UT.MOV=ConvertStringToInt(parseData[1]);
            if(parseData[0]=="LIFE")UT.LIFE=ConvertStringToInt(parseData[1]);
            if(parseData[0]=="ATACK")UT.ATACK=ConvertStringToInt(parseData[1]);
            if(parseData[0]=="DEF")UT.DEF=ConvertStringToInt(parseData[1]);
            if(parseData[0]=="LEVEL")UT.LEVEL=ConvertStringToInt(parseData[1]);
            if(UT.Type==TypesEnums.UnitType.Cavalerly){ 
                if(parseData[0]=="MOV_HORSE")UT.MOV_HORSE=ConvertStringToInt(parseData[1]);
                if(parseData[0]=="LIFE_HORSE")UT.LIFE_HORSE=ConvertStringToInt(parseData[1]);
                if(parseData[0]=="DEF_HORSE")UT.DEF_HORSE=ConvertStringToInt(parseData[1]);
            }
            if(UT.Type==TypesEnums.UnitType.Archers){ 
                if(parseData[0]=="RANGE")UT.RANGE=ConvertStringToInt(parseData[1]);
            }
            return true;
        }
        private int ConvertStringToInt(string txt){
            int result=0;
            int.TryParse(txt,out result);    
            return result;    
        }

        public void refresh(){ 
        foreach(IUnit U in Ally)U.CalcUnitPower();
        foreach(IUnit U in Enemy)U.CalcUnitPower(); 
        }
    }
}
