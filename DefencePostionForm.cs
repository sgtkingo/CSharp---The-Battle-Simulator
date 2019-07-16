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

    public partial class DefencePostionForm : Form, IForm
    {
        
        SimulatorManager PrimalSimulator;
        TypesEnums.UnitSide Side;
        DefPos EditablePosition;
        public DefencePostionForm(SimulatorManager SM, TypesEnums.UnitSide S)
        {
            InitializeComponent();
            PrimalSimulator=SM;
            Side=S;
            
            Init();
            PrimalSimulator.ConsoleBox.WriteLineToConsole("DefencePositionForm : CREATE MODE");
        }
        public DefencePostionForm(SimulatorManager SM, TypesEnums.UnitSide S,DefPos D)
        {
            InitializeComponent();
            PrimalSimulator=SM;
            Side=S;

            num_pos_W.Value=D.WeightPosition;
            num_pos_H.Value=D.HeightPosition;
            num_pos_T.Value=D.TallPosition;
            num_pos_D.Value=D.DefencePosition;

            num_wall_W.Value=D.WeightWall;
            num_wall_H.Value=D.HeightWall;
            num_wall_T.Value=D.TallWall;
            num_wall_D.Value=D.DefenceWall;

            txt_name.Text=D.DefPosName;

            Init();
            btn_OK.Text="Edit";
            EditablePosition=D;
            PrimalSimulator.ConsoleBox.WriteLineToConsole("DefencePositionForm : EDIT MODE");
        }

        private void tb_pos_D_Scroll(object sender, EventArgs e)
        {
            this.num_pos_D.Value=this.tb_pos_D.Value;
        }

        private void tb_wall_D_Scroll(object sender, EventArgs e)
        {
            this.num_wall_D.Value=this.tb_wall_D.Value;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(!CheckData()){
              MessageBox.Show("Enter data in the order, please..");
              return;  
            }
            if(!chbox_position.Checked&&!chbox_wall.Checked){
              MessageBox.Show("Please, Enable at least one options...");
              return;  
            } 
            DefPos DF=EditablePosition;
            if(DF==null){ DF = PrimalSimulator.DefenceManager.CreateDefPos(Side); }
            DF.SetPositionStats((int)num_pos_W.Value,(int)num_pos_H.Value,(int)num_pos_T.Value,(int)num_pos_D.Value);
            DF.SetWallStats((int)num_wall_W.Value,(int)num_wall_H.Value,(int)num_wall_T.Value,(int)num_wall_D.Value);
            DF.DefPosName=txt_name.Text;
            EditablePosition=DF;
            if(DF!=null){
                if(!DF.CheckCapacity()){
                    MessageBox.Show("Out of capacity!");
                    return;
                }
            }
            //MessageBox.Show("Object was create or edit!");
            this.Close();
        }
        private void ChangeTextAuto(object sender, EventArgs e){ 
            string TmpText="-";
            if(num_pos_D.Value==0)TmpText="Enter value...";
            if(num_pos_D.Value<3)TmpText="Zřícenina..";
            if(num_pos_D.Value>=3)TmpText="S trochou štěstí to i ubráníme...";
            if(num_pos_D.Value>=6)TmpText="Hrad?";
            if(num_pos_D.Value>=9)TmpText="Pevnost!";
            this.l_position_info.Text=TmpText;
            TmpText="-";
            if(num_wall_D.Value==0)TmpText="Enter value...";
            if(num_wall_D.Value<3)TmpText="Plotek od kur?";
            if(num_wall_D.Value>=3)TmpText="Pěkný vál...Z hlíny.";
            if(num_wall_D.Value>=6)TmpText="Palisáda jedna radost!";
            if(num_wall_D.Value>=9)TmpText="Ohoo, trpasličí zeď?! ";
            this.l_wall_info.Text=TmpText;
        }
        public bool CheckData(){
            if((chbox_position.Checked)&&(num_pos_D.Value==0 || num_pos_W.Value==0 || num_pos_H.Value==0 || num_pos_T.Value==0)){ 
              PrimalSimulator.ConsoleBox.WriteLineToConsole("Data position checked ERROR!");
              return false;
            }
            if((chbox_wall.Checked)&&(num_wall_D.Value==0 || num_wall_W.Value==0 || num_wall_H.Value==0 || num_wall_T.Value==0)){ 
              PrimalSimulator.ConsoleBox.WriteLineToConsole("Data wall checked ERROR!");
              return false;
            }
            PrimalSimulator.ConsoleBox.WriteLineToConsole("Data checked!");
            return true;
        }

        private void chbox_position_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible=chbox_position.Checked;
        }

        private void chbox_wall_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible=chbox_wall.Checked;
        }

        public void Init()
        {
            tb_pos_D.Scroll+=ChangeTextAuto;
            tb_wall_D.Scroll+=ChangeTextAuto;
            num_pos_D.ReadOnly=true;
            num_wall_D.ReadOnly=true;
            EditablePosition=null;
        }
    }
}
