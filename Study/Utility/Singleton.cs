public class Singleton<T> where T : new()
{
    public static T Instance
    {
        get
        {
            if (mInstance == null)
                mInstance = new T();

            return mInstance;
        }
    }

    protected Singleton()
    {

    }

    private static T mInstance;
}