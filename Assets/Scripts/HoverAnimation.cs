using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverAnimation : MonoBehaviour
{

    [SerializeField] private Animator _menuAnimator;
    [SerializeField] private MenuAnimations _switchAnimation;
    [SerializeField] private Texture2D _handCursor;


    public void OnMouseEnter()
    {
        Cursor.SetCursor(_handCursor, Vector2.zero, CursorMode.ForceSoftware);
        _switchAnimation.Hover(true);
    }

    public void OnMouseExit()
    {
        _switchAnimation.Hover(false);
        Cursor.SetCursor(default, Vector2.zero, CursorMode.ForceSoftware);
    }
}
