namespace TheBattleSimulator
{
    partial class ListUnitForm
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
            this.listBox_units = new System.Windows.Forms.ListBox();
            this.l1 = new System.Windows.Forms.Label();
            this.unitInfo_box = new System.Windows.Forms.RichTextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.num_amount = new System.Windows.Forms.NumericUpDown();
            this.l3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.gb_pos = new System.Windows.Forms.GroupBox();
            this.l_leader = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_addpos = new System.Windows.Forms.Button();
            this.l_position = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chbox_hold = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).BeginInit();
            this.gb_pos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_units
            // 
            this.listBox_units.FormattingEnabled = true;
            this.listBox_units.Location = new System.Drawing.Point(12, 18);
            this.listBox_units.Name = "listBox_units";
            this.listBox_units.Size = new System.Drawing.Size(321, 303);
            this.listBox_units.TabIndex = 0;
            this.listBox_units.SelectedIndexChanged += new System.EventHandler(this.listBox_units_SelectedIndexChanged);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(12, 2);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(60, 13);
            this.l1.TabIndex = 1;
            this.l1.Text = "Select unit:";
            // 
            // unitInfo_box
            // 
            this.unitInfo_box.Location = new System.Drawing.Point(357, 18);
            this.unitInfo_box.Name = "unitInfo_box";
            this.unitInfo_box.Size = new System.Drawing.Size(282, 303);
            this.unitInfo_box.TabIndex = 2;
            this.unitInfo_box.Text = "";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(354, 2);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(50, 13);
            this.l2.TabIndex = 3;
            this.l2.Text = "Unit Info:";
            // 
            // num_amount
            // 
            this.num_amount.Location = new System.Drawing.Point(406, 346);
            this.num_amount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_amount.Name = "num_amount";
            this.num_amount.Size = new System.Drawing.Size(168, 20);
            this.num_amount.TabIndex = 4;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(354, 346);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(46, 13);
            this.l3.TabIndex = 5;
            this.l3.Text = "Amount:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(357, 375);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(217, 43);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD UNIT";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gb_pos
            // 
            this.gb_pos.Controls.Add(this.l_leader);
            this.gb_pos.Controls.Add(this.label13);
            this.gb_pos.Controls.Add(this.btn_addpos);
            this.gb_pos.Controls.Add(this.l_position);
            this.gb_pos.Controls.Add(this.label9);
            this.gb_pos.Controls.Add(this.chbox_hold);
            this.gb_pos.Location = new System.Drawing.Point(95, 327);
            this.gb_pos.Name = "gb_pos";
            this.gb_pos.Size = new System.Drawing.Size(194, 111);
            this.gb_pos.TabIndex = 12;
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
            // ListUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.gb_pos);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.num_amount);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.unitInfo_box);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.listBox_units);
            this.Name = "ListUnitForm";
            this.Text = "ListUnitForm";
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).EndInit();
            this.gb_pos.ResumeLayout(false);
            this.gb_pos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_units;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.RichTextBox unitInfo_box;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.NumericUpDown num_amount;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox gb_pos;
        private System.Windows.Forms.Label l_leader;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_addpos;
        private System.Windows.Forms.Label l_position;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbox_hold;
    }
}