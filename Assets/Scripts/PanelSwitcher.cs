using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] menuPanels;

    public void MenuSwapper(int id)
    {
        foreach (GameObject menu in menuPanels)
        {
            menu.SetActive(false);
        }
        menuPanels[id].SetActive(true);
    }
}
