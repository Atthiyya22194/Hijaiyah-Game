using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music music;

    // Start is called before the first frame update
    private void Awake()
    {
        if(music != null && music != this)
        {
            Destroy(this.gameObject);
            return;
        }
        music = this;
        DontDestroyOnLoad(this);
    }
}
