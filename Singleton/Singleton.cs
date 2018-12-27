using System;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton singleInstance;

        private Singleton()
        {

        }

        public static async Task<Singleton> GetInstance()
        {
            if (singleInstance == null)
                singleInstance = new Singleton();
            return await Task.FromResult(singleInstance);
        }
    }
}
