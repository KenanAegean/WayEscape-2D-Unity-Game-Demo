using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadSandbox()
    {
        //Time.timeScale = 1;
        SceneManager.LoadScene("Sandbox");
    }


    public void LoadNextScene()
    {
        //Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadMainMenu()
    {
        //Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadCredits()
    {
        //Time.timeScale = 1;
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
