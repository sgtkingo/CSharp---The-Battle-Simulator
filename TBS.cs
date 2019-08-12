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
    public partial class TBS : Form
    {
        ConsoleBox PrimalConsole;
        SimulatorManager PrimalManager;
        public TBS()
        {
            InitializeComponent();
            PrimalConsole= new ConsoleBox(rt_console);
            PrimalManager=new SimulatorManager(PrimalConsole,a_chlw_defpos,a_chlw_units,e_chlw_defpos,e_chlw_units);
        }

        private void btn_fight_Click(object sender, EventArgs e)
        {
            SimulatorForm simulatorForm=new SimulatorForm(PrimalManager);
            simulatorForm.Show();
        }

        private void a_btn_addunit_Click(object sender, EventArgs e)
        {
            UnitsForm unitsForm=null;
            if(a_rbt_inf.Checked==true)
                unitsForm=new UnitsForm(PrimalManager,TypesEnums.UnitSide.Ally,TypesEnums.UnitType.Infantry);
            if(a_rbt_cavalerly.Checked==true)
                unitsForm=new UnitsForm(PrimalManager,TypesEnums.UnitSide.Ally,TypesEnums.UnitType.Cavalerly);
            if(a_rbt_arch.Checked==true)
                unitsForm=new UnitsForm(PrimalManager,TypesEnums.UnitSide.Ally,TypesEnums.UnitType.Archers);
            if(!(a_rbt_inf.Checked||a_rbt_cavalerly.Checked||a_rbt_arch.Checked)){
                MessageBox.Show("Please, select unit type...");
                return;
            }
            else unitsForm.Show();
            unitsForm.FormClosed += (senderr,ee) =>{
                refreshBoxes();
            };
        }

        private void a_btn_adddefpos_Click(object sender, EventArgs e)
        {
            DefencePostionForm defencePostionForm=new DefencePostionForm(PrimalManager,TypesEnums.UnitSide.Ally);
            defencePostionForm.Show();
            defencePostionForm.FormClosed += (senderr,ee) =>{
                refreshBoxes();
            };
        }

        private void a_btn_del_defpos_Click(object sender, EventArgs e)
        {
            List<DefPos> TmpMem=new List<DefPos>();
            
            foreach(DefPos D in PrimalManager.DefenceBoxA.CheckedItems){ 
                TmpMem.Add(D);
            }
            foreach(DefPos D in TmpMem){ 
                PrimalManager.DefenceManager.RemoveItem(D);
            } 
            refreshBoxes();
        }

        private void a_btn_edit_defpos_Click(object sender, EventArgs e)
        {
            DefPos D = (DefPos)PrimalManager.DefenceBoxA.SelectedItem;
            if(D==null)return;
            DefencePostionForm defencePostionForm=new DefencePostionForm(PrimalManager,TypesEnums.UnitSide.Ally,D);
            defencePostionForm.Show();
            defencePostionForm.FormClosed += (senderr,ee) =>{
                refreshBoxes();
            };
        }
        private void refreshBoxes(){
            PrimalManager.refreshAll();
            a_chlw_defpos.Refresh();
            a_chlw_units.Refresh();
            e_chlw_defpos.Refresh();
            e_chlw_units.Refresh();

            a_tf.Text=PrimalManager.UnitManager.getTotalForce(TypesEnums.UnitSide.Ally).ToString();
            a_l_totalamount.Text=PrimalManager.UnitManager.getTotalAmount(TypesEnums.UnitSide.Ally).ToString();
            e_tf.Text=PrimalManager.UnitManager.getTotalForce(TypesEnums.UnitSide.Enemy).ToString();
            e_l_totalamount.Text=PrimalManager.UnitManager.getTotalAmount(TypesEnums.UnitSide.Enemy).ToString();
        }

        private void a_btn_del_units_Click(object sender, EventArgs e)
        {
            List<IUnit> TmpMem=new List<IUnit>();
            
            foreach(IUnit U in PrimalManager.UnitBoxA.CheckedItems){ 
                TmpMem.Add(U);
            }
            foreach(IUnit U in TmpMem){ 
                PrimalManager.UnitManager.RemoveItem(U);
            }
            refreshBoxes();
        }

        private void a_btn_edit_units_Click(object sender, EventArgs e)
        {
            IUnit U = (IUnit)PrimalManager.UnitBoxA.SelectedItem;
            if(U==null)return;
            UnitsForm unitsPostionForm=new UnitsForm(PrimalManager,TypesEnums.UnitSide.Ally,U);
            unitsPostionForm.Show();
            unitsPostionForm.FormClosed += (senderr,ee) =>{
                refreshBoxes();
            };
        }

        private void btn_landsetting_Click(object sender, EventArgs e)
        {
            LandForm landForm=new LandForm(PrimalManager);
            landForm.Show();
            landForm.FormClosed += (senderr,ee) =>{ 
                refreshBoxes();
                l_landinfo.Text=PrimalManager.LandManager.ActualLandLand.ToString();
                l_weather.Text=PrimalManager.LandManager.ActualWeather.ToString();
            };
        }

        private void e_btn_adddefpos_Click(object sender, EventArgs e)
        {
            DefencePostionForm defencePostionForm=new DefencePostionForm(PrimalManager,TypesEnums.UnitSide.Enemy);
            defencePostionForm.Show();
            defencePostionForm.FormClosed += (senderr,ee) =>{
                refreshBoxes();
            };
        }

        private void e_btn_del_defpos_Click(object sender, EventArgs e)
        {
            List<DefPos> TmpMem=new List<DefPos>();
            
            foreach(DefPos D in PrimalManager.DefenceBoxE.CheckedItems){ 
                TmpMem.Add(D);
            }
            foreach(DefPos D in TmpMem){ 
                PrimalManager.DefenceManager.RemoveItem(D);
            } 
            refreshBoxes();
        }

        private void e_btn_edit_defpos_Click(object sender, EventArgs e)
        {
            DefPos D = (DefPos)PrimalManager.DefenceBoxE.SelectedItem;
            if(D==null)return;
            DefencePostionForm defencePostionForm=new DefencePostionForm(PrimalManager,TypesEnums.UnitSide.Enemy,D);
            defencePostionForm.Show();
            defencePostionForm.FormClosed += (senderr,ee) =>{
                refreshBoxes();
            };
        }

        private void e_btn_addunit_Click(object sender, EventArgs e)
        {
            UnitsForm unitsForm=null;
            if(e_rbt_inf.Checked==true)
                unitsForm=new UnitsForm(PrimalManager,TypesEnums.UnitSide.Enemy,TypesEnums.UnitType.Infantry);
            if(e_rbt_cavalerly.Checked==true)
                unitsForm=new UnitsForm(PrimalManager,TypesEnums.UnitSide.Enemy,TypesEnums.UnitType.Cavalerly);
            if(e_rbt_arch.Checked==true)
                unitsForm=new UnitsForm(PrimalManager,TypesEnums.UnitSide.Enemy,TypesEnums.UnitType.Archers);
            if(!(e_rbt_inf.Checked||e_rbt_cavalerly.Checked||e_rbt_arch.Checked)){
                MessageBox.Show("Please, select unit type...");
                return;
            }
            else unitsForm.Show();
            unitsForm.FormClosed += (senderr,ee) =>{
                refreshBoxes();
            };
        }

        private void e_btn_del_units_Click(object sender, EventArgs e)
        {
            List<IUnit> TmpMem=new List<IUnit>();
            
            foreach(IUnit U in PrimalManager.UnitBoxE.CheckedItems){ 
                TmpMem.Add(U);
            }
            foreach(IUnit U in TmpMem){ 
                PrimalManager.UnitManager.RemoveItem(U);
            }
            refreshBoxes();
        }

        private void e_btn_edit_units_Click(object sender, EventArgs e)
        {
            IUnit U = (IUnit)PrimalManager.UnitBoxE.SelectedItem;
            if(U==null)return;
            UnitsForm unitsPostionForm=new UnitsForm(PrimalManager,TypesEnums.UnitSide.Enemy,U);
            unitsPostionForm.Show();
            unitsPostionForm.FormClosed += (senderr,ee) =>{
                refreshBoxes();
            };
        }

        private void a_btn_listunit_Click(object sender, EventArgs e)
        {
            ListUnitForm listUnitForm=new ListUnitForm(PrimalManager,TypesEnums.UnitSide.Ally);
            listUnitForm.Show();
            listUnitForm.FormClosed += (senderr,ee) =>{
                refreshBoxes();
            };
        }

        private void e_btn_listunit_Click(object sender, EventArgs e)
        {
            ListUnitForm listUnitForm=new ListUnitForm(PrimalManager,TypesEnums.UnitSide.Enemy);
            listUnitForm.Show();
            listUnitForm.FormClosed += (senderr,ee) =>{
                refreshBoxes();
            };
        }
    }
}
