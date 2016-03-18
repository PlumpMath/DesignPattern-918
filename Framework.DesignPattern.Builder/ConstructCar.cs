/**********************************************************************************
 * 
 * 建造者模式：将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Builder
{
    public class ConstructCar
    {
        public Car Construct(BuilderCar builder)
        {
            builder.BuildName();

            builder.BuildWheel();

            builder.BuildColor();

            builder.BuildOther();

            return builder.CreateCar();
        }
    }
}