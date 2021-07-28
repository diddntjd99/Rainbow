using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverImg;

    public TMP_Text timerText;

    public TMP_Text RecordText;

    private float playTime;

    private bool isGameOver;

    private int BronzeCount;
    private int SilverCount;
    private int GoldCount;
    private int RubyCount;
    private int AmberCount;
    private int TopazCount;
    private int EmeraldCount;
    private int SapphireCount;
    private int CobaltCount;
    private int AmethystCount;

    void Start()
    {
        playTime = 0; //플레이 시간 0으로 초기화
        isGameOver = false;

        PlayerPrefs.DeleteKey("BronzeCount"); //브론즈 카운터 데이터 초기화
        PlayerPrefs.DeleteKey("SilverCount");
        PlayerPrefs.DeleteKey("GoldCount");
        PlayerPrefs.DeleteKey("RubyCount");
        PlayerPrefs.DeleteKey("AmberCount");
        PlayerPrefs.DeleteKey("TopazCount");
        PlayerPrefs.DeleteKey("EmeraldCount");
        PlayerPrefs.DeleteKey("SapphireCount");
        PlayerPrefs.DeleteKey("CobaltCount");
        PlayerPrefs.DeleteKey("AmethystCount");
    }

    void Update()
    {
        if (!isGameOver)
        {
            playTime += Time.deltaTime; //플레이 시간 증가
            if ((int)playTime < 60)
            {
                timerText.text = "Time: " + (int)playTime + "sec"; //텍스트에 플레이 시간 표시, 초
            }
            else if ((int)playTime < 3600)
            {
                timerText.text = "Time: " + (int)playTime / 60 + "min " + (int)playTime % 60 + "sec"; //분/초
            }
            else
            {
                timerText.text = "Time: " + (int)playTime / 3600 + "hour " + ((int)playTime % 3600) / 60 + "min " + ((int)playTime % 3600) % 60 + "sec"; //시간/분/초
            }
        }
    }

    public void EndGame()
    {
        isGameOver = true; //게임 오버 상태로 변환

        gameOverImg.SetActive(true); //게임 오버 텍스트 오브젝트 활성화

        BronzeCount = PlayerPrefs.GetInt("BronzeCount"); //브론즈 카운터 데이터 불러오기
        SilverCount = PlayerPrefs.GetInt("SilverCount");
        GoldCount = PlayerPrefs.GetInt("GoldCount");
        RubyCount = PlayerPrefs.GetInt("RubyCount");
        AmberCount = PlayerPrefs.GetInt("AmberCount");
        TopazCount = PlayerPrefs.GetInt("TopazCount");
        EmeraldCount = PlayerPrefs.GetInt("EmeraldCount");
        SapphireCount = PlayerPrefs.GetInt("SapphireCount");
        CobaltCount = PlayerPrefs.GetInt("CobaltCount");
        AmethystCount = PlayerPrefs.GetInt("AmethystCount");

        RecordText.text = "GameOver!\n\nBronze = " + BronzeCount + "\nSilver = " + SilverCount + "\nGold = " + GoldCount
            + "\nRuby = " + RubyCount + "\nAmber = " + AmberCount + "\nTopaz = " + TopazCount + "\nEmerald = " + EmeraldCount
            + "\nSapphire = " + SapphireCount + "\nCobalt = " + CobaltCount + "\nAmethyst = " + AmethystCount;
    }
}