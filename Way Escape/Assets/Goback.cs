using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goback : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] float levelExitSlowMoFactor = 0.2f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LoadNextLeve());
    }

    IEnumerator LoadNextLeve()
    {
        Time.timeScale = levelExitSlowMoFactor;
        yield return new WaitForSecondsRealtime(levelLoadDelay);
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level 3");
    }
}
