using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace RemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //// 透過Activator.GetObject取得指定 url 的 Remoting 物件, 並轉換該物件型別至RemotingInterface.IMethods
                //// URL需視SERVER端通道調整
                var tcpChannelEntity = (RemotingInterface.IMethods)Activator.GetObject(typeof(RemotingInterface.IMethods), "tcp://127.0.0.1:8050/RemotingTest");
                tcpChannelEntity.Method1("value1");

                var httpChannelEntity = (RemotingInterface.IMethods)Activator.GetObject(typeof(RemotingInterface.IMethods), "http://127.0.0.1:8051/RemotingTest");
                httpChannelEntity.Method1("http");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
