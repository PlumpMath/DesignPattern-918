﻿/**********************************************************************************
 * 
 * 外观模式：为子系统中的一组接口提供一个统一的入口。外观模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。
 * 
 * **********************************************************************************/

using System;

namespace Framework.DesignPattern.Facade
{
    public class Email
    {
        public void SendEmail(string to)
        {
            Console.WriteLine("发邮件 地址:" + to);
        }
    }
}
