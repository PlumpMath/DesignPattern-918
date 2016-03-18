/**********************************************************************************
 * 
 * 代理模式：给某一个对象提供一个代理或占位符，并由代理对象来控制对原对象的访问。
 * 
 * **********************************************************************************/

using System;

namespace Framework.DesignPattern.Proxy
{
    public class LogProxy : ILog
    {
        private readonly ILog _log;

        public LogProxy(ILog log)
        {
            this._log = log;
        }

        public void Info(string message)
        {
            this.StartLog();

            this._log.Info(message);

            this.EndLog();
        }

        private void StartLog()
        {
            Console.WriteLine("开始记录日志");
        }

        private void EndLog()
        {
            Console.WriteLine("结束记录日志");
        }
    }
}