using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;

    public Scene scene;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(scene.name);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void Change()
    {
        SceneManager.LoadScene(sceneName);
    }
}