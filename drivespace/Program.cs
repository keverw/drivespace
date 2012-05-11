using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace drivespace
{
    class Program
    {
        private static void Main(string[] args)
        {
            // "PATHTOEXE\drivespace.exe" drive-C
            var driveInfo = DriveInfo.GetDrives().ToDictionary(drive => drive.Name);

            foreach (var drive in args
                .Select(arg => arg.ToUpperInvariant().Split('-'))
                .Where(parts => (parts.Length == 2) && parts[0].Equals("DRIVE") && driveInfo.ContainsKey(parts[1] + ":\\"))
                .Select(parts => driveInfo[parts[1] + ":\\"]))
            {
                // TOTALSPACE,FREESPACE,STATUS
                Console.WriteLine(
                    (drive.IsReady ? drive.TotalSize : 0L) + "," +
                    (drive.IsReady ? drive.TotalFreeSpace : 0L) + "," +
                    (drive.IsReady ? "READY" : "NOTREADY"));
            }
        }
    }
}