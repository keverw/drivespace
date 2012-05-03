# DriveSpace #
This is a simple console application for Windows written in C# and requires .NET Framework 3.5

I needed a tiny EXE I could call from the command line to get some basic disk info, so I wrote this. My [diskspace.js](https://github.com/keverw/diskspace.js) module uses this, so if you are interested in using this with [Node.js](http://nodejs.org/) checkout [diskspace.js](https://github.com/keverw/diskspace.js)

## Example Usage##

    "PATHTOEXE\drivespace.exe" drive-C

You can change the C to any drive letter the system has.

It returns a CSV of `TOTALSPACE,FREESPACE,STATUS`, Example: `250055581696,74356535296,READY`

`TOTALSPACE` and `FREESPACE` are in bytes. status returns the status of the drive query.

## Status codes: ##

- NOTFOUND - Disk letter was not found, the space values will be 0
- READY - The drive is ready
- NOTREADY - The drive isn't ready, the space values will be 0