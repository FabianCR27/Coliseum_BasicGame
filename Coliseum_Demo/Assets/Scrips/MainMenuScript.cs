using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public Animator anim;
    [SerializeField] GameObject OptionsPlay;
    [SerializeField] GameObject ExitPopUp;
    public Button myButton1;
    public Button myButton2;
    public Button myButton3;


    void Start()
    {
        anim.GetComponent<Animator>();
        myButton1.GetComponent<Button>();
        myButton2.GetComponent<Button>();
        myButton3.GetComponent<Button>();
    }

    //playGame
    public void PlayNewGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void PlayGameOptions()
    {
        OptionsPlay.SetActive(true);
        setBtnNotActive();
    }
    public void PlayGameOptionsBack()
    {
        OptionsPlay.SetActive(false);
        setBntsActive();
    }
    //quit
    public void ExitBtn()
    {
        ExitPopUp.SetActive(true);
        setBtnNotActive();
    }
    public void QuitNo()
    {
        
        ExitPopUp.SetActive(false);
        setBntsActive();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    //options
    public void MoveCameraToOptions()
    {
        anim.SetInteger("Options", 1);
    }
    public void MoveCameraToMenu()
    {
        anim.SetInteger("Options", 2);
    }

    //active buttons
    private void setBntsActive()
    {
        myButton1.interactable = true;
        myButton2.interactable = true;
        myButton3.interactable = true;
    }
    private void setBtnNotActive()
    {
        myButton1.interactable = false;
        myButton2.interactable = false;
        myButton3.interactable = false;
    }
}
