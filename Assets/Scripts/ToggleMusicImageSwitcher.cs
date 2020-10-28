using UnityEngine;
using UnityEngine.UI;
using System;
public class ToggleMusicImageSwitcher : MonoBehaviour
{
    private Image toggleImgMusic;
    public Sprite switcherOn;
    public Sprite switcherOff;
    Toggle toggle;

    void Start()
    {
        toggleImgMusic = GetComponent<Image>();
        toggle = this.gameObject.GetComponent<Toggle>();
        toggle.isOn = Convert.ToBoolean(PlayerPrefs.GetInt("Toggle"));
        toggleImgMusic.sprite = toggle.isOn ? switcherOn : switcherOff;
    }

    public void MusicSwitch(Boolean isOn)
    {
        toggleImgMusic.sprite = isOn ? switcherOn : switcherOff;
        PlayerPrefs.SetInt("Toggle", (isOn ? 1 : 0));
        PlayerPrefs.Save();
    }
}
