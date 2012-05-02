using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace drivespace
{
    class Program
    {
        static void Main(string[] args)
        {
           //"PATHTOEXE\drivespace.exe" drive-C:
            foreach (String arg in args)
            {
                String[] parts = arg.Split('-');
                if (parts[0].Equals("drive"))
                {
                    long toalspace = 0;
                    long freespace = 0;
                    string status = "NOTFOUND";

                    foreach (DriveInfo drive in DriveInfo.GetDrives())
                    {
                        if (drive.Name == parts[1] + ":\\")
                        {
                            if (drive.IsReady)
                            {
                                toalspace = drive.TotalSize;
                                freespace = drive.TotalFreeSpace;
                                status = "READY";
                            }
                            else
                            {
                                status = "NOTREADY";
                            }
                            break;
                        }
                    }
                    //TOTALSPACE,FREESPACE,STATUS
                    Console.WriteLine(toalspace.ToString() + "," + freespace.ToString() + ',' + status);
                }
            }
        }
    }
}