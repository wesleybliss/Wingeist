using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wingeist {

    public partial class SettingsForm : Form {

        private SettingsHelper settingsHelper;
        private FolderBrowserDialog fbd;

        public SettingsForm() {
            InitializeComponent();
        }

        private void SettingsForm_Load( object sender, EventArgs e ) {

            settingsHelper = new SettingsHelper();
            
            fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;

            textMonitorPath.Text = settingsHelper.monitorPath;

        }

        private void buttonBrowseMonitorPath_Click( object sender, EventArgs e ) {
            fbd.ShowDialog( this );
            settingsHelper.monitorPath = fbd.SelectedPath;
            textMonitorPath.Text = fbd.SelectedPath;
        }

        private void buttonSave_Click( object sender, EventArgs e ) {
            settingsHelper.saveSettings();
        }
    }
}
