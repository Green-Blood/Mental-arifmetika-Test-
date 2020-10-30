using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UsernamePusher : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _usernameRegistration;
    [SerializeField] private TextMeshProUGUI _usernameMainMenu;

    public void SetTextOnUser()
    {
        _usernameMainMenu.text = _usernameRegistration.text ;
    }
}
