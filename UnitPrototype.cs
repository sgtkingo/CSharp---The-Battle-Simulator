using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleSimulator
{
    public class UnitPrototype
    {
        public TypesEnums.UnitType Type;

        public string UnitName {get; set;}
        public string UnitInfo {get; set;}
        public int UnitForce {get; set;}

        public int INC=0;
        public int MOV=0;
        public int LIFE=0;
        public int ATACK=0;
        public int DEF=0;
        public int LEVEL=0;

        public int MOV_HORSE=0;
        public int LIFE_HORSE=0;
        public int DEF_HORSE=0;

        public int RANGE=0;

        public override string ToString()
        {
            return UnitName;
        }
        public string getUnitInfo(){ 
        string info="";
        info+="NAME: "+UnitName+"\n";
        info+="INFO: "+UnitInfo+"\n\n";

        info+="TYPE: "+(char)Type+"\n";
        info+="FORCE: "+UnitForce+"/10 \n\n";

        info+="ATACK: "+ATACK+"\n";
        info+="DEFENCE: "+DEF+"\n";
        info+="INC: "+INC+"\n";
        info+="MOVE: "+MOV+"\n";
        info+="LEVEL: "+LEVEL+"\n";
        info+="LIFE: "+LIFE+"\n\n";
        if(Type==TypesEnums.UnitType.Cavalerly){ 
            info+="HORSE MOVE: "+MOV_HORSE+"\n";
            info+="HORSE LIFE: "+LIFE_HORSE+"\n";
            info+="HORSE DEFENCE: "+DEF_HORSE+"\n";
        }
        if(Type==TypesEnums.UnitType.Archers){ 
            info+="RANGE: "+RANGE+"\n";
        }        
        return info;    
        }
    }
}
