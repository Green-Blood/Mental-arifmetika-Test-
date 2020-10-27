using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneManagerScript : MonoBehaviour
{
    public void GoToMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GoToRegistrationScene()
    {
        SceneManager.LoadScene("Registration");
    }
    public void GoToHomeworkScene()
    {
        SceneManager.LoadScene("HistoryHomework");
    }
    public void GoToSelfWorkScene()
    {
        SceneManager.LoadScene("Selftwork");
    }
    public void GoToSettingsScene()
    {
        SceneManager.LoadScene("Settings");
    }

}
