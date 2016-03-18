/**********************************************************************************
 * 
 * 享元模式：运用共享技术有效地支持大量细粒度对象的复用。
 * 
 * **********************************************************************************/

using System;

namespace Framework.DesignPattern.Flyweight
{
    public class DBLog : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine("DBLog" + message);
        }
    }
}
