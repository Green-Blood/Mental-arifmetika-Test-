using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMusicImageSwitcher : MonoBehaviour
{
    private Image toggleImgMusic;
    public Sprite switcherOn;
    public Sprite switcherOff;
    Toggle toggle;

    void Start()
    {
        SoundManager.Instance.musicManager.clip = SoundManager.Instance.backgroundLoop;
        toggleImgMusic = GetComponent<Image>();
        toggle = GetComponent<Toggle>();
        toggle.isOn = Convert.ToBoolean(PlayerPrefs.GetInt("Music"));
        toggleImgMusic.sprite = toggle.isOn ? switcherOn : switcherOff;
        SoundManager.Instance.musicManager.volume = toggle.isOn ? 1f : 0f;
        SoundManager.Instance.musicManager.Play();
    }

    public void MusicSwitch(bool isOn)
    {
        toggleImgMusic.sprite = isOn ? switcherOn : switcherOff;
        SoundManager.Instance.musicManager.volume = isOn ? 1f : 0f;
        PlayerPrefs.SetInt("Music", (isOn ? 1 : 0));
        PlayerPrefs.Save();
    }
}
