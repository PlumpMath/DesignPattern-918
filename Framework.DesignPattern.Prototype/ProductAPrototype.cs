/**********************************************************************************
 * 
 * 原型模式：使用原型实例指定待创建对象的类型，并且通过复制这个原型来创建新的对象。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Prototype
{
    public class ProductAPrototype : ProductPrototype
    {
        public override ProductPrototype Clone()
        {
            return (ProductPrototype)this.MemberwiseClone();
        }
    }
}