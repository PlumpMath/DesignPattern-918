/**********************************************************************************
 * 
 * 建造者模式：将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Builder
{
    public abstract class BuilderCar
    {
        protected Car _car;

        public BuilderCar()
        {
            this._car = new Car();
        }

        public abstract void BuildName();

        public abstract void BuildWheel();

        public abstract void BuildColor();

        public abstract void BuildOther();

        public Car CreateCar()
        {
            return this._car;
        }
    }
}