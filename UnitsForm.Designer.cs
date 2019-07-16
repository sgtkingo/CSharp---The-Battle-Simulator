namespace TheBattleSimulator
{
    partial class UnitsForm
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
            this.l_unittype = new System.Windows.Forms.Label();
            this.gb_base = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_level = new System.Windows.Forms.NumericUpDown();
            this.num_move = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.num_inc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_def = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.num_atc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_horse = new System.Windows.Forms.GroupBox();
            this.num_horselife = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.num_horsemove = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.num_horsedef = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.num_range = new System.Windows.Forms.NumericUpDown();
            this.gb_archer = new System.Windows.Forms.GroupBox();
            this.gb_pos = new System.Windows.Forms.GroupBox();
            this.l_leader = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_addpos = new System.Windows.Forms.Button();
            this.l_position = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chbox_hold = new System.Windows.Forms.CheckBox();
            this.gb_stats = new System.Windows.Forms.GroupBox();
            this.num_amount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.num_life = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gb_base.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_inc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_def)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_atc)).BeginInit();
            this.gb_horse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_horselife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_horsemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_horsedef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_range)).BeginInit();
            this.gb_archer.SuspendLayout();
            this.gb_pos.SuspendLayout();
            this.gb_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_life)).BeginInit();
            this.SuspendLayout();
            // 
            // l_unittype
            // 
            this.l_unittype.AutoSize = true;
            this.l_unittype.Location = new System.Drawing.Point(203, 9);
            this.l_unittype.Name = "l_unittype";
            this.l_unittype.Size = new System.Drawing.Size(10, 13);
            this.l_unittype.TabIndex = 0;
            this.l_unittype.Text = "-";
            // 
            // gb_base
            // 
            this.gb_base.Controls.Add(this.label3);
            this.gb_base.Controls.Add(this.num_level);
            this.gb_base.Controls.Add(this.num_move);
            this.gb_base.Controls.Add(this.label5);
            this.gb_base.Controls.Add(this.num_inc);
            this.gb_base.Controls.Add(this.label4);
            this.gb_base.Controls.Add(this.num_def);
            this.gb_base.Controls.Add(this.label2);
            this.gb_base.Controls.Add(this.num_atc);
            this.gb_base.Controls.Add(this.label1);
            this.gb_base.Location = new System.Drawing.Point(12, 25);
            this.gb_base.Name = "gb_base";
            this.gb_base.Size = new System.Drawing.Size(201, 176);
            this.gb_base.TabIndex = 1;
            this.gb_base.TabStop = false;
            this.gb_base.Text = "Base Stats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Level:";
            // 
            // num_level
            // 
            this.num_level.Location = new System.Drawing.Point(62, 135);
            this.num_level.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.num_level.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_level.Name = "num_level";
            this.num_level.Size = new System.Drawing.Size(120, 20);
            this.num_level.TabIndex = 10;
            this.num_level.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_move
            // 
            this.num_move.Location = new System.Drawing.Point(62, 109);
            this.num_move.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_move.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.num_move.Name = "num_move";
            this.num_move.Size = new System.Drawing.Size(120, 20);
            this.num_move.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Move:";
            // 
            // num_inc
            // 
            this.num_inc.Location = new System.Drawing.Point(62, 83);
            this.num_inc.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.num_inc.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            -2147483648});
            this.num_inc.Name = "num_inc";
            this.num_inc.Size = new System.Drawing.Size(120, 20);
            this.num_inc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inc:";
            // 
            // num_def
            // 
            this.num_def.Location = new System.Drawing.Point(62, 57);
            this.num_def.Name = "num_def";
            this.num_def.Size = new System.Drawing.Size(120, 20);
            this.num_def.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Defence: ";
            // 
            // num_atc
            // 
            this.num_atc.Location = new System.Drawing.Point(62, 31);
            this.num_atc.Name = "num_atc";
            this.num_atc.Size = new System.Drawing.Size(120, 20);
            this.num_atc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atack: ";
            // 
            // gb_horse
            // 
            this.gb_horse.Controls.Add(this.num_horselife);
            this.gb_horse.Controls.Add(this.label6);
            this.gb_horse.Controls.Add(this.num_horsemove);
            this.gb_horse.Controls.Add(this.label7);
            this.gb_horse.Controls.Add(this.num_horsedef);
            this.gb_horse.Controls.Add(this.label8);
            this.gb_horse.Location = new System.Drawing.Point(219, 25);
            this.gb_horse.Name = "gb_horse";
            this.gb_horse.Size = new System.Drawing.Size(222, 113);
            this.gb_horse.TabIndex = 10;
            this.gb_horse.TabStop = false;
            this.gb_horse.Text = "Horse Stats";
            // 
            // num_horselife
            // 
            this.num_horselife.Location = new System.Drawing.Point(81, 83);
            this.num_horselife.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_horselife.Name = "num_horselife";
            this.num_horselife.Size = new System.Drawing.Size(120, 20);
            this.num_horselife.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Horse life:";
            // 
            // num_horsemove
            // 
            this.num_horsemove.Location = new System.Drawing.Point(81, 57);
            this.num_horsemove.Name = "num_horsemove";
            this.num_horsemove.Size = new System.Drawing.Size(120, 20);
            this.num_horsemove.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Horse move:";
            // 
            // num_horsedef
            // 
            this.num_horsedef.Location = new System.Drawing.Point(81, 31);
            this.num_horsedef.Name = "num_horsedef";
            this.num_horsedef.Size = new System.Drawing.Size(120, 20);
            this.num_horsedef.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Horse defence:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Range:";
            // 
            // num_range
            // 
            this.num_range.Location = new System.Drawing.Point(62, 31);
            this.num_range.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_range.Name = "num_range";
            this.num_range.Size = new System.Drawing.Size(120, 20);
            this.num_range.TabIndex = 1;
            // 
            // gb_archer
            // 
            this.gb_archer.Controls.Add(this.num_range);
            this.gb_archer.Controls.Add(this.label11);
            this.gb_archer.Location = new System.Drawing.Point(219, 144);
            this.gb_archer.Name = "gb_archer";
            this.gb_archer.Size = new System.Drawing.Size(222, 57);
            this.gb_archer.TabIndex = 8;
            this.gb_archer.TabStop = false;
            this.gb_archer.Text = "Archer Stats";
            // 
            // gb_pos
            // 
            this.gb_pos.Controls.Add(this.l_leader);
            this.gb_pos.Controls.Add(this.label13);
            this.gb_pos.Controls.Add(this.btn_addpos);
            this.gb_pos.Controls.Add(this.l_position);
            this.gb_pos.Controls.Add(this.label9);
            this.gb_pos.Controls.Add(this.chbox_hold);
            this.gb_pos.Location = new System.Drawing.Point(12, 215);
            this.gb_pos.Name = "gb_pos";
            this.gb_pos.Size = new System.Drawing.Size(194, 111);
            this.gb_pos.TabIndex = 11;
            this.gb_pos.TabStop = false;
            this.gb_pos.Text = "Defence Postion";
            // 
            // l_leader
            // 
            this.l_leader.AutoSize = true;
            this.l_leader.Location = new System.Drawing.Point(19, 78);
            this.l_leader.Name = "l_leader";
            this.l_leader.Size = new System.Drawing.Size(10, 13);
            this.l_leader.TabIndex = 5;
            this.l_leader.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Leader:";
            // 
            // btn_addpos
            // 
            this.btn_addpos.Location = new System.Drawing.Point(126, 19);
            this.btn_addpos.Name = "btn_addpos";
            this.btn_addpos.Size = new System.Drawing.Size(62, 50);
            this.btn_addpos.TabIndex = 3;
            this.btn_addpos.Text = "CHANGE";
            this.btn_addpos.UseVisualStyleBackColor = true;
            this.btn_addpos.Click += new System.EventHandler(this.btn_addpos_Click);
            // 
            // l_position
            // 
            this.l_position.AutoSize = true;
            this.l_position.Location = new System.Drawing.Point(19, 44);
            this.l_position.Name = "l_position";
            this.l_position.Size = new System.Drawing.Size(10, 13);
            this.l_position.TabIndex = 2;
            this.l_position.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Actual Position:";
            // 
            // chbox_hold
            // 
            this.chbox_hold.AutoSize = true;
            this.chbox_hold.Location = new System.Drawing.Point(134, 0);
            this.chbox_hold.Name = "chbox_hold";
            this.chbox_hold.Size = new System.Drawing.Size(54, 17);
            this.chbox_hold.TabIndex = 0;
            this.chbox_hold.Text = "Hold?";
            this.chbox_hold.UseVisualStyleBackColor = true;
            // 
            // gb_stats
            // 
            this.gb_stats.Controls.Add(this.num_amount);
            this.gb_stats.Controls.Add(this.label12);
            this.gb_stats.Controls.Add(this.num_life);
            this.gb_stats.Controls.Add(this.label10);
            this.gb_stats.Location = new System.Drawing.Point(222, 215);
            this.gb_stats.Name = "gb_stats";
            this.gb_stats.Size = new System.Drawing.Size(222, 91);
            this.gb_stats.TabIndex = 9;
            this.gb_stats.TabStop = false;
            this.gb_stats.Text = "Stats:";
            // 
            // num_amount
            // 
            this.num_amount.Location = new System.Drawing.Point(62, 57);
            this.num_amount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_amount.Name = "num_amount";
            this.num_amount.Size = new System.Drawing.Size(120, 20);
            this.num_amount.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Amount:";
            // 
            // num_life
            // 
            this.num_life.Location = new System.Drawing.Point(62, 31);
            this.num_life.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_life.Name = "num_life";
            this.num_life.Size = new System.Drawing.Size(120, 20);
            this.num_life.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Life:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(253, 312);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(185, 46);
            this.btn_ok.TabIndex = 12;
            this.btn_ok.Text = "Create Unit";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(69, 332);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(137, 20);
            this.txt_name.TabIndex = 13;
            this.txt_name.Text = "-bezejmenný-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Name:";
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 361);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.gb_stats);
            this.Controls.Add(this.gb_pos);
            this.Controls.Add(this.gb_archer);
            this.Controls.Add(this.gb_horse);
            this.Controls.Add(this.gb_base);
            this.Controls.Add(this.l_unittype);
            this.Name = "UnitsForm";
            this.Text = "UnitsForm";
            this.gb_base.ResumeLayout(false);
            this.gb_base.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_inc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_def)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_atc)).EndInit();
            this.gb_horse.ResumeLayout(false);
            this.gb_horse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_horselife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_horsemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_horsedef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_range)).EndInit();
            this.gb_archer.ResumeLayout(false);
            this.gb_archer.PerformLayout();
            this.gb_pos.ResumeLayout(false);
            this.gb_pos.PerformLayout();
            this.gb_stats.ResumeLayout(false);
            this.gb_stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_life)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_unittype;
        private System.Windows.Forms.GroupBox gb_base;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_level;
        private System.Windows.Forms.NumericUpDown num_move;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_inc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_def;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_atc;
        private System.Windows.Forms.GroupBox gb_horse;
        private System.Windows.Forms.NumericUpDown num_horselife;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_horsemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_horsedef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown num_range;
        private System.Windows.Forms.GroupBox gb_archer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_addpos;
        private System.Windows.Forms.Label l_position;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbox_hold;
        private System.Windows.Forms.GroupBox gb_stats;
        private System.Windows.Forms.NumericUpDown num_amount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown num_life;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox gb_pos;
        private System.Windows.Forms.Label l_leader;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label14;
    }
}