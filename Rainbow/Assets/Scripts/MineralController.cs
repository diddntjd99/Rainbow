using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MineralController : MonoBehaviour
{
    [SerializeField] private Slider slider;

    GameObject player;
    GameObject mineral;

    public GameObject MiniMapMineral;
    public GameObject Bronze;
    public GameObject Silver;
    public GameObject Gold;
    public GameObject Ruby;
    public GameObject Amber;
    public GameObject Topaz;
    public GameObject Emerald;
    public GameObject Sapphire;
    public GameObject Cobalt;
    public GameObject Amethyst;

    public float interval;

    void Start()
    {
        this.player = GameObject.Find("Player"); // 프로젝트에서 플레이어 찾기
        StartCoroutine(RandomItem());
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

            if (player.transform.position.y <= 522.21 && player.transform.position.y >= 418.21) // 첫 번째 구간
            {
                if (randomPoint >= 0 && randomPoint < 41.5) // 41.5%의 확률로 실행, 브론즈
                {
                    Instantiate(Bronze, randomPosition, Quaternion.identity);
                    mineral = Bronze;
                }
                if (randomPoint >= 41.5 && randomPoint < 74) // 31.5%, 실버
                {
                    Instantiate(Silver, randomPosition, Quaternion.identity);
                    mineral = Silver;
                }
                if (randomPoint >= 74 && randomPoint < 94.5) // 21.5%, 골드
                {
                    Instantiate(Gold, randomPosition, Quaternion.identity);
                    mineral = Gold;
                }
                if (randomPoint >= 94.5 && randomPoint < 97.5) // 3%, 루비
                {
                    Instantiate(Ruby, randomPosition, Quaternion.identity);
                    mineral = Ruby;
                }
                if (randomPoint >= 97.5 && randomPoint < 100) // 2.5%, 엠버
                {
                    Instantiate(Amber, randomPosition, Quaternion.identity);
                    mineral = Amber;
                }
            }
            else if (player.transform.position.y < 418.21 && player.transform.position.y >= 315.21) // 두 번째 구간
            {
                if (randomPoint >= 0 && randomPoint < 40.5) // 40.5%의 확률로 실행, 브론즈
                {
                    Instantiate(Bronze, randomPosition, Quaternion.identity);
                    mineral = Bronze;
                }
                if (randomPoint >= 40.5 && randomPoint < 71) // 30.5%, 실버
                {
                    Instantiate(Silver, randomPosition, Quaternion.identity);
                    mineral = Silver;
                }
                if (randomPoint >= 71 && randomPoint < 91.5) // 20.5%, 골드
                {
                    Instantiate(Gold, randomPosition, Quaternion.identity);
                    mineral = Gold;
                }
                if (randomPoint >= 91.5 && randomPoint < 94.5) // 3%, 루비
                {
                    Instantiate(Ruby, randomPosition, Quaternion.identity);
                    mineral = Ruby;
                }
                if (randomPoint >= 94.5 && randomPoint < 97) // 2.5%, 엠버
                {
                    Instantiate(Amber, randomPosition, Quaternion.identity);
                    mineral = Amber;
                }
                if (randomPoint >= 97 && randomPoint < 99) // 2%, 토파즈
                {
                    Instantiate(Topaz, randomPosition, Quaternion.identity);
                    mineral = Topaz;
                }
                if (randomPoint >= 99 && randomPoint < 100) // 1%, 에메랄드
                {
                    Instantiate(Emerald, randomPosition, Quaternion.identity);
                    mineral = Emerald;
                }
            }
            else if (player.transform.position.y < 315.21 && player.transform.position.y >= 210.21) // 세 번째 구간
            {
                if (randomPoint >= 0 && randomPoint < 40.1) // 40.1%의 확률로 실행, 브론즈
                {
                    Instantiate(Bronze, randomPosition, Quaternion.identity);
                    mineral = Bronze;
                }
                if (randomPoint >= 40.1 && randomPoint < 70.2) // 30.1%, 실버
                {
                    Instantiate(Silver, randomPosition, Quaternion.identity);
                    mineral = Silver;
                }
                if (randomPoint >= 70.2 && randomPoint < 90.3) // 20.1%, 골드
                {
                    Instantiate(Gold, randomPosition, Quaternion.identity);
                    mineral = Gold;
                }
                if (randomPoint >= 90.3 && randomPoint < 93.3) // 3%, 루비
                {
                    Instantiate(Ruby, randomPosition, Quaternion.identity);
                    mineral = Ruby;
                }
                if (randomPoint >= 93.3 && randomPoint < 95.8) // 2.5%, 엠버
                {
                    Instantiate(Amber, randomPosition, Quaternion.identity);
                    mineral = Amber;
                }
                if (randomPoint >= 95.8 && randomPoint < 97.8) // 2%, 토파즈
                {
                    Instantiate(Topaz, randomPosition, Quaternion.identity);
                    mineral = Topaz;
                }
                if (randomPoint >= 97.8 && randomPoint < 98.8) // 1%, 에메랄드
                {
                    Instantiate(Emerald, randomPosition, Quaternion.identity);
                    mineral = Emerald;
                }
                if (randomPoint >= 98.8 && randomPoint < 99.5) // 0.7%, 사파이어
                {
                    Instantiate(Sapphire, randomPosition, Quaternion.identity);
                    mineral = Sapphire;
                }
                if (randomPoint >= 99.5 && randomPoint < 100) // 0.5%, 코발트
                {
                    Instantiate(Cobalt, randomPosition, Quaternion.identity);
                    mineral = Cobalt;
                }
            }
            else if (player.transform.position.y < 210.21) // 네 번째 구간
            {
                if (randomPoint >= 0 && randomPoint < 40) // 40%의 확률로 실행, 브론즈
                {
                    Instantiate(Bronze, randomPosition, Quaternion.identity);
                    mineral = Bronze;
                }
                if (randomPoint >= 40 && randomPoint < 70) // 30%, 실버
                {
                    Instantiate(Silver, randomPosition, Quaternion.identity);
                    mineral = Silver;
                }
                if (randomPoint >= 70 && randomPoint < 90) // 20%, 골드
                {
                    Instantiate(Gold, randomPosition, Quaternion.identity);
                    mineral = Gold;
                }
                if (randomPoint >= 90 && randomPoint < 93) // 3%, 루비
                {
                    Instantiate(Ruby, randomPosition, Quaternion.identity);
                    mineral = Ruby;
                }
                if (randomPoint >= 93 && randomPoint < 95.5) // 2.5%, 엠버
                {
                    Instantiate(Amber, randomPosition, Quaternion.identity);
                    mineral = Amber;
                }
                if (randomPoint >= 95.5 && randomPoint < 97.5) // 2%, 토파즈
                {
                    Instantiate(Topaz, randomPosition, Quaternion.identity);
                    mineral = Topaz;
                }
                if (randomPoint >= 97.5 && randomPoint < 98.5) // 1%, 에메랄드
                {
                    Instantiate(Emerald, randomPosition, Quaternion.identity);
                    mineral = Emerald;
                }
                if (randomPoint >= 98.5 && randomPoint < 99.2) // 0.7%, 사파이어
                {
                    Instantiate(Sapphire, randomPosition, Quaternion.identity);
                    mineral = Sapphire;
                }
                if (randomPoint >= 99.2 && randomPoint < 99.7) // 0.5%, 코발트
                {
                    Instantiate(Cobalt, randomPosition, Quaternion.identity);
                    mineral = Cobalt;
                }
                if (randomPoint >= 99.7 && randomPoint <= 100) // 0.3%, 자수정
                {
                    Instantiate(Amethyst, randomPosition, Quaternion.identity);
                    mineral = Amethyst;
                }
            }

            MiniMapItem(mineral, randomPosition); // 미니맵 광물 표시
            yield return new WaitForSeconds(interval);
        }
    }

    void MiniMapItem(GameObject _mineral, Vector3 _position)
    {
        if (_mineral == Bronze || _mineral == Silver || _mineral == Gold)
        {
            Vector3 position = new Vector3(498.5f, 522.21f, -1000.0f);

            position.x = _position.x;
            position.y = _position.y;

            Instantiate(MiniMapMineral, position, Quaternion.identity);
        }
        else if (_mineral == Ruby)
        {
            Vector3 position = new Vector3(498.5f, 522.21f, -1000.0f);

            position.x = _position.x;
            position.y = 0.1f + _position.y;

            Instantiate(MiniMapMineral, position, Quaternion.identity);
        }
        else if (_mineral == Amber)
        {
            Vector3 position = new Vector3(498.5f, 522.21f, -1000.0f);

            position.x = _position.x;
            position.y = 0.5f + _position.y;

            Instantiate(MiniMapMineral, position, Quaternion.identity);
        }
        else if (_mineral == Topaz)
        {
            Vector3 position = new Vector3(498.5f, 522.21f, -1000.0f);

            position.x = _position.x;
            position.y = 0.2f + _position.y;

            Instantiate(MiniMapMineral, position, Quaternion.identity);
        }
        else if (_mineral == Emerald)
        {
            Vector3 position = new Vector3(498.5f, 522.21f, -1000.0f);

            position.x = _position.x;
            position.y = 0.8f + _position.y;

            Instantiate(MiniMapMineral, position, Quaternion.identity);
        }
        else if (_mineral == Sapphire)
        {
            Vector3 position = new Vector3(498.5f, 522.21f, -1000.0f);

            position.x = _position.x;
            position.y = 0.8f + _position.y;

            Instantiate(MiniMapMineral, position, Quaternion.identity);
        }
        else if (_mineral == Cobalt)
        {
            Vector3 position = new Vector3(498.5f, 522.21f, -1000.0f);

            position.x = _position.x;
            position.y = 0.8f + _position.y;

            Instantiate(MiniMapMineral, position, Quaternion.identity);
        }
        else if (_mineral == Amethyst)
        {
            Vector3 position = new Vector3(498.5f, 522.21f, -1000.0f);

            position.x = _position.x;
            position.y = 0.8f + _position.y;

            Instantiate(MiniMapMineral, position, Quaternion.identity);
        }
    }
}