using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    [SerializeField] private Slider slider;

    GameObject player;
    public GameObject Flashlight;
    public GameObject Radar;

    public float interval;

    public Text FlashlightText;
    public Text RadarText;

    private int FlashlightCount;
    private int RadarCount;

    void Start()
    {
        this.player = GameObject.Find("Player"); // 프로젝트에서 플레이어 찾기
        StartCoroutine(RandomItem());

        PlayerPrefs.DeleteKey("FlashlightCount"); //랜턴 아이템 카운터 데이터 초기화
        PlayerPrefs.DeleteKey("RadarCount");
    }

    void Update()
    {
        FlashlightCount = PlayerPrefs.GetInt("FlashlightCount");
        RadarCount = PlayerPrefs.GetInt("RadarCount");

        FlashlightText.text = FlashlightCount + "";
        RadarText.text = RadarCount + "";
    }

    IEnumerator RandomItem()
    {
        while (true)
        {
            if (slider.value >= 100)
            {
                break;
            }

            Vector3 randomPosition;

            var randomPoint = Random.value * 100; // Random.value는 0.0 ~ 1.1사이의 수 골라줌 -> 100%로 환산

            randomPosition.x = Random.Range(this.player.transform.position.x - 5, this.player.transform.position.x + 5);
            randomPosition.y = Random.Range(this.player.transform.position.y - 5, this.player.transform.position.y - 10);
            randomPosition.z = 0;

            if (randomPoint <= 50)
            {
                Instantiate(Flashlight, randomPosition, Quaternion.identity);
            }
            else if (randomPoint > 50)
            {
                Instantiate(Radar, randomPosition, Quaternion.identity);
            }

            yield return new WaitForSeconds(interval);
        }
    }
}