/**********************************************************************************
 * 
 * 装饰模式：动态地给一个对象增加一些额外的职责。就扩展功能而言，装饰模式提供了一种比使用子类更加灵活的替代方案。
 * 
 * **********************************************************************************/

using System;

namespace Framework.DesignPattern.Decorator
{
    public class ESPDecorator : Car
    {
        public readonly Car _car;

        public ESPDecorator(Car car)
        {
            this._car = car;
        }

        public override void Description()
        {
            this._car.Description();

            Console.WriteLine("Add ESP");
        }
    }
}
