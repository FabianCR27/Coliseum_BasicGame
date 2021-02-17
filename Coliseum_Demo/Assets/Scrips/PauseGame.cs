using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    Health_Bar death;
    public GameObject GameOver;
    public GameObject YouWin;
    public GameObject[] enemies;


    // Start is called before the first frame update
    void Start()
    {
        death = GetComponent<Health_Bar>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {


            if (GameIsPaused)
            {
                Resume();
                Time.timeScale = 1f;
            }
            else
            {
                Pause();
            }

        }
        youWIn();
    }
    public void Resume()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void Pause()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void gameOver()
    {
        if(death.alive_player == false)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            GameOver.SetActive(true);
            Time.timeScale = 0f;
        } 
    }
    public void youWIn()
    { 
        if (enemies.Length < 1||enemies== null )
        {
            YouWin.SetActive(true);
        }
    }

}
