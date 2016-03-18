/**********************************************************************************
 * 
 * 状态模式：允许一个对象在其内部状态改变时改变它的行为。对象看起来似乎修改了它的类。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.State
{
    public abstract class AccountState
    {
        public Account Account { get; set; }

        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);

        public abstract void ComputeInterest();

        public abstract void StateCheck();
    }
}