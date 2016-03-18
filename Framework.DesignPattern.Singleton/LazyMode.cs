/**********************************************************************************
 * 
 * 单例模式：确保一个类只有一个实例，并提供一个全局访问点来访问这个唯一实例。
 * 
 * **********************************************************************************/

namespace Framework.DesignPattern.Singleton
{
    /// <summary>
    /// Lazy模式
    /// </summary>
    public class LazyMode
    {
        private static object @object = new object();

        private static LazyMode instance;

        private LazyMode()
        {
        }

        public static LazyMode GetInstance()
        {
            if (instance == null)
            {
                lock (@object)
                {
                    if (instance == null)
                        instance = new LazyMode();
                }
            }

            return instance;
        }
    }

    /// <summary>
    /// Lazy模式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LazyMode<T> where T : class ,new()
    {
        private static object @object = new object();

        private static T instance;

        private LazyMode()
        {
        }

        public static T GetInstance()
        {
            if (instance == null)
            {
                lock (@object)
                {
                    if (instance == null)
                        instance = new T();
                }
            }

            return instance;
        }
    }
}