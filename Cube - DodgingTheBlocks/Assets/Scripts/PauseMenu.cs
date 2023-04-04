using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
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

    void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() 
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

}
