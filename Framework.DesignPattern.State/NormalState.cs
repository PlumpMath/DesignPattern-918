/**********************************************************************************
 * 
 * 状态模式：允许一个对象在其内部状态改变时改变它的行为。对象看起来似乎修改了它的类。
 * 
 * **********************************************************************************/

using System;

namespace Framework.DesignPattern.State
{
    public class NormalState : AccountState
    {
        public NormalState(Account account)
        {
            this.Account = account;
        }

        public NormalState(AccountState state)
        {
            this.Account = state.Account;
        }

        public override void Deposit(decimal amount)
        {
            this.Account.Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            this.Account.Balance -= amount;
        }

        public override void ComputeInterest()
        {
            Console.WriteLine("正常状态，无须支付利息！");
        }

        public override void StateCheck()
        {

        }
    }
}