using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    void Start()
    {
        Call("https://www.google.com/")
    }
    
    public void Call(string url)
    {
        Application.OpenURL(url);
    }
}
