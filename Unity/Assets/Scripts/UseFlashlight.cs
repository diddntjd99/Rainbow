using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFlashlight : MonoBehaviour
{
    private int FlashlightCount;
    private bool OnClick;

    public GameObject ShadowBox;

    void Start()
    {
        PlayerPrefs.DeleteKey("FlashlightCount"); //랜턴 아이템 카운터 데이터 초기화
        PlayerPrefs.DeleteKey("OnClick");
        OnClick = false;
    }

    void Update()
    {
        FlashlightCount = PlayerPrefs.GetInt("FlashlightCount");
        OnClick = (PlayerPrefs.GetInt("OnClick") == 1) ? true : false;
    }

    public void UsedFlashlight()
    {
        if (FlashlightCount > 0 && OnClick == false)
        {
            OnClick = true;
            PlayerPrefs.SetInt("OnClick", (OnClick) ? 1 : 0); //OnClick이 true면 1, false면 0

            FlashlightCount--;
            PlayerPrefs.SetInt("FlashlightCount", FlashlightCount);

            ShadowBox.GetComponent<ShadowBoxController>().UsedItem(); //ShadowBoxController 스크립트의 UsedItem 함수 실행
        }
    }
}
