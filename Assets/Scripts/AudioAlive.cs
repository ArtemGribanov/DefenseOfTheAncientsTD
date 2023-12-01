using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAlive : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
