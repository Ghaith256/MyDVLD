using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess {
    internal class clsDataAccessSettings {

        public static string ConnectionString = "Server=.;Database=DVLD;Integrated Security=True;TrustServerCertificate=True;";

        //#if DEBUG
        //    public static string ConnectionString = "Server=.;Database=TestDVLD;Integrated Security=True;TrustServerCertificate=True;";        
        //#else
        //    public static string ConnectionString = "Server=.;Database=DVLD;Integrated Security=True;TrustServerCertificate=True;";
        //#endif

        public static string SourceName = "DVLD_App";

        public static void LogError(Exception ex) {

            try {
                if (OperatingSystem.IsWindows()) {
                    if (!EventLog.SourceExists(SourceName))
                        EventLog.CreateEventSource(SourceName, "Application");

                    EventLog.WriteEntry(SourceName, ex.ToString(), EventLogEntryType.Error);
                }
            } catch { }
        }

    }
}
