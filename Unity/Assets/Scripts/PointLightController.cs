using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightController : MonoBehaviour
{
    public GameObject player;
    Vector3 pointlight_position_offset;

    void Start()
    {
        this.player = GameObject.Find("Player");
        this.pointlight_position_offset = this.transform.position - this.player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = this.transform.position; // 이동 후 위치
        newPosition.x = this.player.transform.position.x + this.pointlight_position_offset.x;
        newPosition.y = this.player.transform.position.y + this.pointlight_position_offset.y;
        newPosition.z = -1;
        this.transform.position = newPosition;
    }
}
