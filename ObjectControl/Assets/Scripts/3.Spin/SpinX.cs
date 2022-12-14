using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinX : MonoBehaviour
{
    public float speed = 1000; // 회전 속도
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float my = Input.GetAxis("Mouse Y"); // 마우스 수직 이동
        float deg = my * speed * Time.deltaTime; // 회전 각도

        transform.Rotate(deg, 0, 0); // X축 기준 deg도 회전
    }
}
