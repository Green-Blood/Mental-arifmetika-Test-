using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuAnimations : MonoBehaviour
{

    [SerializeField] private Animator _menuAnimator;

    public void ScaleDownMenu()
    {
        _menuAnimator.SetTrigger("ScaleDown");
    }

    public void ScaleUpMenu()
    {
        _menuAnimator.SetTrigger("ScaleUp");
    }

    public void Hover(bool isEntered)
    {
        _menuAnimator.SetBool("Hover", isEntered);
    }

    public void MainMenuScaleDown()
    {
        _menuAnimator.SetTrigger("MainHomeworkScaleDown");
    }
}
