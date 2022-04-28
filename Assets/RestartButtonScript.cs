using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void restartScreen()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 1;
    }

    public void quitGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
