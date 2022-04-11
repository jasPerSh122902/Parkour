using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void MainMenuButton() 
    {
        MainMenu.SetActive(true);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
