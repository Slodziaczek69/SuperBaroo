using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void ShowOptions()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);
    }
    public void BackStartGame()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

}

