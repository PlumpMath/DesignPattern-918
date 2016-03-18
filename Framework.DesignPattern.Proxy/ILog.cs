﻿/**********************************************************************************
 * 
 * 代理模式：给某一个对象提供一个代理或占位符，并由代理对象来控制对原对象的访问。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Proxy
{
    public interface ILog
    {
        void Info(string message);
    }
}