using UnityEngine;
public abstract class Singleton<T> : MonoBehaviour where T : Component
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (T)FindAnyObjectByType(typeof(T));
                if (instance == null)
                {
                    GameObject obj = new GameObject(typeof(T).Name, typeof(T));
                    instance = obj.GetComponent<T>();
                }
            }
            return instance;
        }
    }

    //private static T _instance;

    //public static T Instance
    //{
    //    get
    //    {
    //        if (_instance != null)
    //            return _instance;

    //        _instance = FindAnyObjectByType<T>();
    //        if (_instance != null)
    //            return _instance;

    //        GameObject obj = new() { name = typeof(T).Name };
    //        _instance = obj.AddComponent<T>();
    //        return _instance;
    //    }
    //}
    protected virtual void Awake()
    {
        if (transform.parent != null && transform.root != null)
        {
            // DontDestroyOnLoad 의 경우 하위에 포함되어 있는 경우 제대로 동작을 하지 않는 경우가 있다.
            // 최상위를 파괴불가로 해준다(매니저 모음같은 경우)
            DontDestroyOnLoad(this.transform.root.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

        //if (_instance == null)
        //    _instance = this as T;
        //else
        //    Destroy(gameObject);

        //DontDestroyOnLoad(gameObject);
    }
}


//using UnityEngine;
//public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
//{
//    private static T instance;

//    public static T Instance
//    {
//        get
//        {
//            if (instance == null)
//            {
//                instance = (T)FindAnyObjectByType(typeof(T));
//                if (instance == null)
//                {
//                    GameObject obj = new GameObject(typeof(T).Name, typeof(T));
//                    instance = obj.GetComponent<T>();
//                }
//            }
//            return instance;
//        }
//    }
//    private void Awake()
//    {
//        if (transform.parent != null && transform.root != null)
//        {
//            // DontDestroyOnLoad 의 경우 하위에 포함되어 있는 경우 제대로 동작을 하지 않는 경우가 있다.
//            // 최상위를 파괴불가로 해준다(매니저 모음같은 경우)
//            DontDestroyOnLoad(this.transform.root.gameObject);
//        }
//        else
//        {
//            DontDestroyOnLoad(this.gameObject);
//        }
//    }

//}





