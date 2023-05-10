using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu_Script : MonoBehaviour
{
        [Header("Levels_To_Load")]
    public string _newGameLevel;
    private string levelToLoad;

    public void NewGameDialogYes ()
    {
        SceneManager.LoadScene(_newGameLevel);
    }

    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("Saved_Level"))
        {
            levelToLoad = PlayerPrefs.GetString("Saved_Level");
            SceneManager.LoadScene(levelToLoad);
        }
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
