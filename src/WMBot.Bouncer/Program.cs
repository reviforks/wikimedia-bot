//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or   
//  (at your option) version 3.                                         

//  This program is distributed in the hope that it will be useful,     
//  but WITHOUT ANY WARRANTY; without even the implied warranty of      
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the       
//  GNU General Public License for more details.                        

//  You should have received a copy of the GNU General Public License   
//  along with this program; if not, write to the                       
//  Free Software Foundation, Inc.,                                     
//  51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

namespace WMBot.Bouncer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1)
                Server.network = args[1];
            if (args.Length > 0)
                Server.port = int.Parse(args[0]);
            if (args.Length > 2)
            {
                // pid file
                System.IO.File.WriteAllText(args[2], System.Diagnostics.Process.GetCurrentProcess().Id.ToString());
            }
            Syslog.Log("wm-bnc v. 1.0.0.1");
            
            Server.Connect();
        }
    }
}
