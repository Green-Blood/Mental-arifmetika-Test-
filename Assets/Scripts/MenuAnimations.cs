using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimations : MonoBehaviour
{

    [SerializeField] private Animator _menuAnimator;

    public void ScaleDownMenu(bool sizeDown)
    {
        _menuAnimator.SetBool("SizeDown", sizeDown);
    }

    public void ScaleUpMenu(bool sizeUp)
    {
        _menuAnimator.SetBool("SizeUp", sizeUp);
    }
}
