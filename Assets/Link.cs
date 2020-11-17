using System.Collections;
using System.Collections.Generic;
using UnityEngine.Application;

public class Link : MonoBehaviour
{
    void Start()
    {
        Call("https://www.google.com/")
        Call("https://www.google.com/")
        Application.OpenURL("https://www.example.com/");
    }
    
    public void Call(string url)
    {
        Application.OpenURL(url);
    }
}
