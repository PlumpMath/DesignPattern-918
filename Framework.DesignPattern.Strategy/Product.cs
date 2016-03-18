/**********************************************************************************
 * 
 * 策略模式：定义一系列算法，将每一个算法封装起来，并让它们可以相互替换。策略模式让算法可以独立于使用它的客户变化。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Strategy
{
    public class Product
    {
        private decimal _price;

        private IDiscount discount;

        public void SetDiscount(IDiscount discount)
        {
            this.discount = discount;
        }

        public decimal Price
        {
            get { return discount.Calculate(_price); }
            set { _price = value; }
        }
    }
}
