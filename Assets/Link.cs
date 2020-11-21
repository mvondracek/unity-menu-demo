using UnityEngine;

public class Link : MonoBehaviour
{
/* lgtm-ef1 */
    void Start()
    {
        Call("https://www.google.com/");
        Call("https://www.google.com/");
        Application.OpenURL("https://www.example.com/");
    }
    
    public void Call(string url)
    {
        Application.OpenURL(url);
    }
}
