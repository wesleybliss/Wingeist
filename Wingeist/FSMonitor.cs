using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Wingeist {

    class FSMonitor {

        private FileSystemWatcher fsw;
        private Form parent;
        private string monitorPath;

        public FSMonitor( Form parentForm, string monitorPath ) {

            this.parent = parentForm;
            this.monitorPath = monitorPath;

            fsw = new FileSystemWatcher( monitorPath, "*" );
            fsw.NotifyFilter = NotifyFilters.LastAccess |
                         NotifyFilters.LastWrite |
                         NotifyFilters.FileName |
                         NotifyFilters.DirectoryName;
            fsw.IncludeSubdirectories = true;
            fsw.Created += new FileSystemEventHandler( fsw_Created );

        }

        private void fsw_Created( object sender, FileSystemEventArgs e ) {
            //parent.Invoke( (MethodInvoker) delegate {
            //    listEvents.Items.Add( e.Name + " ... " + e.FullPath );
            //} );
            parent.Invoke( parent.addFSEventDelegate );
        }

    }

}
