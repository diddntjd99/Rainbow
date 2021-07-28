using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowBoxController : MonoBehaviour
{
    public GameObject Player;
    public GameObject ShadowBox;

    private bool One; //한번만 실행을 위한 bool 타입
    private bool OnClick;

    void Start()
    {
        One = true;
        OnClick = true;
    }

    void Update()
    {
        if (Player.transform.position.y <= 521.1 && One == true)
        {
            One = false;
            StartCoroutine(Visible());
        }

        OnClick = (PlayerPrefs.GetInt("OnClick") == 1) ? true : false;
    }

    public void UsedItem()
    {
        StartCoroutine(Used());
    }

    IEnumerator Visible() //플레이어의 y좌표가 일정 이하일 때 ShadowBox 생성
    {
        for (var f = 0.0; f <= 1.0; f += 0.1)
        {
            GetComponent<Renderer>().material.color = new Color(GetComponent<Renderer>().material.color.r,
                GetComponent<Renderer>().material.color.g,
                GetComponent<Renderer>().material.color.b, (float)f);
            yield return new WaitForSeconds(0.07f);
        }
    }

    IEnumerator Used() //랜턴 아이템 사용 후 서서히 없어지고, 3초 후 서서히 다시 ShadowBox 생성
    {
        for (var f = 1.0; f >= 0.0; f -= 0.1)
        {
            GetComponent<Renderer>().material.color = new Color(GetComponent<Renderer>().material.color.r,
                GetComponent<Renderer>().material.color.g,
                GetComponent<Renderer>().material.color.b, (float)f);
            yield return new WaitForSeconds(0.05f);
        }

        yield return new WaitForSeconds(3f);

        for (var f = 0.0; f <= 1.0; f += 0.1)
        {
            GetComponent<Renderer>().material.color = new Color(GetComponent<Renderer>().material.color.r,
                GetComponent<Renderer>().material.color.g,
                GetComponent<Renderer>().material.color.b, (float)f);
            yield return new WaitForSeconds(0.05f);
        }

        OnClick = false;
        PlayerPrefs.SetInt("OnClick", (OnClick) ? 1 : 0); //OnClick이 true면 1, false면 0
    }
}
