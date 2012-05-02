# DriveSpace #
This is a simple Console Application for Windows written in C# and requires .NET Framework 3.5

I needed a tiny EXE I could call from the Command line in Node.js to get some simple disk info out, so I wrote this.

    "PATHTOEXE\drivespace.exe" drive-C

You can change the C to any drive letter the system has.

It returns a CVS of `TOTALSPACE,FREESPACE,STATUS`, Example: `250055581696,74356535296,READY`

`TOTALSPACE` and `FREESPACE` are in bytes. status returns the status of the drive query.

- NOTFOUND - Disk letter was not found, the space values will be 0
- READY - The drive is ready
- NOTREADY - The drive isn't ready, the space values will be 0 