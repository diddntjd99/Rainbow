using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapMineralController : MonoBehaviour
{
    GameObject mineral;

    public GameObject MiniMapMineral;

    void Start()
    {
        this.mineral = GameObject.FindGameObjectWithTag("Mineral");
        if (mineral != null)
        {
            Debug.Log("광물 찾기 성공");
        }
        else
        {
            Debug.LogError("광물 찾기 실패");
        }

        StartCoroutine(RandomItem());
    }

    IEnumerator RandomItem()
    {
        while (true)
        {
            Vector3 position;

            position.x = -mineral.transform.position.x;
            position.y = mineral.transform.position.y;
            position.z = mineral.transform.position.z;

            Instantiate(MiniMapMineral, position, Quaternion.identity);
        }
    }
}
