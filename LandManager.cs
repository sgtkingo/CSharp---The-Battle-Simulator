using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleSimulator
{
    public class LandManager
    {
        ConsoleBox ConsoleBox;
        public Weather ActualWeather{ get;set;}
        public Land ActualLandLand{ get;set;}

        public LandManager(ConsoleBox CB){ 
            ConsoleBox=CB;
            ActualWeather=new Weather();
            ActualWeather.Enable=true;

            ActualLandLand= new Land();
            ActualLandLand.Enable=true;

            ConsoleBox.WriteLineToConsole("Land Manager READY!");
        }
    }
}
