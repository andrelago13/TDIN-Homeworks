using System;
using System.Runtime.Remoting;

class Client {

    static void Main(string[] args) {
        int v = 7;
        RemotingConfiguration.Configure("Client.exe.config",  /*ensureSecurity*/ true); // o booleano é pq a outra versão ficou deprecada
        RemObj obj = new RemObj();
        Console.WriteLine(obj.Hello());
        Console.ReadLine();
    }
}
