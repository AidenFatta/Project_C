using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    private GameObject mainMenu;
    private GameObject creditsMenu;
    private GameObject gameOverMenu;
    private GameObject gameHUD;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainMenu = GameObject.FindGameObjectWithTag("MainMenuCanvas");
        creditsMenu = GameObject.FindGameObjectWithTag("CreditsCanvas");
        gameOverMenu = GameObject.FindGameObjectWithTag("GameOverCanvas");
        gameHUD = GameObject.FindGameObjectWithTag("HUDCanvas");

        if(mainMenu != null) mainMenu.SetActive(true);
        if(creditsMenu != null) creditsMenu.SetActive(false);
        if(gameHUD != null) gameHUD.SetActive(true);
        if(gameOverMenu != null) gameOverMenu.SetActive(false);
    }

    //Button functions
    public void OnStartGameClick()
    {
        SceneManager.LoadScene("Game Scene"); 
    }

    public void OnMainMenuClick()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void OnCreditsClick()
    {
        if(mainMenu != null) mainMenu.SetActive(false);
        if(creditsMenu != null) creditsMenu.SetActive(true);
    }

    public void OnCreditsBackClick()
    {
        if(mainMenu != null) mainMenu.SetActive(true);
        if(creditsMenu != null) creditsMenu.SetActive(false);
    }

    public void OnQuitClick()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
