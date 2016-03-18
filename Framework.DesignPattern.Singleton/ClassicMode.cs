/**********************************************************************************
 * 
 * 单例模式：确保一个类只有一个实例，并提供一个全局访问点来访问这个唯一实例。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Singleton
{
    /// <summary>
    /// 经典模式
    /// </summary>
    public class ClassicMode
    {
        private static ClassicMode instance;

        private ClassicMode()
        {
        }

        public static ClassicMode GetInstance()
        {
            if (instance == null)
                instance = new ClassicMode();

            return instance;
        }
    }

    /// <summary>
    /// 经典模式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ClassicMode<T> where T : class, new()
    {
        private static T instance;

        private ClassicMode()
        {
        }

        public static T GetInstance()
        {
            if (instance == null)
                instance = new T();

            return instance;
        }
    }
}