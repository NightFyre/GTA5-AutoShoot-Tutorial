
namespace GTA5_AutoShoot_SOURCE
{
    partial class MainForm
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
            this.ProcStatus_Label = new System.Windows.Forms.Label();
            this.AutoShoot_CheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.Author_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProcStatus_Label
            // 
            this.ProcStatus_Label.AutoSize = true;
            this.ProcStatus_Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcStatus_Label.Location = new System.Drawing.Point(12, 9);
            this.ProcStatus_Label.Name = "ProcStatus_Label";
            this.ProcStatus_Label.Size = new System.Drawing.Size(31, 19);
            this.ProcStatus_Label.TabIndex = 0;
            this.ProcStatus_Label.Text = "o.0";
            // 
            // AutoShoot_CheckBox
            // 
            this.AutoShoot_CheckBox.AutoSize = true;
            this.AutoShoot_CheckBox.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.AutoShoot_CheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.AutoShoot_CheckBox.Location = new System.Drawing.Point(30, 62);
            this.AutoShoot_CheckBox.Name = "AutoShoot_CheckBox";
            this.AutoShoot_CheckBox.Size = new System.Drawing.Size(157, 30);
            this.AutoShoot_CheckBox.TabIndex = 1;
            this.AutoShoot_CheckBox.Text = "AUTOSHOOT";
            this.AutoShoot_CheckBox.UseVisualStyleBackColor = true;
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Enabled = true;
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // Author_Label
            // 
            this.Author_Label.AutoSize = true;
            this.Author_Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_Label.Location = new System.Drawing.Point(12, 28);
            this.Author_Label.Name = "Author_Label";
            this.Author_Label.Size = new System.Drawing.Size(31, 19);
            this.Author_Label.TabIndex = 2;
            this.Author_Label.Text = "o.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(228, 104);
            this.Controls.Add(this.Author_Label);
            this.Controls.Add(this.AutoShoot_CheckBox);
            this.Controls.Add(this.ProcStatus_Label);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "GTAV Trainer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProcStatus_Label;
        private System.Windows.Forms.CheckBox AutoShoot_CheckBox;
        private System.Windows.Forms.Timer ProcessTimer;
        private System.Windows.Forms.Label Author_Label;
    }
}

