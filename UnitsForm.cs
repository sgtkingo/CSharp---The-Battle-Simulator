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
    public partial class UnitsForm : Form, IForm
    {
        SimulatorManager PrimalSimulator;
        TypesEnums.UnitSide Side;
        TypesEnums.UnitType Type;
        IUnit EditableUnit;
        DefPos SelectDefPos;

        public UnitsForm(SimulatorManager SM, TypesEnums.UnitSide S,TypesEnums.UnitType T){ 
            InitializeComponent();
            PrimalSimulator=SM;
            Side=S;
            Type=T;
            Init();
            PrimalSimulator.ConsoleBox.WriteLineToConsole("UnitForm READY! Mode: CREATE");
        }
        public UnitsForm(SimulatorManager SM, TypesEnums.UnitSide S,IUnit U){ 
            InitializeComponent();
            PrimalSimulator=SM;
            Side=S;
            Type=(TypesEnums.UnitType)U.UnitType;
            Init();
            EditableUnit=U;
            SelectDefPos=U.MyDefPosition;
            if(SelectDefPos!=null){ 
                l_position.Text=SelectDefPos.ToShortString();
                l_leader.Text=SelectDefPos.getLeader();
                chbox_hold.Checked=true;
            }
            txt_name.Text=U.UnitName;
            PrimalSimulator.ConsoleBox.WriteLineToConsole("UnitForm READY! Mode: EDIT");
            btn_ok.Text="Edit unit";
        }
        public UnitsForm()
        {
            InitializeComponent();
        }
        public void Init(){
            string txt="";
            if(Type==TypesEnums.UnitType.Infantry){ 
                txt=TypesEnums.InfTxt;
                gb_horse.Visible=false;
                gb_archer.Visible=false;
            } 
            if(Type==TypesEnums.UnitType.Cavalerly){
                txt=TypesEnums.CavTxt;
                gb_archer.Visible=false;
            } 
            if(Type==TypesEnums.UnitType.Archers){ 
                txt=TypesEnums.ArcherTxt;
                gb_horse.Visible=false;
            } 
            l_unittype.Text=txt;
            EditableUnit=null;
        }
        public bool CheckData()
        {
            if((num_life.Value==0)||(num_amount.Value==0)){
                MessageBox.Show("Unit Life and Amount must be higher that 0...");
                return false;
            } 
            else return true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(!CheckData()){
                return;
            }
            IUnit U=EditableUnit;
            if(U==null){U=PrimalSimulator.UnitManager.CreateUnit(Side,Type);}
                   if(Type==TypesEnums.UnitType.Infantry)
                   U.SetStats((int)num_atc.Value,(int)num_def.Value,(int)num_life.Value,(int)num_move.Value,(int)num_inc.Value,(int)num_level.Value);
                   if(Type==TypesEnums.UnitType.Cavalerly)
                   U.SetStats((int)num_atc.Value,(int)num_def.Value,(int)num_life.Value,(int)num_move.Value,(int)num_inc.Value,(int)num_level.Value,(int)num_horsedef.Value,(int)num_horselife.Value,(int)num_horsemove.Value);
                   if(Type==TypesEnums.UnitType.Archers)
                   U.SetStats((int)num_atc.Value,(int)num_def.Value,(int)num_life.Value,(int)num_move.Value,(int)num_inc.Value,(int)num_level.Value,(int)num_range.Value);
                   U.UnitAmount=(int)num_amount.Value;
                   U.UnitName=txt_name.Text;
            EditableUnit=U;
            if(SelectDefPos!=null){
            if(chbox_hold.Checked)
                    if(!SelectDefPos.LoadUnit(U)){
                        MessageBox.Show("Position is out of capacity!");
                        return;
                    }else MessageBox.Show("Position hold...");
            else {
                if(U.MyDefPosition!=null){
                    U.MyDefPosition.UnloadUnit(U);
                }
            }
            }
            //MessageBox.Show("Object was create or edit!");
            this.Close();
        }

        private void btn_addpos_Click(object sender, EventArgs e)
        {
            AddDefPosForm addDefPosForm=new AddDefPosForm(PrimalSimulator,Side);
            addDefPosForm.Show();
            addDefPosForm.FormClosed +=(senderr, ee) =>{ 
                if(PrimalSimulator.tempDefPos!=null){ 
                    SelectDefPos=PrimalSimulator.tempDefPos;
                    l_position.Text=SelectDefPos.ToShortString();
                    l_leader.Text=SelectDefPos.getLeader();
                    PrimalSimulator.tempDefPos=null;
                }
            };
        }
    }
}
