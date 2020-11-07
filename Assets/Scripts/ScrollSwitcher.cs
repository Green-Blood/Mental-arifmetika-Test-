using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject _homeworkPanel;
    [SerializeField] private GameObject _selfworkPanel;

    public void SwitchPanel()
    {
        if (_homeworkPanel.activeSelf)
        {
            _homeworkPanel.SetActive(false);
            _selfworkPanel.SetActive(true);
        }
        else
        {
            _homeworkPanel.SetActive(true);
            _selfworkPanel.SetActive(false);
        }
        
    }
}
