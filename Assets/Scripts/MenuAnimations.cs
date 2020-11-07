using System.Collections;
using System.Collections.Generic;
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
}
