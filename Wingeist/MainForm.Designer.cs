namespace Wingeist {
    partial class MainForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuContextPauseResume = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEventsToday = new System.Windows.Forms.Label();
            this.labelEventsThisWeek = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonPauseResume = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.listEvents = new System.Windows.Forms.ListBox();
            this.contextMenuMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContextPauseResume,
            this.menuContextExit});
            this.contextMenuMain.Name = "contextMenuMain";
            this.contextMenuMain.Size = new System.Drawing.Size(117, 52);
            // 
            // menuContextPauseResume
            // 
            this.menuContextPauseResume.Name = "menuContextPauseResume";
            this.menuContextPauseResume.Size = new System.Drawing.Size(116, 24);
            this.menuContextPauseResume.Text = "&Pause";
            this.menuContextPauseResume.Click += new System.EventHandler(this.menuContextPauseResume_Click);
            // 
            // menuContextExit
            // 
            this.menuContextExit.Name = "menuContextExit";
            this.menuContextExit.Size = new System.Drawing.Size(116, 24);
            this.menuContextExit.Text = "E&xit";
            this.menuContextExit.Click += new System.EventHandler(this.menuContextExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelControls);
            this.panel1.Controls.Add(this.labelEventsThisWeek);
            this.panel1.Controls.Add(this.labelEventsToday);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 77);
            this.panel1.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.AutoSize = true;
            this.panelContent.Controls.Add(this.listEvents);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 77);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(15);
            this.panelContent.Size = new System.Drawing.Size(706, 596);
            this.panelContent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Events Today:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Events This Week:";
            // 
            // labelEventsToday
            // 
            this.labelEventsToday.AutoSize = true;
            this.labelEventsToday.Location = new System.Drawing.Point(167, 9);
            this.labelEventsToday.Name = "labelEventsToday";
            this.labelEventsToday.Size = new System.Drawing.Size(19, 23);
            this.labelEventsToday.TabIndex = 3;
            this.labelEventsToday.Text = "0";
            // 
            // labelEventsThisWeek
            // 
            this.labelEventsThisWeek.AutoSize = true;
            this.labelEventsThisWeek.Location = new System.Drawing.Point(167, 41);
            this.labelEventsThisWeek.Name = "labelEventsThisWeek";
            this.labelEventsThisWeek.Size = new System.Drawing.Size(19, 23);
            this.labelEventsThisWeek.TabIndex = 4;
            this.labelEventsThisWeek.Text = "0";
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.buttonSettings);
            this.panelControls.Controls.Add(this.buttonPauseResume);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControls.Location = new System.Drawing.Point(448, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(258, 77);
            this.panelControls.TabIndex = 6;
            // 
            // buttonPauseResume
            // 
            this.buttonPauseResume.FlatAppearance.BorderSize = 0;
            this.buttonPauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPauseResume.ImageKey = "play";
            this.buttonPauseResume.ImageList = this.imageListIcons;
            this.buttonPauseResume.Location = new System.Drawing.Point(90, 9);
            this.buttonPauseResume.Name = "buttonPauseResume";
            this.buttonPauseResume.Size = new System.Drawing.Size(75, 55);
            this.buttonPauseResume.TabIndex = 8;
            this.buttonPauseResume.UseVisualStyleBackColor = true;
            this.buttonPauseResume.Click += new System.EventHandler(this.buttonPauseResume_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ImageKey = "settings";
            this.buttonSettings.ImageList = this.imageListIcons;
            this.buttonSettings.Location = new System.Drawing.Point(171, 9);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 55);
            this.buttonSettings.TabIndex = 9;
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "play");
            this.imageListIcons.Images.SetKeyName(1, "pause");
            this.imageListIcons.Images.SetKeyName(2, "settings");
            // 
            // listEvents
            // 
            this.listEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEvents.FormattingEnabled = true;
            this.listEvents.HorizontalScrollbar = true;
            this.listEvents.ItemHeight = 23;
            this.listEvents.Location = new System.Drawing.Point(15, 15);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(676, 566);
            this.listEvents.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 673);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Wingeist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem menuContextExit;
        private System.Windows.Forms.ToolStripMenuItem menuContextPauseResume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEventsThisWeek;
        private System.Windows.Forms.Label labelEventsToday;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonPauseResume;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.ListBox listEvents;
    }
}

