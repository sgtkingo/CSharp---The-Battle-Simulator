namespace TheBattleSimulator
{
    partial class AddDefPosForm
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
            this.list_defpos = new System.Windows.Forms.ListBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_defpos
            // 
            this.list_defpos.FormattingEnabled = true;
            this.list_defpos.Location = new System.Drawing.Point(12, 12);
            this.list_defpos.Name = "list_defpos";
            this.list_defpos.Size = new System.Drawing.Size(260, 173);
            this.list_defpos.TabIndex = 0;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(67, 191);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(146, 58);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // AddDefPosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.list_defpos);
            this.Name = "AddDefPosForm";
            this.Text = "AddDefPosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_defpos;
        private System.Windows.Forms.Button ok_btn;
    }
}