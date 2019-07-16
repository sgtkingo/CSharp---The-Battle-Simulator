namespace TheBattleSimulator
{
    partial class SimulatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulatorForm));
            this.processBar = new System.Windows.Forms.ProgressBar();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.chbtn_file = new System.Windows.Forms.CheckBox();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.ckbtn_detail = new System.Windows.Forms.CheckBox();
            this.num_luck = new System.Windows.Forms.NumericUpDown();
            this.l_process = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_battles = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rbt_siminfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_luck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_battles)).BeginInit();
            this.SuspendLayout();
            // 
            // processBar
            // 
            this.processBar.Location = new System.Drawing.Point(35, 17);
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(481, 81);
            this.processBar.Step = 1;
            this.processBar.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(325, 176);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(191, 55);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(35, 176);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(191, 55);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // chbtn_file
            // 
            this.chbtn_file.AutoSize = true;
            this.chbtn_file.Location = new System.Drawing.Point(35, 115);
            this.chbtn_file.Name = "chbtn_file";
            this.chbtn_file.Size = new System.Drawing.Size(82, 17);
            this.chbtn_file.TabIndex = 3;
            this.chbtn_file.Text = "Save to file:";
            this.chbtn_file.UseVisualStyleBackColor = true;
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(139, 113);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(120, 20);
            this.txt_filename.TabIndex = 4;
            this.txt_filename.Text = "filename";
            // 
            // ckbtn_detail
            // 
            this.ckbtn_detail.AutoSize = true;
            this.ckbtn_detail.Location = new System.Drawing.Point(35, 141);
            this.ckbtn_detail.Name = "ckbtn_detail";
            this.ckbtn_detail.Size = new System.Drawing.Size(74, 17);
            this.ckbtn_detail.TabIndex = 5;
            this.ckbtn_detail.Text = "Detail Info";
            this.ckbtn_detail.UseVisualStyleBackColor = true;
            // 
            // num_luck
            // 
            this.num_luck.Location = new System.Drawing.Point(444, 138);
            this.num_luck.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_luck.Name = "num_luck";
            this.num_luck.Size = new System.Drawing.Size(72, 20);
            this.num_luck.TabIndex = 6;
            this.num_luck.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // l_process
            // 
            this.l_process.AutoSize = true;
            this.l_process.Location = new System.Drawing.Point(221, 50);
            this.l_process.Name = "l_process";
            this.l_process.Size = new System.Drawing.Size(95, 13);
            this.l_process.TabIndex = 7;
            this.l_process.Text = "Simulation READY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of battles:";
            // 
            // num_battles
            // 
            this.num_battles.Location = new System.Drawing.Point(444, 111);
            this.num_battles.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_battles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_battles.Name = "num_battles";
            this.num_battles.Size = new System.Drawing.Size(72, 20);
            this.num_battles.TabIndex = 9;
            this.num_battles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Luck setting:";
            // 
            // rbt_siminfo
            // 
            this.rbt_siminfo.Location = new System.Drawing.Point(35, 254);
            this.rbt_siminfo.Name = "rbt_siminfo";
            this.rbt_siminfo.Size = new System.Drawing.Size(481, 172);
            this.rbt_siminfo.TabIndex = 11;
            this.rbt_siminfo.Text = "";
            // 
            // SimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 455);
            this.Controls.Add(this.rbt_siminfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_battles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_process);
            this.Controls.Add(this.num_luck);
            this.Controls.Add(this.ckbtn_detail);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.chbtn_file);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.processBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimulatorForm";
            this.Text = "SimulatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.num_luck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_battles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar processBar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.CheckBox chbtn_file;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.CheckBox ckbtn_detail;
        private System.Windows.Forms.NumericUpDown num_luck;
        private System.Windows.Forms.Label l_process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_battles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rbt_siminfo;
    }
}