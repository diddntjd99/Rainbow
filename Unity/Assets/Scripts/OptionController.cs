using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip clip;
}

public class OptionController : MonoBehaviour
{
    public GameObject OptionUI;
    public Text musicText;
    private bool musicBool;

    [Header("사운드 등록")]
    [SerializeField] Sound[] bgmSounds;

    [Header("브금 플레이어")]
    [SerializeField] AudioSource bgmPlayer;

    void Start()
    {
        musicBool = true;
        MusicClick();
    }

    public void OptionClick()
    {
        OptionUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void MusicClick()
    {
        if (musicBool == true)
        {
            bgmPlayer.clip = bgmSounds[0].clip;
            bgmPlayer.Play();
            musicText.text = "Music ON";
            musicBool = false;
        }
        else if (musicBool == false)
        {
            bgmPlayer.Stop();
            musicText.text = "Music OFF";
            musicBool = true;
        }
    }

    public void ReStartClick()
    {
        Application.LoadLevel("GamePlayScene");
    }

    public void HomeClick()
    {
        Application.LoadLevel("GamePlayScene");
    }

    public void CloseClick()
    {
        OptionUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
