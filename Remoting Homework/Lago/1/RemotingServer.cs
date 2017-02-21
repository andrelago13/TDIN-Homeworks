using System;
using System.Runtime.Remoting;

class Server {

    static void Main( ) {
        RemotingConfiguration.Configure("Server.exe.config",  /*ensureSecurity*/ true); // o booleano é pq a outra versão ficou deprecada
        Console.WriteLine("Press return to exit");
        Console.ReadLine();
    }
}
