using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneManagerScript : MonoBehaviour
{
    public void loadlevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
