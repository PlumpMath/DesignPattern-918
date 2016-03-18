/**********************************************************************************
 * 
 * 抽象工厂模式：提供一个创建一系列相关或相互依赖对象的接口，而无须指定它们具体的类。
 * 
 * **********************************************************************************/

using System;

namespace Framework.DesignPattern.AbstractFactory
{
    public class DefaultButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("默认按钮");
        }
    }
}
