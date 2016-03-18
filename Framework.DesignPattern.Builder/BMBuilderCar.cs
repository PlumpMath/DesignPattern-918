/**********************************************************************************
 * 
 * 建造者模式：将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Builder
{
    public class BMBuilderCar : BuilderCar
    {
        public override void BuildName()
        {
            this._car.Name = "宝马";
        }

        public override void BuildWheel()
        {
            this._car.Name = "车轮";
        }

        public override void BuildColor()
        {
            this._car.Name = "白色";
        }

        public override void BuildOther()
        {
            this._car.Name = "车身";
        }
    }
}