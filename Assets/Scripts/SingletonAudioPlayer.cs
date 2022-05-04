using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonAudioPlayer : MonoBehaviour
{
    public static SingletonAudioPlayer Instance = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
