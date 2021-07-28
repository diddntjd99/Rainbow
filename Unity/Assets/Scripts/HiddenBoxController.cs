using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiddenBoxController : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public GameObject player;
    public GameObject hiddenBox;

    public float interval;

    void Start()
    {
        StartCoroutine(RandomHiddenBox());
    }

    IEnumerator RandomHiddenBox()
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

            if (randomPoint >= 0 && randomPoint < 1.5) // 1.5%의 확률로 실행, 히든박스
            {
                Instantiate(hiddenBox, randomPosition, Quaternion.identity);
            }

            yield return new WaitForSeconds(interval);
        }
    }
}