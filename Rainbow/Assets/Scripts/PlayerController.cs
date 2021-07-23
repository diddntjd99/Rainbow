using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Slider slider; //무게 슬라이더
    public float speed = 2.0f;

    private int BronzeCount; //브론즈 카운터
    private int SilverCount;
    private int GoldCount;
    private int RubyCount;
    private int AmberCount;
    private int TopazCount;
    private int EmeraldCount;
    private int SapphireCount;
    private int CobaltCount;
    private int AmethystCount;

    private int FlashlightCount;
    private int RadarCount;

    public GameObject Text;
    public TMP_Text HiddenBoxText;
    private int selectMineral; //hiddenMineral 안에 들어갈 인덱스 변수

    void Start()
    {
        BronzeCount = 0;
        SilverCount = 0;
        GoldCount = 0;
        RubyCount = 0;
        AmberCount = 0;
        TopazCount = 0;
        EmeraldCount = 0;
        SapphireCount = 0;
        CobaltCount = 0;
        AmethystCount = 0;

        slider.value = 0;

        PlayerPrefs.SetInt("FlashlightCount", 0);
        PlayerPrefs.SetInt("RadarCount", 0);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (slider.value >= 100)
        {
            Gameover();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mineral") // 태그가 광물인지 판단
        {
            if (other.gameObject.name.Contains("Bronze")) // 이름에 "Bronze"가 포함하고 있을 경우
            {
                slider.value += 2; // 슬라이더 값 10 증가
                BronzeCount++;

                PlayerPrefs.SetInt("BronzeCount", BronzeCount); //브론즈 카운터 데이터를 공유
            }
            if (other.gameObject.name.Contains("Silver"))
            {
                slider.value += 3;
                SilverCount++;

                PlayerPrefs.SetInt("SilverCount", SilverCount);
            }
            if (other.gameObject.name.Contains("Gold"))
            {
                slider.value += 4;
                GoldCount++;

                PlayerPrefs.SetInt("GoldCount", GoldCount);
            }
            if (other.gameObject.name.Contains("Ruby"))
            {
                slider.value += 5;
                RubyCount++;

                PlayerPrefs.SetInt("RubyCount", RubyCount);
            }
            if (other.gameObject.name.Contains("Amber"))
            {
                slider.value += 10;
                AmberCount++;

                PlayerPrefs.SetInt("AmberCount", AmberCount);
            }
            if (other.gameObject.name.Contains("Topaz"))
            {
                slider.value += 15;
                TopazCount++;

                PlayerPrefs.SetInt("TopazCount", TopazCount);
            }
            if (other.gameObject.name.Contains("Emerald"))
            {
                slider.value += 20;
                EmeraldCount++;

                PlayerPrefs.SetInt("EmeraldCount", EmeraldCount);
            }
            if (other.gameObject.name.Contains("Sapphier"))
            {
                slider.value += 25;
                SapphireCount++;

                PlayerPrefs.SetInt("SapphireCount", SapphireCount);
            }
            if (other.gameObject.name.Contains("Cobalt"))
            {
                slider.value += 30;
                CobaltCount++;

                PlayerPrefs.SetInt("CobaltCount", CobaltCount);
            }
            if (other.gameObject.name.Contains("Amethyst"))
            {
                slider.value += 40;
                AmethystCount++;

                PlayerPrefs.SetInt("AmethystCount", AmethystCount);
            }

            Destroy(other.gameObject); // 광물 파괴
        }

        if (other.gameObject.tag == "Item") //태그가 아이템인지 판단
        {
            if (other.gameObject.name.Contains("Flashlight"))
            {
                FlashlightCount = PlayerPrefs.GetInt("FlashlightCount");

                if (FlashlightCount < 3)
                {
                    FlashlightCount++;

                    PlayerPrefs.SetInt("FlashlightCount", FlashlightCount);
                }
            }
            if (other.gameObject.name.Contains("Radar"))
            {
                RadarCount = PlayerPrefs.GetInt("RadarCount");

                if (RadarCount < 3)
                {
                    RadarCount++;

                    PlayerPrefs.SetInt("RadarCount", RadarCount);
                }
            }

            Destroy(other.gameObject); // 광물 파괴
        }

        if (other.gameObject.tag == "HiddenBox") //태그가 히든박스인지 판단
        {
            var randomPoint = Random.value * 100; // Random.value는 0.0 ~ 1.1사이의 수 골라줌 -> 100%로 환산

            if (randomPoint >= 0 && randomPoint < 25) //25% 사파이어
            {
                selectMineral = 0;
                slider.value += 25;
                SapphireCount++;

                PlayerPrefs.SetInt("SapphireCount", SapphireCount);
            }
            if (randomPoint >= 25 && randomPoint < 50) //25% 코발트
            {
                selectMineral = 1;
                slider.value += 30;
                CobaltCount++;

                PlayerPrefs.SetInt("CobaltCount", CobaltCount);
            }
            if (randomPoint >= 50 && randomPoint < 75) //25% 애머지스트
            {
                selectMineral = 2;
                slider.value += 40;
                AmethystCount++;

                PlayerPrefs.SetInt("AmethystCount", AmethystCount);
            }
            if (randomPoint >= 75 && randomPoint <= 100) //25% 폭탄
            {
                selectMineral = 3;
                slider.value += 30;
            }
            StartCoroutine(TextRoutine());
            Destroy(other.gameObject);
        }
    }

    IEnumerator TextRoutine()
    {
        Text.SetActive(true);

        if (selectMineral == 0)
        {
            HiddenBoxText.text = "Sapphire";
        }
        if (selectMineral == 1)
        {
            HiddenBoxText.text = "Cobalt";
        }
        if (selectMineral == 2)
        {
            HiddenBoxText.text = "Amethyst";
        }
        if (selectMineral == 3)
        {
            HiddenBoxText.text = "Boom!!";
        }

        yield return new WaitForSeconds(1f);

        Text.SetActive(false);
    }

    void Gameover()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
