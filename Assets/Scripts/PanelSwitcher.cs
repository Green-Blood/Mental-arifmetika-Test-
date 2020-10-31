
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] menuPanels;

    [SerializeField] private Animator _menuAnimator;

    private bool _resetAnim = false;

    public void MenuSwapper(int id)
    {
        {
            foreach (GameObject menu in menuPanels)
            {
                menu.SetActive(false);
            }
            if (gameObject.active)
            {
                menuPanels[id].SetActive(true);
                StartCoroutine(ResetAnimRoutine());
                ScaleDownMenu();
            }
            
        }
    }

    public void ScaleDownMenu()
    {
        _menuAnimator.SetTrigger("SizeDown");
    }
    public void ScaleUpMenu()
    {
        _menuAnimator.SetTrigger("SizeUp");
    }

    IEnumerator ResetAnimRoutine()
    {
        _resetAnim = true;
        yield return new WaitForSeconds(3f);
        _resetAnim = false;
    }

}