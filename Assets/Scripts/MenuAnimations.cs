using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimations : MonoBehaviour
{
    [SerializeField]
    private Animator _menuAnimator;

    private void ScaleMenu(bool scale)
    {
        _menuAnimator.SetBool("Size", scale);
    }
}
