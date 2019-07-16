namespace TheBattleSimulator
{
    partial class LandForm
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
            this.gb_weather = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_wind = new System.Windows.Forms.Label();
            this.l_rain = new System.Windows.Forms.Label();
            this.l_visible = new System.Windows.Forms.Label();
            this.tb_wind = new System.Windows.Forms.TrackBar();
            this.tb_rain = new System.Windows.Forms.TrackBar();
            this.tb_visible = new System.Windows.Forms.TrackBar();
            this.check_enable_w = new System.Windows.Forms.CheckBox();
            this.check_enable_l = new System.Windows.Forms.CheckBox();
            this.gb_land = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_water = new System.Windows.Forms.Label();
            this.l_hills = new System.Windows.Forms.Label();
            this.tb_water = new System.Windows.Forms.TrackBar();
            this.tb_hills = new System.Windows.Forms.TrackBar();
            this.btn_ok = new System.Windows.Forms.Button();
            this.gb_weather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_wind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_visible)).BeginInit();
            this.gb_land.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_hills)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_weather
            // 
            this.gb_weather.Controls.Add(this.label3);
            this.gb_weather.Controls.Add(this.label2);
            this.gb_weather.Controls.Add(this.label1);
            this.gb_weather.Controls.Add(this.l_wind);
            this.gb_weather.Controls.Add(this.l_rain);
            this.gb_weather.Controls.Add(this.l_visible);
            this.gb_weather.Controls.Add(this.tb_wind);
            this.gb_weather.Controls.Add(this.tb_rain);
            this.gb_weather.Controls.Add(this.tb_visible);
            this.gb_weather.Location = new System.Drawing.Point(22, 30);
            this.gb_weather.Name = "gb_weather";
            this.gb_weather.Size = new System.Drawing.Size(507, 185);
            this.gb_weather.TabIndex = 0;
            this.gb_weather.TabStop = false;
            this.gb_weather.Text = "WEATHER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vítr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Déšť:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Viditelnost:";
            // 
            // l_wind
            // 
            this.l_wind.AutoSize = true;
            this.l_wind.Location = new System.Drawing.Point(300, 136);
            this.l_wind.Name = "l_wind";
            this.l_wind.Size = new System.Drawing.Size(57, 13);
            this.l_wind.TabIndex = 5;
            this.l_wind.Text = "Bezvětří...";
            // 
            // l_rain
            // 
            this.l_rain.AutoSize = true;
            this.l_rain.Location = new System.Drawing.Point(300, 86);
            this.l_rain.Name = "l_rain";
            this.l_rain.Size = new System.Drawing.Size(64, 13);
            this.l_rain.TabIndex = 4;
            this.l_rain.Text = "Ani kapka...";
            // 
            // l_visible
            // 
            this.l_visible.AutoSize = true;
            this.l_visible.Location = new System.Drawing.Point(300, 37);
            this.l_visible.Name = "l_visible";
            this.l_visible.Size = new System.Drawing.Size(125, 13);
            this.l_visible.TabIndex = 3;
            this.l_visible.Text = "Jasno, viditelnost skvělá.";
            // 
            // tb_wind
            // 
            this.tb_wind.Location = new System.Drawing.Point(84, 125);
            this.tb_wind.Maximum = 5;
            this.tb_wind.Name = "tb_wind";
            this.tb_wind.Size = new System.Drawing.Size(210, 45);
            this.tb_wind.TabIndex = 2;
            // 
            // tb_rain
            // 
            this.tb_rain.Location = new System.Drawing.Point(84, 74);
            this.tb_rain.Maximum = 5;
            this.tb_rain.Name = "tb_rain";
            this.tb_rain.Size = new System.Drawing.Size(210, 45);
            this.tb_rain.TabIndex = 1;
            // 
            // tb_visible
            // 
            this.tb_visible.Location = new System.Drawing.Point(84, 23);
            this.tb_visible.Maximum = 5;
            this.tb_visible.Name = "tb_visible";
            this.tb_visible.Size = new System.Drawing.Size(210, 45);
            this.tb_visible.TabIndex = 0;
            // 
            // check_enable_w
            // 
            this.check_enable_w.AutoSize = true;
            this.check_enable_w.Location = new System.Drawing.Point(401, 12);
            this.check_enable_w.Name = "check_enable_w";
            this.check_enable_w.Size = new System.Drawing.Size(65, 17);
            this.check_enable_w.TabIndex = 1;
            this.check_enable_w.Text = "Enable?";
            this.check_enable_w.UseVisualStyleBackColor = true;
            this.check_enable_w.CheckedChanged += new System.EventHandler(this.check_enable_w_CheckedChanged);
            // 
            // check_enable_l
            // 
            this.check_enable_l.AutoSize = true;
            this.check_enable_l.Location = new System.Drawing.Point(401, 228);
            this.check_enable_l.Name = "check_enable_l";
            this.check_enable_l.Size = new System.Drawing.Size(65, 17);
            this.check_enable_l.TabIndex = 3;
            this.check_enable_l.Text = "Enable?";
            this.check_enable_l.UseVisualStyleBackColor = true;
            this.check_enable_l.CheckedChanged += new System.EventHandler(this.chbox_enable_l_CheckedChanged);
            // 
            // gb_land
            // 
            this.gb_land.Controls.Add(this.label5);
            this.gb_land.Controls.Add(this.label6);
            this.gb_land.Controls.Add(this.l_water);
            this.gb_land.Controls.Add(this.l_hills);
            this.gb_land.Controls.Add(this.tb_water);
            this.gb_land.Controls.Add(this.tb_hills);
            this.gb_land.Location = new System.Drawing.Point(22, 251);
            this.gb_land.Name = "gb_land";
            this.gb_land.Size = new System.Drawing.Size(507, 127);
            this.gb_land.TabIndex = 2;
            this.gb_land.TabStop = false;
            this.gb_land.Text = "LAND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vody:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Terén:";
            // 
            // l_water
            // 
            this.l_water.AutoSize = true;
            this.l_water.Location = new System.Drawing.Point(298, 88);
            this.l_water.Name = "l_water";
            this.l_water.Size = new System.Drawing.Size(152, 13);
            this.l_water.TabIndex = 4;
            this.l_water.Text = "Žádné vodní plochy ani toky...";
            // 
            // l_hills
            // 
            this.l_hills.AutoSize = true;
            this.l_hills.Location = new System.Drawing.Point(300, 37);
            this.l_hills.Name = "l_hills";
            this.l_hills.Size = new System.Drawing.Size(100, 13);
            this.l_hills.TabIndex = 3;
            this.l_hills.Text = "Nekonečné louky...";
            // 
            // tb_water
            // 
            this.tb_water.Location = new System.Drawing.Point(84, 74);
            this.tb_water.Maximum = 5;
            this.tb_water.Name = "tb_water";
            this.tb_water.Size = new System.Drawing.Size(210, 45);
            this.tb_water.TabIndex = 1;
            // 
            // tb_hills
            // 
            this.tb_hills.Location = new System.Drawing.Point(84, 23);
            this.tb_hills.Maximum = 5;
            this.tb_hills.Name = "tb_hills";
            this.tb_hills.Size = new System.Drawing.Size(210, 45);
            this.tb_hills.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(196, 391);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(183, 49);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // LandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 452);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.check_enable_l);
            this.Controls.Add(this.check_enable_w);
            this.Controls.Add(this.gb_weather);
            this.Controls.Add(this.gb_land);
            this.Name = "LandForm";
            this.Text = "LandForm";
            this.gb_weather.ResumeLayout(false);
            this.gb_weather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_wind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_visible)).EndInit();
            this.gb_land.ResumeLayout(false);
            this.gb_land.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_hills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_weather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_wind;
        private System.Windows.Forms.Label l_rain;
        private System.Windows.Forms.Label l_visible;
        private System.Windows.Forms.TrackBar tb_wind;
        private System.Windows.Forms.TrackBar tb_rain;
        private System.Windows.Forms.TrackBar tb_visible;
        private System.Windows.Forms.CheckBox check_enable_w;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_enable_l;
        private System.Windows.Forms.GroupBox gb_land;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_water;
        private System.Windows.Forms.Label l_hills;
        private System.Windows.Forms.TrackBar tb_water;
        private System.Windows.Forms.TrackBar tb_hills;
        private System.Windows.Forms.Button btn_ok;
    }
}