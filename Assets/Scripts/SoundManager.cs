using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public AudioClip sound;
    public AudioClip backgroundLoop;
    public AudioSource soundManager;
    public AudioSource musicManager;

    public void PlaySound()
    {
        soundManager.PlayOneShot(sound);
    }
}
