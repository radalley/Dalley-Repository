using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    public static bool IsInitialized
    {
        get { return instance != null; }
    }
    private static T instance;

    public static T Instance
    {
get { return instance; }
    }
    private void awake()
    {
        if(instance != null)
        {

        }
        else
        {
            instance = (T)this;
        }
    }

    protected virtual void OnDestroy()
    {
        if(instance == this)
        {
            instance = null;
        }
    }
}
