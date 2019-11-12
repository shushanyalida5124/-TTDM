namespace TTDM主页
{
    partial class FormMainPage
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
            this.btnDM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.考勤信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.psdUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDM
            // 
            this.btnDM.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDM.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDM.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDM.Location = new System.Drawing.Point(226, 192);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(78, 40);
            this.btnDM.TabIndex = 0;
            this.btnDM.Text = "点名";
            this.btnDM.UseVisualStyleBackColor = false;
            this.btnDM.Click += new System.EventHandler(this.BtnDM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(117, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(326, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "你好";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.考勤信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 考勤信息ToolStripMenuItem
            // 
            this.考勤信息ToolStripMenuItem.Name = "考勤信息ToolStripMenuItem";
            this.考勤信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.考勤信息ToolStripMenuItem.Text = "考勤信息";
            this.考勤信息ToolStripMenuItem.Click += new System.EventHandler(this.考勤信息ToolStripMenuItem_Click);
            // 
            // psdUpdate
            // 
            this.psdUpdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.psdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.psdUpdate.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.psdUpdate.Location = new System.Drawing.Point(542, 2);
            this.psdUpdate.Name = "psdUpdate";
            this.psdUpdate.Size = new System.Drawing.Size(55, 23);
            this.psdUpdate.TabIndex = 4;
            this.psdUpdate.Text = "修改密码";
            this.psdUpdate.UseVisualStyleBackColor = false;
            this.psdUpdate.Click += new System.EventHandler(this.PsdUpdate_Click);
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 303);
            this.Controls.Add(this.psdUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDM);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMainPage";
            this.Text = "天天点名";
            this.Load += new System.EventHandler(this.FormMainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 考勤信息ToolStripMenuItem;
        private System.Windows.Forms.Button psdUpdate;
    }
}