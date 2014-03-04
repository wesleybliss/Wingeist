using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Wingeist {

    public partial class MainForm : Form {

        private NotifyIcon notifyIcon;
        private FileSystemWatcher fsw;

        public MainForm() {
            InitializeComponent();
            Application.ApplicationExit += Application_ApplicationExit;
        }

        void Application_ApplicationExit( object sender, EventArgs e ) {
            // Release the icon resource.
            notifyIcon.Dispose();
        }

        private void MainForm_Load( object sender, EventArgs e ) {

            notifyIcon = new NotifyIcon();
            notifyIcon.Text = "Wingeist";
            notifyIcon.Icon = new Icon( SystemIcons.Asterisk, 40, 40 );
            notifyIcon.ContextMenuStrip = contextMenuMain;
            notifyIcon.Click += notifyIcon_Click;
            notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            notifyIcon.Visible = false;

            fsw = new FileSystemWatcher( @"C:\Users\wes", "*.txt" );
            fsw.NotifyFilter = NotifyFilters.LastAccess |
                         NotifyFilters.LastWrite |
                         NotifyFilters.FileName |
                         NotifyFilters.DirectoryName;
            fsw.IncludeSubdirectories = true;
            fsw.Created += new FileSystemEventHandler( fsw_Created );
            //fsw.EnableRaisingEvents = true;

        }

        private void MainForm_FormClosing( object sender, FormClosingEventArgs e ) {
            e.Cancel = true;
            this.Hide();
            this.ShowInTaskbar = false;
            notifyIcon.Visible = true;
        }

        void notifyIcon_Click( object sender, EventArgs e ) {
            contextMenuMain.Show( MousePosition );
        }

        void notifyIcon_DoubleClick( object sender, EventArgs e ) {
            this.ShowInTaskbar = true;
            this.Show();
            notifyIcon.Visible = false;
        }

        private void menuContextPauseResume_Click( object sender, EventArgs e ) {

        }

        private void menuContextExit_Click( object sender, EventArgs e ) {
            Application.Exit();
        }

        private void fsw_Created( object sender, FileSystemEventArgs e ) {
            //this.Invoke( (MethodInvoker) delegate {
            //    listBox1.Items.Add( e.Name + " ... " + e.FullPath );
            //} );
        }

    } // class

} // ns
