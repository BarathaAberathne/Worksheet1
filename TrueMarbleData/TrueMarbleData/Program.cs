using System;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace TrueMarbleData
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ServiceHost host;
            NetTcpBinding tcpBinding = new NetTcpBinding();

            tcpBinding.MaxReceivedMessageSize = System.Int32.MaxValue;
            tcpBinding.ReaderQuotas.MaxArrayLength = System.Int32.MaxValue;

            host = new ServiceHost(typeof(TMDataControllerImpl));

            host.AddServiceEndpoint(typeof(ITMDataController),tcpBinding, "net.tcp://localhost:50001/TMData");
            try
            {
                host.Open();

                Console.WriteLine("Press Enter to exit");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            host.Close();
        }
    }
}
