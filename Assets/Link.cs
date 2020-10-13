using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Link : MonoBehaviour
{
    public void Call(string url)
    {
        Application.OpenURL(url);
    }
}
