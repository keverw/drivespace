# DriveSpace #
This is a simple Console Application for Windows written in C# and requires .NET Framework 3.5

I needed a tiny EXE I could call from the Command line in Node.js to get some simple disk info out, so I wrote this.

    "PATHTOEXE\drivespace.exe" drive-C

You can change the C to any drive letter the system has.

It returns a CSV of `TOTALSPACE,FREESPACE,STATUS`, Example: `250055581696,74356535296,READY`

`TOTALSPACE` and `FREESPACE` are in bytes. status returns the status of the drive query.

- NOTFOUND - Disk letter was not found, the space values will be 0
- READY - The drive is ready
- NOTREADY - The drive isn't ready, the space values will be 0 

## LICENSE ##

	Copyright (c) 2012, Kevin Whitman and Contributors
	All rights reserved. 
	
	Redistribution and use in source and binary forms, with or without 
	modification, are permitted provided that the following conditions are met: 
	
	 * Redistributions of source code must retain the above copyright notice, 
	   this list of conditions and the following disclaimer.
	 * Neither the name of Kevin Whitman nor the names of its contributors may be used to endorse or promote products derived from this software without specific 
	   prior written permission.
	
	THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
	AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
	IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
	ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
	LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
	CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
	SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
	INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
	CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
	ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
	POSSIBILITY OF SUCH DAMAGE. 