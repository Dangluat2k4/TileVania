using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting_game1 : MonoBehaviour
{
    public GameObject SettingGame;
     public void setTing()
    {
        Debug.Log("click");
        SettingGame.SetActive(true);
        Time.timeScale = 0;
    }
    public void setTing2()
    {
        Debug.Log("click");
        SettingGame.SetActive(true);
        Time.timeScale = 0;
    }
    public void ExitGame() 
    {
        SettingGame.SetActive(false);
        Time.timeScale = 1;
    }
    public void LoadGamePersist()
    {
        SettingGame.SetActive(true);
        FindAnyObjectByType<Game_Session>().LoadScenePersits();
    }
    public void ExitMenuGame()
    {
        FindAnyObjectByType<Game_Session>().ResetGameSession();
    }           
    public void ExitMain()
    {
        SceneManager.LoadScene(0);
        FindAnyObjectByType<Game_Session>().ResetGameSession();
    }
}
