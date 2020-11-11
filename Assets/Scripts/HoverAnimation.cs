using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverAnimation : MonoBehaviour
{

    [SerializeField] private Animator _menuAnimator;
    [SerializeField] private MenuAnimations _switchAnimation;


    public void OnMouseEnter()
    {
        _switchAnimation.Hover(true);
    }

    public void OnMouseExit()
    {
        _switchAnimation.Hover(false);
    }
}
