/**********************************************************************************
 * 
 * 原型模式：使用原型实例指定待创建对象的类型，并且通过复制这个原型来创建新的对象。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Prototype
{
    public abstract class ProductPrototype
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public abstract ProductPrototype Clone();
    }
}
