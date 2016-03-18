/**********************************************************************************
 * 
 * 建造者模式：将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Builder
{
    public class Car
    {
        public string Name { get; set; }

        public string Wheel { get; set; }

        public string Color { get; set; }

        public string Other { get; set; }
    }
}
