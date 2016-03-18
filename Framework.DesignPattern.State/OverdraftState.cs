/**********************************************************************************
 * 
 * 状态模式：允许一个对象在其内部状态改变时改变它的行为。对象看起来似乎修改了它的类。
 * 
 * **********************************************************************************/

using System;

namespace Framework.DesignPattern.State
{
    public class OverdraftState : AccountState
    {
        public override void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override void ComputeInterest()
        {
            throw new NotImplementedException();
        }

        public override void StateCheck()
        {
            throw new NotImplementedException();
        }
    }
}
