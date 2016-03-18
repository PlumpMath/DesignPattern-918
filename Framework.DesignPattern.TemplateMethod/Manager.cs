/**********************************************************************************
 * 
 * 模板方法模式：定义一个操作中算法的框架，而将一些步骤延迟到子类中。模板方法模式使得子类不
 * 改变一个算法的结构即可重定义该算法的某些特定步骤。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.TemplateMethod
{
    public class Manager : Employee
    {
        public override decimal GetBaseSalary()
        {
            return base.GetBaseSalary() + 1000;
        }

        public override decimal AddBonus()
        {
            return 5000;
        }
    }
}