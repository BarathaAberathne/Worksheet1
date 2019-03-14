using System;
using Gtk;

using System.ServiceModel;
using TrueMarbleData;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {

        try
        {
            ChannelFactory<ITMDataController> dataFactory;
            ITMDataController m_tmData;
            Console.WriteLine("Connecting...");
            //int m_zoom, m_x, m_y;

            NetTcpBinding tcpBinding = new NetTcpBinding();
            tcpBinding.MaxReceivedMessageSize = System.Int32.MaxValue;
            tcpBinding.ReaderQuotas.MaxArrayLength = System.Int32.MaxValue;
            string sURL = "net.tcp://localhost:50001/TMData";
            Console.WriteLine("Connection sdsaaa");

            dataFactory = new ChannelFactory<ITMDataController>(tcpBinding, sURL);
            //m_zoom = 4;
            //m_x = 0;
            //m_y = 0;
            Console.WriteLine("Connection aaaaa");

            m_tmData = dataFactory.CreateChannel();
            Console.WriteLine("Connection bbbbb");

            Console.WriteLine("Connection Stablished");
            //Console.ReadLine();
            byte[] imageBuffer = m_tmData.LoadTile(4,0,0);
            Console.WriteLine("Connection sssss");
            //Console.WriteLine(imageBuffer);

            
            imgBox.Pixbuf = new Gdk.Pixbuf(imageBuffer);


        }
        catch (Exception e)
        {
            String error = "Error" + e.ToString();
            Console.WriteLine(error);
        }
        Build();
    }
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}

