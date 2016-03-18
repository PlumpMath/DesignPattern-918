/**********************************************************************************
 * 
 * 适配器模式：将一个类的接口转换成客户希望的另一个接口。适配器模式让那些接口不兼容的类可以一起工作。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Adapter
{
    public class CalcAdapter : Calc
    {
        private readonly ILog _log;

        public CalcAdapter(ILog log)
        {
            this._log = log;
        }

        public override int Add(int a, int b)
        {
            this._log.Info("求和 参数：" + a + "|" + b); ;

            return base.Add(a, b);
        }
    }
}