using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;


    // Update is called once per frame
    void Update()
        //Om man klickar escape s� �ppnas paus menyn -Maria
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
        //N�r man klickar p� resume s� �r time speed som vanligt -Maria
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
        //N�r spelet �r pausad s� �r time speeden p� 0 -Maria
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Debug.Log("Paused");
    }

    public void Quit()
        //St�nger spel n�r man klickar p� quit knappen -Maria
    {
        Debug.Log("game closes");
        Application.Quit();
    }
}
    
