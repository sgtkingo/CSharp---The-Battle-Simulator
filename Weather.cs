using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleSimulator
{
    public class Weather
    {
        public int WIND=0;
        public int VISIBLY=0;
        public int RAIN=0;

        public bool Enable{ get; set;}
        public int getWeatherIndex{ get{
            if(!Enable)return 0;
            else return (WIND+VISIBLY+RAIN);} 
        }

        public void SetIndex(int V,int W, int R){
            WIND=W;
            VISIBLY=V;
            RAIN=R;
        }
        public override string ToString()
        {
            string txt="Skvělá viditelnost!";
            if(getWeatherIndex>=5)txt="Zhoršená viditelnost...";
            if(getWeatherIndex>=10)txt="Špatná viditelnost...";
            if(getWeatherIndex>=14)txt="Nulová viditelnost!";
            return getWeatherIndex+" | "+txt;
        }
    }
}
