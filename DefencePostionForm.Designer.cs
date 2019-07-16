namespace TheBattleSimulator
{
    partial class DefencePostionForm
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
            this.components = new System.ComponentModel.Container();
            this.l_PH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_position_info = new System.Windows.Forms.Label();
            this.num_pos_T = new System.Windows.Forms.NumericUpDown();
            this.num_pos_H = new System.Windows.Forms.NumericUpDown();
            this.num_pos_W = new System.Windows.Forms.NumericUpDown();
            this.num_pos_D = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_pos_D = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.l_wall_info = new System.Windows.Forms.Label();
            this.num_wall_T = new System.Windows.Forms.NumericUpDown();
            this.num_wall_H = new System.Windows.Forms.NumericUpDown();
            this.num_wall_W = new System.Windows.Forms.NumericUpDown();
            this.num_wall_D = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_wall_D = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.chbox_wall = new System.Windows.Forms.CheckBox();
            this.chbox_position = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_pos_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pos_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pos_W)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pos_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pos_D)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_wall_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_wall_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_wall_W)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_wall_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_wall_D)).BeginInit();
            this.SuspendLayout();
            // 
            // l_PH
            // 
            this.l_PH.AutoSize = true;
            this.l_PH.Location = new System.Drawing.Point(60, 21);
            this.l_PH.Name = "l_PH";
            this.l_PH.Size = new System.Drawing.Size(112, 13);
            this.l_PH.TabIndex = 0;
            this.l_PH.Text = "Enter Position Weight:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Position Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Position Tall:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_position_info);
            this.groupBox1.Controls.Add(this.num_pos_T);
            this.groupBox1.Controls.Add(this.num_pos_H);
            this.groupBox1.Controls.Add(this.num_pos_W);
            this.groupBox1.Controls.Add(this.num_pos_D);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_pos_D);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.l_PH);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 172);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position Setting";
            // 
            // l_position_info
            // 
            this.l_position_info.AutoSize = true;
            this.l_position_info.Location = new System.Drawing.Point(207, 141);
            this.l_position_info.Name = "l_position_info";
            this.l_position_info.Size = new System.Drawing.Size(70, 13);
            this.l_position_info.TabIndex = 9;
            this.l_position_info.Text = "Enter value...";
            // 
            // num_pos_T
            // 
            this.num_pos_T.Location = new System.Drawing.Point(178, 68);
            this.num_pos_T.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_pos_T.Name = "num_pos_T";
            this.num_pos_T.Size = new System.Drawing.Size(120, 20);
            this.num_pos_T.TabIndex = 8;
            // 
            // num_pos_H
            // 
            this.num_pos_H.Location = new System.Drawing.Point(178, 42);
            this.num_pos_H.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_pos_H.Name = "num_pos_H";
            this.num_pos_H.Size = new System.Drawing.Size(120, 20);
            this.num_pos_H.TabIndex = 7;
            // 
            // num_pos_W
            // 
            this.num_pos_W.Location = new System.Drawing.Point(178, 14);
            this.num_pos_W.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_pos_W.Name = "num_pos_W";
            this.num_pos_W.Size = new System.Drawing.Size(120, 20);
            this.num_pos_W.TabIndex = 6;
            // 
            // num_pos_D
            // 
            this.num_pos_D.Location = new System.Drawing.Point(80, 139);
            this.num_pos_D.Name = "num_pos_D";
            this.num_pos_D.Size = new System.Drawing.Size(120, 20);
            this.num_pos_D.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Defence:";
            // 
            // tb_pos_D
            // 
            this.tb_pos_D.Location = new System.Drawing.Point(71, 95);
            this.tb_pos_D.Name = "tb_pos_D";
            this.tb_pos_D.Size = new System.Drawing.Size(227, 45);
            this.tb_pos_D.TabIndex = 3;
            this.tb_pos_D.Scroll += new System.EventHandler(this.tb_pos_D_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.l_wall_info);
            this.groupBox2.Controls.Add(this.num_wall_T);
            this.groupBox2.Controls.Add(this.num_wall_H);
            this.groupBox2.Controls.Add(this.num_wall_W);
            this.groupBox2.Controls.Add(this.num_wall_D);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_wall_D);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 172);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wall Setting";
            // 
            // l_wall_info
            // 
            this.l_wall_info.AutoSize = true;
            this.l_wall_info.Location = new System.Drawing.Point(206, 143);
            this.l_wall_info.Name = "l_wall_info";
            this.l_wall_info.Size = new System.Drawing.Size(70, 13);
            this.l_wall_info.TabIndex = 10;
            this.l_wall_info.Text = "Enter value...";
            // 
            // num_wall_T
            // 
            this.num_wall_T.Location = new System.Drawing.Point(178, 68);
            this.num_wall_T.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_wall_T.Name = "num_wall_T";
            this.num_wall_T.Size = new System.Drawing.Size(120, 20);
            this.num_wall_T.TabIndex = 8;
            // 
            // num_wall_H
            // 
            this.num_wall_H.Location = new System.Drawing.Point(178, 42);
            this.num_wall_H.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_wall_H.Name = "num_wall_H";
            this.num_wall_H.Size = new System.Drawing.Size(120, 20);
            this.num_wall_H.TabIndex = 7;
            // 
            // num_wall_W
            // 
            this.num_wall_W.Location = new System.Drawing.Point(178, 14);
            this.num_wall_W.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_wall_W.Name = "num_wall_W";
            this.num_wall_W.Size = new System.Drawing.Size(120, 20);
            this.num_wall_W.TabIndex = 6;
            // 
            // num_wall_D
            // 
            this.num_wall_D.Location = new System.Drawing.Point(80, 139);
            this.num_wall_D.Name = "num_wall_D";
            this.num_wall_D.Size = new System.Drawing.Size(120, 20);
            this.num_wall_D.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Defence:";
            // 
            // tb_wall_D
            // 
            this.tb_wall_D.Location = new System.Drawing.Point(71, 95);
            this.tb_wall_D.Name = "tb_wall_D";
            this.tb_wall_D.Size = new System.Drawing.Size(227, 45);
            this.tb_wall_D.TabIndex = 3;
            this.tb_wall_D.Scroll += new System.EventHandler(this.tb_wall_D_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Enter Wall Tall:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Enter Wall Height:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Enter Wall Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(100, 375);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(147, 20);
            this.txt_name.TabIndex = 11;
            this.txt_name.Text = "-bezejmenný-";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(263, 367);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(109, 35);
            this.btn_OK.TabIndex = 12;
            this.btn_OK.Text = "Create";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // chbox_wall
            // 
            this.chbox_wall.AutoSize = true;
            this.chbox_wall.Checked = true;
            this.chbox_wall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbox_wall.Location = new System.Drawing.Point(307, 181);
            this.chbox_wall.Name = "chbox_wall";
            this.chbox_wall.Size = new System.Drawing.Size(65, 17);
            this.chbox_wall.TabIndex = 11;
            this.chbox_wall.Text = "Enable?";
            this.chbox_wall.UseVisualStyleBackColor = true;
            this.chbox_wall.CheckedChanged += new System.EventHandler(this.chbox_wall_CheckedChanged);
            // 
            // chbox_position
            // 
            this.chbox_position.AutoSize = true;
            this.chbox_position.Checked = true;
            this.chbox_position.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbox_position.Location = new System.Drawing.Point(307, 3);
            this.chbox_position.Name = "chbox_position";
            this.chbox_position.Size = new System.Drawing.Size(65, 17);
            this.chbox_position.TabIndex = 12;
            this.chbox_position.Text = "Enable?";
            this.chbox_position.UseVisualStyleBackColor = true;
            this.chbox_position.CheckedChanged += new System.EventHandler(this.chbox_position_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // DefencePostionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.chbox_wall);
            this.Controls.Add(this.chbox_position);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DefencePostionForm";
            this.Text = "DefencePostionForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_pos_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pos_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pos_W)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pos_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pos_D)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_wall_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_wall_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_wall_W)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_wall_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_wall_D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_PH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_pos_T;
        private System.Windows.Forms.NumericUpDown num_pos_H;
        private System.Windows.Forms.NumericUpDown num_pos_W;
        private System.Windows.Forms.NumericUpDown num_pos_D;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tb_pos_D;
        private System.Windows.Forms.Label l_position_info;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label l_wall_info;
        private System.Windows.Forms.NumericUpDown num_wall_T;
        private System.Windows.Forms.NumericUpDown num_wall_H;
        private System.Windows.Forms.NumericUpDown num_wall_W;
        private System.Windows.Forms.NumericUpDown num_wall_D;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tb_wall_D;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.CheckBox chbox_position;
        private System.Windows.Forms.CheckBox chbox_wall;
        private System.Windows.Forms.ImageList imageList1;
    }
}