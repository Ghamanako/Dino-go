using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    [SerializeField]
    private float sec;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        sec -= Time.deltaTime;
        if (sec <= 0)
        {
            SceneManager.LoadScene("Loading");
        }
    }
}