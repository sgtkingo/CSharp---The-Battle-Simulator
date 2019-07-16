using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleSimulator
{
    public class Land
    {
        public int HILLS=0;
        public int WATERS=0;

        public bool Enable{ get; set;}
        public int getLandIndex{ get{
            if(!Enable)return 0;
            else return (HILLS+WATERS);} 
        }

        public void SetIndex(int H, int W){
            HILLS=H;
            WATERS=W;
        }
        public override string ToString()
        {
            string txt="Ideální terén!";
            if(getLandIndex>=5)txt="Zhoršený terén...";
            if(getLandIndex>=10)txt="Nepropustný terén!";
            return getLandIndex+" | "+txt;
        }
    }
}
