/**********************************************************************************
 * 
 * 代理模式：给某一个对象提供一个代理或占位符，并由代理对象来控制对原对象的访问。
 * 
 * **********************************************************************************/

using System;

namespace Framework.DesignPattern.Proxy
{
    public class TextLog : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine("TextLog" + message);
        }
    }
}