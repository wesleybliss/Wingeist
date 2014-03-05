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

        // Helper class to manage settings
        private SettingsHelper settingsHelper;

        // Keys for image list for swapping button visuals
        private static string IMAGE_PLAY_KEY = "play";
        private static string IMAGE_PAUSED_KEY = "pause";

        // Tray icon support
        private NotifyIcon notifyIcon;

        // Monitoring local file system
        private FileSystemWatcher fsw;

        // Allow pause/resume of watching
        private bool isPaused = true;

        // Track if changes have happened since last log append
        private bool isDirty = false;

        /// <summary>
        /// Class constructor
        /// </summary>
        public MainForm() {
            InitializeComponent();
            // Catch application exit to free resources
            Application.ApplicationExit += Application_ApplicationExit;
            // Get an instance of settings helper
            settingsHelper = new SettingsHelper();
        }

        /// <summary>
        /// Catches application exit to free resources
        /// </summary>
        void Application_ApplicationExit( object sender, EventArgs e ) {
            // Release the icon resource.
            notifyIcon.Dispose();
        }

        /// <summary>
        /// Main form load - setup tray icon & FS monitor
        /// </summary>
        private void MainForm_Load( object sender, EventArgs e ) {

            // Tray icon setup
            notifyIcon = new NotifyIcon();
            notifyIcon.Text = "Wingeist";
            notifyIcon.Icon = new Icon( SystemIcons.Asterisk, 40, 40 );
            notifyIcon.ContextMenuStrip = contextMenuMain;
            notifyIcon.Click += notifyIcon_Click;
            notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            notifyIcon.Visible = false;

            // Setup FS monitor but don't auto-start (@todo setting for auto-start)
            fsw = new FileSystemWatcher( settingsHelper.monitorPath, "*" );
            fsw.NotifyFilter = NotifyFilters.LastAccess |
                         NotifyFilters.LastWrite |
                         NotifyFilters.FileName |
                         NotifyFilters.DirectoryName;
            fsw.IncludeSubdirectories = true;
            // @todo More handlers? with filters?
            fsw.Created += new FileSystemEventHandler( fsw_Created );

        }

        /// <summary>
        /// Catch form close event but don't allow application to exit.
        /// Instead, show tray icon.
        /// </summary>
        private void MainForm_FormClosing( object sender, FormClosingEventArgs e ) {
            // Prevent application from exiting
            e.Cancel = true;
            // Hide all form components
            this.Hide();
            this.ShowInTaskbar = false;
            // Show tray icon
            notifyIcon.Visible = true;
        }

        /// <summary>
        /// Show context menu (same as right-click menu for now)
        /// </summary>
        void notifyIcon_Click( object sender, EventArgs e ) {
            contextMenuMain.Show( MousePosition );
        }

        /// <summary>
        /// Show main form and hide tray icon
        /// </summary>
        void notifyIcon_DoubleClick( object sender, EventArgs e ) {
            this.ShowInTaskbar = true;
            this.Show();
            notifyIcon.Visible = false;
        }

        /// <summary>
        /// Pause or resume watching the local file system
        /// </summary>
        private void menuContextPauseResume_Click( object sender, EventArgs e ) {
            swapMode();
        }

        /// <summary>
        /// Allow exiting the application from the tray menu
        /// </summary>
        private void menuContextExit_Click( object sender, EventArgs e ) {
            Application.Exit();
        }

        /// <summary>
        /// Handle file created events
        /// </summary>
        private void fsw_Created( object sender, FileSystemEventArgs e ) {
            // Add the created file to the list
            // Invoke required as this is on a different thread
            this.Invoke( (MethodInvoker) delegate {
                listEvents.Items.Add( e.Name + " ... " + e.FullPath );
            } );
            // Let logger know we have new events to write
            isDirty = true;
        }

        /// <summary>
        /// Switch between paused and running modes of monitoring
        /// </summary>
        private void swapMode() {
            // Track current state
            isPaused = !isPaused;
            fsw.EnableRaisingEvents = !isPaused;
            // Update UI
            buttonPauseResume.ImageKey = isPaused ? IMAGE_PLAY_KEY : IMAGE_PAUSED_KEY;
            menuContextPauseResume.Text = isPaused ? "&Resume" : "&Pause";
        }

        /// <summary>
        /// Allow mode switching from tray icon
        /// </summary>
        private void buttonPauseResume_Click( object sender, EventArgs e ) {
            swapMode();
        }

        /// <summary>
        /// Show settings window (dialog)
        /// </summary>
        private void buttonSettings_Click( object sender, EventArgs e ) {
            ( new SettingsForm() ).ShowDialog( this );
        }

        /// <summary>
        /// Logs new events every 10 minutes
        /// @todo Make 10min a setting
        /// </summary>
        private void timerLogger_Tick( object sender, EventArgs e ) {

        }

    } // class

} // ns
