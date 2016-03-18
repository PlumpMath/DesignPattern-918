/**********************************************************************************
 * 
 * 单例模式：确保一个类只有一个实例，并提供一个全局访问点来访问这个唯一实例。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Singleton
{
    /// <summary>
    /// 饿汉模式
    /// </summary>
    public class HungryMode
    {
        private static readonly HungryMode instance = new HungryMode();

        private HungryMode()
        {
        }

        public static HungryMode GetInstance()
        {
            return instance;
        }
    }

    /// <summary>
    /// 饿汉模式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HungryMode<T> where T : class,new()
    {
        private static readonly T instance = new T();

        private HungryMode()
        {
        }

        public static T GetInstance()
        {
            return instance;
        }
    }
}