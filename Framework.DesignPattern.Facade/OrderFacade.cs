/**********************************************************************************
 * 
 * 外观模式：为子系统中的一组接口提供一个统一的入口。外观模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Facade
{
    public class OrderFacade
    {
        private readonly Log _log;

        private readonly Email _email;

        public OrderFacade()
        {
            this._log = new Log();

            this._email = new Email();
        }

        public void SaveOrder()
        {
            this._log.Info("保存订单");

            this._email.SendEmail("369564841@qq.com");
        }
    }
}