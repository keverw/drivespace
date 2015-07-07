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
                .Where(parts => (parts.Length == 2) && parts[0].Equals("DRIVE"))
                .Select(parts => parts[1] + ":\\"))
            {
                DriveInfo drive_status = null;
                if (driveInfo.TryGetValue(drive, out drive_status))
                {
                    // TOTALSPACE,FREESPACE,STATUS
                    Console.WriteLine(
                        (drive_status.IsReady ? drive_status.TotalSize : 0L) + "," +
                        (drive_status.IsReady ? drive_status.TotalFreeSpace : 0L) + "," +
                        (drive_status.IsReady ? "READY" : "NOTREADY"));
                }
                else
                {
                    Console.WriteLine("0,0,NOTFOUND");
                }
            }
        }
    }
}