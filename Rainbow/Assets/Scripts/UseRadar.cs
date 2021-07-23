using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseRadar : MonoBehaviour
{
    private int RadarCount;
    private bool OnClick;

    public Camera MiniMapCamera;

    void Start()
    {
        PlayerPrefs.DeleteKey("RadarCount"); //랜턴 아이템 카운터 데이터 초기화
        OnClick = false;
        MiniMapCamera.cullingMask = 1 << 9;
    }

    void Update()
    {
        RadarCount = PlayerPrefs.GetInt("RadarCount");
    }

    public void UsedRadar()
    {
        if (RadarCount > 0 && OnClick == false)
        {
            OnClick = true;
            RadarCount--;
            PlayerPrefs.SetInt("RadarCount", RadarCount);

            StartCoroutine(Visible());
        }
    }

    IEnumerator Visible()
    {
        MiniMapCamera.cullingMask = LayerMask.NameToLayer("Everything");

        yield return new WaitForSeconds(5f);

        MiniMapCamera.cullingMask = 1 << 9;

        OnClick = false;
    }
}