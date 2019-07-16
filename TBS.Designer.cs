namespace TheBattleSimulator
{
    partial class TBS
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBS));
            this.a_gbox = new System.Windows.Forms.GroupBox();
            this.a_btn_edit_units = new System.Windows.Forms.Button();
            this.a_btn_del_units = new System.Windows.Forms.Button();
            this.a_btn_edit_defpos = new System.Windows.Forms.Button();
            this.a_btn_del_defpos = new System.Windows.Forms.Button();
            this.a_chlw_units = new System.Windows.Forms.CheckedListBox();
            this.a_chlw_defpos = new System.Windows.Forms.CheckedListBox();
            this.a_rbt_arch = new System.Windows.Forms.RadioButton();
            this.a_rbt_cavalerly = new System.Windows.Forms.RadioButton();
            this.a_rbt_inf = new System.Windows.Forms.RadioButton();
            this.label_or = new System.Windows.Forms.Label();
            this.a_btn_listunit = new System.Windows.Forms.Button();
            this.a_btn_addunit = new System.Windows.Forms.Button();
            this.a_btn_adddefpos = new System.Windows.Forms.Button();
            this.label_tf_a = new System.Windows.Forms.Label();
            this.label_tf_e = new System.Windows.Forms.Label();
            this.a_tf = new System.Windows.Forms.Label();
            this.e_tf = new System.Windows.Forms.Label();
            this.btn_fight = new System.Windows.Forms.Button();
            this.rt_console = new System.Windows.Forms.RichTextBox();
            this.gb_land = new System.Windows.Forms.GroupBox();
            this.l_weather = new System.Windows.Forms.Label();
            this.l_landinfo = new System.Windows.Forms.Label();
            this.l_weathertext = new System.Windows.Forms.Label();
            this.l_landinfotext = new System.Windows.Forms.Label();
            this.btn_landsetting = new System.Windows.Forms.Button();
            this.gb_enemy = new System.Windows.Forms.GroupBox();
            this.e_btn_edit_units = new System.Windows.Forms.Button();
            this.e_btn_del_units = new System.Windows.Forms.Button();
            this.e_btn_edit_defpos = new System.Windows.Forms.Button();
            this.e_btn_del_defpos = new System.Windows.Forms.Button();
            this.e_chlw_units = new System.Windows.Forms.CheckedListBox();
            this.e_chlw_defpos = new System.Windows.Forms.CheckedListBox();
            this.e_rbt_arch = new System.Windows.Forms.RadioButton();
            this.e_rbt_cavalerly = new System.Windows.Forms.RadioButton();
            this.e_rbt_inf = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.e_btn_listunit = new System.Windows.Forms.Button();
            this.e_btn_addunit = new System.Windows.Forms.Button();
            this.e_btn_adddefpos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.a_l_totalamount = new System.Windows.Forms.Label();
            this.e_l_totalamount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.a_gbox.SuspendLayout();
            this.gb_land.SuspendLayout();
            this.gb_enemy.SuspendLayout();
            this.SuspendLayout();
            // 
            // a_gbox
            // 
            this.a_gbox.Controls.Add(this.a_btn_edit_units);
            this.a_gbox.Controls.Add(this.a_btn_del_units);
            this.a_gbox.Controls.Add(this.a_btn_edit_defpos);
            this.a_gbox.Controls.Add(this.a_btn_del_defpos);
            this.a_gbox.Controls.Add(this.a_chlw_units);
            this.a_gbox.Controls.Add(this.a_chlw_defpos);
            this.a_gbox.Controls.Add(this.a_rbt_arch);
            this.a_gbox.Controls.Add(this.a_rbt_cavalerly);
            this.a_gbox.Controls.Add(this.a_rbt_inf);
            this.a_gbox.Controls.Add(this.label_or);
            this.a_gbox.Controls.Add(this.a_btn_listunit);
            this.a_gbox.Controls.Add(this.a_btn_addunit);
            this.a_gbox.Controls.Add(this.a_btn_adddefpos);
            resources.ApplyResources(this.a_gbox, "a_gbox");
            this.a_gbox.Name = "a_gbox";
            this.a_gbox.TabStop = false;
            // 
            // a_btn_edit_units
            // 
            resources.ApplyResources(this.a_btn_edit_units, "a_btn_edit_units");
            this.a_btn_edit_units.Name = "a_btn_edit_units";
            this.a_btn_edit_units.UseVisualStyleBackColor = true;
            this.a_btn_edit_units.Click += new System.EventHandler(this.a_btn_edit_units_Click);
            // 
            // a_btn_del_units
            // 
            resources.ApplyResources(this.a_btn_del_units, "a_btn_del_units");
            this.a_btn_del_units.Name = "a_btn_del_units";
            this.a_btn_del_units.UseVisualStyleBackColor = true;
            this.a_btn_del_units.Click += new System.EventHandler(this.a_btn_del_units_Click);
            // 
            // a_btn_edit_defpos
            // 
            resources.ApplyResources(this.a_btn_edit_defpos, "a_btn_edit_defpos");
            this.a_btn_edit_defpos.Name = "a_btn_edit_defpos";
            this.a_btn_edit_defpos.UseVisualStyleBackColor = true;
            this.a_btn_edit_defpos.Click += new System.EventHandler(this.a_btn_edit_defpos_Click);
            // 
            // a_btn_del_defpos
            // 
            resources.ApplyResources(this.a_btn_del_defpos, "a_btn_del_defpos");
            this.a_btn_del_defpos.Name = "a_btn_del_defpos";
            this.a_btn_del_defpos.UseVisualStyleBackColor = true;
            this.a_btn_del_defpos.Click += new System.EventHandler(this.a_btn_del_defpos_Click);
            // 
            // a_chlw_units
            // 
            this.a_chlw_units.FormattingEnabled = true;
            resources.ApplyResources(this.a_chlw_units, "a_chlw_units");
            this.a_chlw_units.Name = "a_chlw_units";
            // 
            // a_chlw_defpos
            // 
            this.a_chlw_defpos.FormattingEnabled = true;
            resources.ApplyResources(this.a_chlw_defpos, "a_chlw_defpos");
            this.a_chlw_defpos.Name = "a_chlw_defpos";
            // 
            // a_rbt_arch
            // 
            resources.ApplyResources(this.a_rbt_arch, "a_rbt_arch");
            this.a_rbt_arch.Name = "a_rbt_arch";
            this.a_rbt_arch.TabStop = true;
            this.a_rbt_arch.UseVisualStyleBackColor = true;
            // 
            // a_rbt_cavalerly
            // 
            resources.ApplyResources(this.a_rbt_cavalerly, "a_rbt_cavalerly");
            this.a_rbt_cavalerly.Name = "a_rbt_cavalerly";
            this.a_rbt_cavalerly.TabStop = true;
            this.a_rbt_cavalerly.UseVisualStyleBackColor = true;
            // 
            // a_rbt_inf
            // 
            resources.ApplyResources(this.a_rbt_inf, "a_rbt_inf");
            this.a_rbt_inf.Name = "a_rbt_inf";
            this.a_rbt_inf.TabStop = true;
            this.a_rbt_inf.UseVisualStyleBackColor = true;
            // 
            // label_or
            // 
            resources.ApplyResources(this.label_or, "label_or");
            this.label_or.Name = "label_or";
            // 
            // a_btn_listunit
            // 
            resources.ApplyResources(this.a_btn_listunit, "a_btn_listunit");
            this.a_btn_listunit.Name = "a_btn_listunit";
            this.a_btn_listunit.UseVisualStyleBackColor = true;
            // 
            // a_btn_addunit
            // 
            resources.ApplyResources(this.a_btn_addunit, "a_btn_addunit");
            this.a_btn_addunit.Name = "a_btn_addunit";
            this.a_btn_addunit.UseVisualStyleBackColor = true;
            this.a_btn_addunit.Click += new System.EventHandler(this.a_btn_addunit_Click);
            // 
            // a_btn_adddefpos
            // 
            resources.ApplyResources(this.a_btn_adddefpos, "a_btn_adddefpos");
            this.a_btn_adddefpos.Name = "a_btn_adddefpos";
            this.a_btn_adddefpos.UseVisualStyleBackColor = true;
            this.a_btn_adddefpos.Click += new System.EventHandler(this.a_btn_adddefpos_Click);
            // 
            // label_tf_a
            // 
            resources.ApplyResources(this.label_tf_a, "label_tf_a");
            this.label_tf_a.Name = "label_tf_a";
            // 
            // label_tf_e
            // 
            resources.ApplyResources(this.label_tf_e, "label_tf_e");
            this.label_tf_e.Name = "label_tf_e";
            // 
            // a_tf
            // 
            resources.ApplyResources(this.a_tf, "a_tf");
            this.a_tf.Name = "a_tf";
            // 
            // e_tf
            // 
            resources.ApplyResources(this.e_tf, "e_tf");
            this.e_tf.Name = "e_tf";
            // 
            // btn_fight
            // 
            resources.ApplyResources(this.btn_fight, "btn_fight");
            this.btn_fight.Name = "btn_fight";
            this.btn_fight.UseVisualStyleBackColor = true;
            this.btn_fight.Click += new System.EventHandler(this.btn_fight_Click);
            // 
            // rt_console
            // 
            resources.ApplyResources(this.rt_console, "rt_console");
            this.rt_console.Name = "rt_console";
            // 
            // gb_land
            // 
            this.gb_land.Controls.Add(this.l_weather);
            this.gb_land.Controls.Add(this.l_landinfo);
            this.gb_land.Controls.Add(this.l_weathertext);
            this.gb_land.Controls.Add(this.l_landinfotext);
            this.gb_land.Controls.Add(this.btn_landsetting);
            resources.ApplyResources(this.gb_land, "gb_land");
            this.gb_land.Name = "gb_land";
            this.gb_land.TabStop = false;
            // 
            // l_weather
            // 
            resources.ApplyResources(this.l_weather, "l_weather");
            this.l_weather.Name = "l_weather";
            // 
            // l_landinfo
            // 
            resources.ApplyResources(this.l_landinfo, "l_landinfo");
            this.l_landinfo.Name = "l_landinfo";
            // 
            // l_weathertext
            // 
            resources.ApplyResources(this.l_weathertext, "l_weathertext");
            this.l_weathertext.Name = "l_weathertext";
            // 
            // l_landinfotext
            // 
            resources.ApplyResources(this.l_landinfotext, "l_landinfotext");
            this.l_landinfotext.Name = "l_landinfotext";
            // 
            // btn_landsetting
            // 
            resources.ApplyResources(this.btn_landsetting, "btn_landsetting");
            this.btn_landsetting.Name = "btn_landsetting";
            this.btn_landsetting.UseVisualStyleBackColor = true;
            this.btn_landsetting.Click += new System.EventHandler(this.btn_landsetting_Click);
            // 
            // gb_enemy
            // 
            this.gb_enemy.Controls.Add(this.e_btn_edit_units);
            this.gb_enemy.Controls.Add(this.e_btn_del_units);
            this.gb_enemy.Controls.Add(this.e_btn_edit_defpos);
            this.gb_enemy.Controls.Add(this.e_btn_del_defpos);
            this.gb_enemy.Controls.Add(this.e_chlw_units);
            this.gb_enemy.Controls.Add(this.e_chlw_defpos);
            this.gb_enemy.Controls.Add(this.e_rbt_arch);
            this.gb_enemy.Controls.Add(this.e_rbt_cavalerly);
            this.gb_enemy.Controls.Add(this.e_rbt_inf);
            this.gb_enemy.Controls.Add(this.label1);
            this.gb_enemy.Controls.Add(this.e_btn_listunit);
            this.gb_enemy.Controls.Add(this.e_btn_addunit);
            this.gb_enemy.Controls.Add(this.e_btn_adddefpos);
            resources.ApplyResources(this.gb_enemy, "gb_enemy");
            this.gb_enemy.Name = "gb_enemy";
            this.gb_enemy.TabStop = false;
            // 
            // e_btn_edit_units
            // 
            resources.ApplyResources(this.e_btn_edit_units, "e_btn_edit_units");
            this.e_btn_edit_units.Name = "e_btn_edit_units";
            this.e_btn_edit_units.UseVisualStyleBackColor = true;
            this.e_btn_edit_units.Click += new System.EventHandler(this.e_btn_edit_units_Click);
            // 
            // e_btn_del_units
            // 
            resources.ApplyResources(this.e_btn_del_units, "e_btn_del_units");
            this.e_btn_del_units.Name = "e_btn_del_units";
            this.e_btn_del_units.UseVisualStyleBackColor = true;
            this.e_btn_del_units.Click += new System.EventHandler(this.e_btn_del_units_Click);
            // 
            // e_btn_edit_defpos
            // 
            resources.ApplyResources(this.e_btn_edit_defpos, "e_btn_edit_defpos");
            this.e_btn_edit_defpos.Name = "e_btn_edit_defpos";
            this.e_btn_edit_defpos.UseVisualStyleBackColor = true;
            this.e_btn_edit_defpos.Click += new System.EventHandler(this.e_btn_edit_defpos_Click);
            // 
            // e_btn_del_defpos
            // 
            resources.ApplyResources(this.e_btn_del_defpos, "e_btn_del_defpos");
            this.e_btn_del_defpos.Name = "e_btn_del_defpos";
            this.e_btn_del_defpos.UseVisualStyleBackColor = true;
            this.e_btn_del_defpos.Click += new System.EventHandler(this.e_btn_del_defpos_Click);
            // 
            // e_chlw_units
            // 
            this.e_chlw_units.FormattingEnabled = true;
            resources.ApplyResources(this.e_chlw_units, "e_chlw_units");
            this.e_chlw_units.Name = "e_chlw_units";
            // 
            // e_chlw_defpos
            // 
            this.e_chlw_defpos.FormattingEnabled = true;
            resources.ApplyResources(this.e_chlw_defpos, "e_chlw_defpos");
            this.e_chlw_defpos.Name = "e_chlw_defpos";
            // 
            // e_rbt_arch
            // 
            resources.ApplyResources(this.e_rbt_arch, "e_rbt_arch");
            this.e_rbt_arch.Name = "e_rbt_arch";
            this.e_rbt_arch.TabStop = true;
            this.e_rbt_arch.UseVisualStyleBackColor = true;
            // 
            // e_rbt_cavalerly
            // 
            resources.ApplyResources(this.e_rbt_cavalerly, "e_rbt_cavalerly");
            this.e_rbt_cavalerly.Name = "e_rbt_cavalerly";
            this.e_rbt_cavalerly.TabStop = true;
            this.e_rbt_cavalerly.UseVisualStyleBackColor = true;
            // 
            // e_rbt_inf
            // 
            resources.ApplyResources(this.e_rbt_inf, "e_rbt_inf");
            this.e_rbt_inf.Name = "e_rbt_inf";
            this.e_rbt_inf.TabStop = true;
            this.e_rbt_inf.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // e_btn_listunit
            // 
            resources.ApplyResources(this.e_btn_listunit, "e_btn_listunit");
            this.e_btn_listunit.Name = "e_btn_listunit";
            this.e_btn_listunit.UseVisualStyleBackColor = true;
            // 
            // e_btn_addunit
            // 
            resources.ApplyResources(this.e_btn_addunit, "e_btn_addunit");
            this.e_btn_addunit.Name = "e_btn_addunit";
            this.e_btn_addunit.UseVisualStyleBackColor = true;
            this.e_btn_addunit.Click += new System.EventHandler(this.e_btn_addunit_Click);
            // 
            // e_btn_adddefpos
            // 
            resources.ApplyResources(this.e_btn_adddefpos, "e_btn_adddefpos");
            this.e_btn_adddefpos.Name = "e_btn_adddefpos";
            this.e_btn_adddefpos.UseVisualStyleBackColor = true;
            this.e_btn_adddefpos.Click += new System.EventHandler(this.e_btn_adddefpos_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // a_l_totalamount
            // 
            resources.ApplyResources(this.a_l_totalamount, "a_l_totalamount");
            this.a_l_totalamount.Name = "a_l_totalamount";
            // 
            // e_l_totalamount
            // 
            resources.ApplyResources(this.e_l_totalamount, "e_l_totalamount");
            this.e_l_totalamount.Name = "e_l_totalamount";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TBS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.e_l_totalamount);
            this.Controls.Add(this.a_l_totalamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_enemy);
            this.Controls.Add(this.gb_land);
            this.Controls.Add(this.rt_console);
            this.Controls.Add(this.btn_fight);
            this.Controls.Add(this.e_tf);
            this.Controls.Add(this.a_tf);
            this.Controls.Add(this.label_tf_e);
            this.Controls.Add(this.label_tf_a);
            this.Controls.Add(this.a_gbox);
            this.Name = "TBS";
            this.a_gbox.ResumeLayout(false);
            this.a_gbox.PerformLayout();
            this.gb_land.ResumeLayout(false);
            this.gb_land.PerformLayout();
            this.gb_enemy.ResumeLayout(false);
            this.gb_enemy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox a_gbox;
        private System.Windows.Forms.Label label_tf_a;
        private System.Windows.Forms.Label label_tf_e;
        private System.Windows.Forms.Label a_tf;
        private System.Windows.Forms.Label e_tf;
        private System.Windows.Forms.Button btn_fight;
        private System.Windows.Forms.RichTextBox rt_console;
        private System.Windows.Forms.Button a_btn_adddefpos;
        private System.Windows.Forms.Label label_or;
        private System.Windows.Forms.Button a_btn_listunit;
        private System.Windows.Forms.Button a_btn_addunit;
        private System.Windows.Forms.RadioButton a_rbt_arch;
        private System.Windows.Forms.RadioButton a_rbt_cavalerly;
        private System.Windows.Forms.RadioButton a_rbt_inf;
        private System.Windows.Forms.Button a_btn_edit_units;
        private System.Windows.Forms.Button a_btn_del_units;
        private System.Windows.Forms.Button a_btn_edit_defpos;
        private System.Windows.Forms.CheckedListBox a_chlw_units;
        private System.Windows.Forms.CheckedListBox a_chlw_defpos;
        private System.Windows.Forms.GroupBox gb_land;
        private System.Windows.Forms.Label l_weathertext;
        private System.Windows.Forms.Label l_landinfotext;
        private System.Windows.Forms.Button btn_landsetting;
        private System.Windows.Forms.Label l_landinfo;
        private System.Windows.Forms.Label l_weather;
        private System.Windows.Forms.Button a_btn_del_defpos;
        private System.Windows.Forms.GroupBox gb_enemy;
        private System.Windows.Forms.Button e_btn_edit_units;
        private System.Windows.Forms.Button e_btn_del_units;
        private System.Windows.Forms.Button e_btn_edit_defpos;
        private System.Windows.Forms.Button e_btn_del_defpos;
        private System.Windows.Forms.CheckedListBox e_chlw_units;
        private System.Windows.Forms.CheckedListBox e_chlw_defpos;
        private System.Windows.Forms.RadioButton e_rbt_arch;
        private System.Windows.Forms.RadioButton e_rbt_cavalerly;
        private System.Windows.Forms.RadioButton e_rbt_inf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button e_btn_listunit;
        private System.Windows.Forms.Button e_btn_addunit;
        private System.Windows.Forms.Button e_btn_adddefpos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label a_l_totalamount;
        private System.Windows.Forms.Label e_l_totalamount;
        private System.Windows.Forms.Label label4;
    }
}

