using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBattleSimulator
{
    public partial class LandForm : Form
    {
        SimulatorManager PrimalSimulator;

        public LandForm(SimulatorManager SM)
        {
            InitializeComponent();
            PrimalSimulator=SM;

            check_enable_w.Checked=gb_weather.Visible=PrimalSimulator.LandManager.ActualWeather.Enable;
            check_enable_l.Checked=gb_land.Visible=PrimalSimulator.LandManager.ActualLandLand.Enable;

            tb_hills.ValueChanged+=(sender,e) =>{ refreshHillsText(); };
            tb_hills.Value=PrimalSimulator.LandManager.ActualLandLand.HILLS;
            tb_rain.ValueChanged+=(sender,e) =>{ refreshRainText(); };
            tb_rain.Value=PrimalSimulator.LandManager.ActualWeather.RAIN;
            tb_visible.ValueChanged+=(sender,e) =>{ refreshVisibleText(); };
            tb_visible.Value=PrimalSimulator.LandManager.ActualWeather.VISIBLY;
            tb_water.ValueChanged+=(sender,e) =>{ refreshWaterText(); };
            tb_water.Value=PrimalSimulator.LandManager.ActualLandLand.WATERS;
            tb_wind.ValueChanged+=(sender,e) =>{ refreshWindText(); };
            tb_wind.Value=PrimalSimulator.LandManager.ActualWeather.WIND;
        }
       void refreshHillsText(){
            string txt="";
            if(tb_hills.Value>=0)txt="Nekonečné louky...";
            if(tb_hills.Value>=2)txt="Pahorkatina...";
            if(tb_hills.Value>=4)txt="Velehory a skály!";
            l_hills.Text=txt;
        }
       void refreshWaterText(){
            string txt="";
            if(tb_water.Value>=0)txt="Žádné vodní plochy ani toky...";
            if(tb_water.Value>=2)txt="Řeky a potůčky...";
            if(tb_water.Value>=4)txt="Veletoky a mokřady!";
            l_water.Text=txt;
        }

        void refreshRainText(){
            string txt="";
            if(tb_rain.Value>=0)txt="Ani kapka...";
            if(tb_rain.Value>=2)txt="Déšť a mokro...";
            if(tb_rain.Value>=4)txt="Bouře a kroupy!";
            l_rain.Text=txt;
        }
        void refreshWindText(){
            string txt="";
            if(tb_wind.Value>=0)txt="Bezvětří...";
            if(tb_wind.Value>=2)txt="Vítr...";
            if(tb_wind.Value>=4)txt="Uragán a tornádo!";
            l_wind.Text=txt;
        }

        void refreshVisibleText(){
            string txt="";
            if(tb_visible.Value>=0)txt="Jasno, viditelnost skvělá.";
            if(tb_visible.Value>=2)txt="Zataženo, viditelnost nížší....";
            if(tb_visible.Value>=4)txt="Tma, viditelnost minimální...";
            l_visible.Text=txt;
        }

        private void check_enable_w_CheckedChanged(object sender, EventArgs e)
        {
            gb_weather.Visible=!gb_weather.Visible;
        }

        private void chbox_enable_l_CheckedChanged(object sender, EventArgs e)
        {
            gb_land.Visible=!gb_land.Visible;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(check_enable_w.Checked){ 
                PrimalSimulator.LandManager.ActualWeather.SetIndex(tb_visible.Value,tb_wind.Value,tb_rain.Value);
            } 
            if(check_enable_l.Checked){ 
                PrimalSimulator.LandManager.ActualLandLand.SetIndex(tb_hills.Value,tb_water.Value);
            }
            PrimalSimulator.LandManager.ActualLandLand.Enable=check_enable_l.Checked;
            PrimalSimulator.LandManager.ActualWeather.Enable=check_enable_w.Checked;
            this.Close();
        }
    }
}
