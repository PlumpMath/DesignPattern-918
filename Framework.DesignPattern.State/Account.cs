/**********************************************************************************
 * 
 * 状态模式：允许一个对象在其内部状态改变时改变它的行为。对象看起来似乎修改了它的类。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.State
{
    public class Account
    {
        private AccountState state;

        private decimal _balance = 0;

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public void SetState(AccountState state)
        {
            this.state = state;
        }
    }
}