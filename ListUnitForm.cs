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
    }
}
