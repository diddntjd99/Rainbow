using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    GameObject player; // 인게임 상의 캐릭터
    public GameObject PointLight;
    public GameObject DirectionalLight;

    Vector3 light_position_offset; // 카메라의 위치

    void Start()
    {
        this.player = GameObject.Find("Player"); // 프로젝트에서 플레이어 찾기
        //this.light_position_offset = this.transform.position - this.player.transform.position;
    }

    void Update()
    {
        if(player.transform.position.y <= 521.1)
        {
            DirectionalLight.SetActive(false);
            PointLight.SetActive(true);
        }
    }

    void LateUpdate()
    {
        Vector3 newPosition = this.transform.position; // 이동 후 위치
        newPosition.x = this.player.transform.position.x + this.light_position_offset.x;
        newPosition.y = this.player.transform.position.y + this.light_position_offset.y;
        this.transform.position = newPosition;
    }
}
