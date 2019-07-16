using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleSimulator
{
    public static class TypesEnums
    {
        public enum UnitSide{ Ally, Enemy};
        public enum UnitType{ Infantry='•', Archers='X', Cavalerly='>'};

        public static string InfTxt{ get{ return "Infantry";} }
        public static string CavTxt{ get{ return "Cavarly";} }
        public static string ArcherTxt{ get{ return "Archers";} }
    }
}
