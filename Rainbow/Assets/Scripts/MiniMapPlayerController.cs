using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapPlayerController : MonoBehaviour
{
    public float speed = 2.0f;

    void Start()
    {
       
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

        //if (GameObject.Find("Player").GetComponent<PlayerController>())
        //{
        //    Gameover();
        //}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mineral") // 태그가 광물인지 판단
        {
            Destroy(other.gameObject); // 광물 파괴
        }
    }

    //void Gameover()
    //{
    //    gameObject.SetActive(false);
    //}
}
