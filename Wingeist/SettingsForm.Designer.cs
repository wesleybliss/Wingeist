namespace Wingeist {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.textMonitorPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseMonitorPath = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monitor Path:";
            // 
            // textMonitorPath
            // 
            this.textMonitorPath.Location = new System.Drawing.Point(133, 12);
            this.textMonitorPath.Name = "textMonitorPath";
            this.textMonitorPath.Size = new System.Drawing.Size(471, 30);
            this.textMonitorPath.TabIndex = 1;
            // 
            // buttonBrowseMonitorPath
            // 
            this.buttonBrowseMonitorPath.Location = new System.Drawing.Point(621, 12);
            this.buttonBrowseMonitorPath.Name = "buttonBrowseMonitorPath";
            this.buttonBrowseMonitorPath.Size = new System.Drawing.Size(57, 30);
            this.buttonBrowseMonitorPath.TabIndex = 3;
            this.buttonBrowseMonitorPath.Text = "...";
            this.buttonBrowseMonitorPath.UseVisualStyleBackColor = true;
            this.buttonBrowseMonitorPath.Click += new System.EventHandler(this.buttonBrowseMonitorPath_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(515, 84);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(163, 41);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 139);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBrowseMonitorPath);
            this.Controls.Add(this.textMonitorPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Wingeist - Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMonitorPath;
        private System.Windows.Forms.Button buttonBrowseMonitorPath;
        private System.Windows.Forms.Button buttonSave;
    }
}