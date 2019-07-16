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
    public partial class SimulatorForm : Form
    {
        SimulatorManager PrimalSimulator;

        public SimulatorForm(SimulatorManager SM)
        {
            InitializeComponent();

            PrimalSimulator=SM;
            PrimalSimulator.SimulatorConsoleBox=new ConsoleBox(rbt_siminfo);
            PrimalSimulator.DefenceManager.WriteAllDefposToConsole(PrimalSimulator.SimulatorConsoleBox);
            PrimalSimulator.ProgressBar=processBar;
            PrimalSimulator.OnSimulationDone+=Result;

            num_battles.Value=100;
            num_luck.Value=6;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            PrimalSimulator.CancelSimulation=true;
            this.Close();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            l_process.Text="Simulation IN PROCESS";
            if(ckbtn_detail.Checked && num_battles.Value>100){ 
                MessageBox.Show("Warning: You can show detail only if number of battles is eq/lower that 100...");
                ckbtn_detail.Checked=false;
            }
            PrimalSimulator.ShowDetail=ckbtn_detail.Checked;
            if(PrimalSimulator.StartSimulation((int)num_battles.Value,(int)num_luck.Value)){ 
                l_process.Text="Simulation DONE";
            }else {
                l_process.Text="Simulation CANCEL";
            }
        }
        private void Result(){
            if(chbtn_file.Checked){ 
                PrimalSimulator.SaveResultToFile(txt_filename.Text);
            }

            string winner="";
            if(PrimalSimulator.Winner)winner="ALLY";
            else winner="ENEMY";
            MessageBox.Show("WINNER IS "+winner);
        }
    }
}
