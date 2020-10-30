using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] menuPanels;

    [SerializeField] private Animator _menuAnimator;

    public Button SetAnimation;

    public void MenuSwapper(int id)
    {
        foreach (GameObject menu in menuPanels)
        {
            menu.SetActive(false);
        }
        menuPanels[id].SetActive(true);
    }

    public void ScaleMenu(bool scale)
    {
        _menuAnimator.SetBool("Size", scale);
    }
}
