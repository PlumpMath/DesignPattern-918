﻿/**********************************************************************************
 * 
 * 适配器模式：将一个类的接口转换成客户希望的另一个接口。适配器模式让那些接口不兼容的类可以一起工作。
 * 
 * **********************************************************************************/

using System;

namespace Framework.DesignPattern.Adapter
{
    public class TextLog : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
