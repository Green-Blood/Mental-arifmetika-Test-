
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] menuPanels;
    [SerializeField] private Animator _menuAnimator;
    [SerializeField] private MenuAnimations _switchAnimation;
    [SerializeField] private float waitTime;
    public void MenuSwapper(int id)
    {
         
        if (SoundManager.Instance.soundManager.volume > 0) 
        {
            SoundManager.Instance.PlaySound();
        }
        //StartCoroutine(ScaleCouroutine(waitTime, id));
        foreach (GameObject menu in menuPanels)
        {
            menu.SetActive(false);
        }
        menuPanels[id].SetActive(true);


        //menuPanels[id].transform.DOScale(1, waitTime);

       
    }

    //private IEnumerator ScaleCouroutine(float time, int id)
    //{
    //   yield return new WaitForSeconds(time);
    //   menuPanels[id].transform.DOScale(1, time);
    //   menuPanels[id].SetActive(true);
    // }






}