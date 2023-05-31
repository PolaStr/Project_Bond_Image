using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;

public class Main_Menu_Script : MonoBehaviour
{

    [Header("Confirmation")]
    [SerializeField] private GameObject comfirmationPrompt = null;


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

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(ConfirmationBox());
    }

    public IEnumerator ConfirmationBox()
    {
        comfirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        comfirmationPrompt.SetActive(false);
    }
}
