/**********************************************************************************
 * 
 * 享元模式：运用共享技术有效地支持大量细粒度对象的复用。
 * 
 * **********************************************************************************/

using System.Collections.Generic;

namespace Framework.DesignPattern.Flyweight
{
    public class LogFactory
    {
        public readonly Dictionary<string, ILog> _logs;

        public LogFactory()
        {
            this._logs = new Dictionary<string, ILog>();

            this._logs.Add("DBLog", new DBLog());

            this._logs.Add("TextLog", new TextLog());
        }

        public ILog GetLog(string key)
        {
            ILog log;

            this._logs.TryGetValue(key, out log);

            return log;
        }
    }
}