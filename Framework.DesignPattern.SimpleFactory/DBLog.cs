/**********************************************************************************
 * 
 * 简单工厂模式 (Simple Factory Pattern)：定义一个工厂类，它可以根据参数的不同返回不同类的实例，被创建的实例通常都具有共同的父类。
 * 
 * **********************************************************************************/

using System;

namespace Framework.DesignPattern.SimpleFactory
{
    public class DBLog : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine("DB" + message);
        }
    }
}