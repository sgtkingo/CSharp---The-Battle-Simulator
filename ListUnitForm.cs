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
    public partial class ListUnitForm : Form
    {
        SimulatorManager PrimalManager;
        TypesEnums.UnitSide Side;
        UnitPrototype SelectedUnit=null;
        IUnit U=null;
        DefPos SelectDefPos=null;
        public ListUnitForm(SimulatorManager PM, TypesEnums.UnitSide S)
        {
            PrimalManager=PM;
            Side=S;

            InitializeComponent();
            unitInfo_box.ReadOnly=true;

            LoadData();
        }
        private void LoadData(){
            listBox_units.Items.Clear();
            foreach(UnitPrototype U in PrimalManager.UnitManager.getPrototypeUnitsList()){ 
                listBox_units.Items.Add(U);    
            }    
        }

        private void listBox_units_SelectedIndexChanged(object sender, EventArgs e)
        {
             SelectedUnit=(UnitPrototype)listBox_units.SelectedItem;
             unitInfo_box.Text=SelectedUnit.getUnitInfo();
        }

        private void btn_addpos_Click(object sender, EventArgs e)
        {
            AddDefPosForm addDefPosForm=new AddDefPosForm(PrimalManager,Side);
            addDefPosForm.Show();
            addDefPosForm.FormClosed +=(senderr, ee) =>{ 
                if(PrimalManager.tempDefPos!=null){ 
                    SelectDefPos=PrimalManager.tempDefPos;
                    l_position.Text=SelectDefPos.ToShortString();
                    l_leader.Text=SelectDefPos.getLeader();
                    PrimalManager.tempDefPos=null;
                }
            };
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(SelectedUnit==null || num_amount.Value==0)return;
            if(U==null)U=PrimalManager.UnitManager.CreateUnit(Side,SelectedUnit.Type);
            if(U.UnitType==(int)TypesEnums.UnitType.Infantry){ 
                U.SetStats(SelectedUnit.ATACK,SelectedUnit.DEF,SelectedUnit.LIFE,SelectedUnit.MOV,SelectedUnit.INC,SelectedUnit.LEVEL);
            }
            if(U.UnitType==(int)TypesEnums.UnitType.Cavalerly){ 
                U.SetStats(SelectedUnit.ATACK,SelectedUnit.DEF,SelectedUnit.LIFE,SelectedUnit.MOV,SelectedUnit.INC,SelectedUnit.LEVEL,SelectedUnit.DEF_HORSE,SelectedUnit.LIFE_HORSE,SelectedUnit.MOV_HORSE);
            }
            if(U.UnitType==(int)TypesEnums.UnitType.Archers){ 
                U.SetStats(SelectedUnit.ATACK,SelectedUnit.DEF,SelectedUnit.LIFE,SelectedUnit.MOV,SelectedUnit.INC,SelectedUnit.LEVEL,SelectedUnit.RANGE);
            }
            U.UnitAmount=(int)num_amount.Value;
            U.UnitName=SelectedUnit.UnitName;
            if(SelectDefPos!=null && chbox_hold.Checked){
                if(!SelectDefPos.LoadUnit(U)){
                    MessageBox.Show("Position is out of capacity!");
                    return;
                }else PrimalManager.ConsoleBox.WriteLineToConsole("Unit "+U.ToShortString()+" now hold position "+SelectDefPos.ToShortString());
            }
            this.Close();
        }
    }
}
