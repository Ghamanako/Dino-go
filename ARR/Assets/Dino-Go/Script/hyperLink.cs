using UnityEngine;

public class hyperLink : MonoBehaviour
{
    public string URL;

    public void OpenSosmed()
    {
        Application.OpenURL(URL);
    }
}
