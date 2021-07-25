
namespace GTA5_Autoshoot_Tutorial
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
            this.Process_Label = new System.Windows.Forms.Label();
            this.Autoshoot_CheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.Author_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Process_Label
            // 
            this.Process_Label.AutoSize = true;
            this.Process_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process_Label.Location = new System.Drawing.Point(0, 0);
            this.Process_Label.Name = "Process_Label";
            this.Process_Label.Size = new System.Drawing.Size(30, 19);
            this.Process_Label.TabIndex = 0;
            this.Process_Label.Text = "o.0";
            // 
            // Autoshoot_CheckBox
            // 
            this.Autoshoot_CheckBox.AutoSize = true;
            this.Autoshoot_CheckBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.Autoshoot_CheckBox.Location = new System.Drawing.Point(36, 58);
            this.Autoshoot_CheckBox.Name = "Autoshoot_CheckBox";
            this.Autoshoot_CheckBox.Size = new System.Drawing.Size(148, 31);
            this.Autoshoot_CheckBox.TabIndex = 1;
            this.Autoshoot_CheckBox.Text = "AUTOSHOOT";
            this.Autoshoot_CheckBox.UseVisualStyleBackColor = true;
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Enabled = true;
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // Author_Label
            // 
            this.Author_Label.AutoSize = true;
            this.Author_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_Label.Location = new System.Drawing.Point(0, 19);
            this.Author_Label.Name = "Author_Label";
            this.Author_Label.Size = new System.Drawing.Size(30, 19);
            this.Author_Label.TabIndex = 2;
            this.Author_Label.Text = "o.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 103);
            this.Controls.Add(this.Author_Label);
            this.Controls.Add(this.Autoshoot_CheckBox);
            this.Controls.Add(this.Process_Label);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "GTA5 Trainer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Process_Label;
        private System.Windows.Forms.CheckBox Autoshoot_CheckBox;
        private System.Windows.Forms.Timer ProcessTimer;
        private System.Windows.Forms.Label Author_Label;
    }
}

