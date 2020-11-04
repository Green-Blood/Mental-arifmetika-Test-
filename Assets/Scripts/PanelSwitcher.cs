
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] menuPanels;
    [SerializeField] private Animator _menuAnimator;
    [SerializeField] private MenuAnimations _switchAnimation;

    public void MenuSwapper(int id)
    {
        if (SoundManager.Instance.soundManager.volume > 0) 
        {
            SoundManager.Instance.PlaySound();
        }

        foreach (GameObject menu in menuPanels)
        {
            menu.SetActive(false);
        }
        _switchAnimation.ScaleDownMenu(true);
        menuPanels[id].SetActive(true);
    }

}