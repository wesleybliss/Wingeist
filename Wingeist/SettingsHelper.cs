using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Wingeist {

    class SettingsHelper {

        public string basePath = "C:\\";
        public string confPath = "";
        public string monitorPath = "C:\\";

        public SettingsHelper()
            : this(
                System
                    .Reflection
                    .Assembly
                    .GetExecutingAssembly()
                    .GetName()
                    .Name + ".conf" ) {
        }

        public SettingsHelper( string confPathInput ) {

            basePath = Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location
            );

            confPath = qualifyConfPath( confPathInput );

            if ( File.Exists( confPath ) ) {
                readSettings();
            }

        }

        private string qualifyConfPath( string path ) {
            if ( !File.Exists( path ) ) {
                path = basePath + "\\" + path;
            }
            return path;
        }

        private void readSettings() {
            using ( StreamReader sr = new StreamReader( confPath ) ) {
                processSetting( sr.ReadLine() );
                sr.Close();
            }
        }

        private void processSetting( string line ) {
            if ( !string.IsNullOrEmpty( line ) && ( line.Substring( 0, 1 ) != "#" ) ) {
                string[] parts = line.Split( new char[] { '=' } );
                switch ( parts[0].ToLower() ) {
                    case "monitor_path":
                        monitorPath = parts[1];
                        break;
                }
            }
        }

        public void saveSettings() {
            
            ArrayList lines = new ArrayList();

            if ( !File.Exists( confPath ) ) {
                File.CreateText( confPath ).Close();
            }

            using ( StreamReader sr = new StreamReader( confPath ) ) {
                lines.Add( sr.ReadLine() );
                sr.Close();
            }

            for ( int i = 0, l = lines.Count; i < l; i++ ) {
                if ( !string.IsNullOrEmpty( (string) lines[i] ) ) {
                    string[] parts = ( (string) lines[i] ).Split( new char[] { '=' } );
                    switch ( ( (string) parts[0] ).ToLower() ) {
                        case "monitor_path":
                            parts[1] = monitorPath;
                            break;
                    }
                    lines[i] = String.Join( " = ", parts );
                }
            }

            using ( StreamWriter sw = new StreamWriter( confPath ) ) {
                sw.Write( String.Join( Environment.NewLine, lines.ToArray() ) );
                sw.Close();
            }

        }

    }

}
