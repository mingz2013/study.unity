using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 控制视图，控制摄像机角度
public class ViewController : MonoBehaviour
{

    public float speed = 1;
    public float mouseSpeed = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 水平按键 A D，和垂直按键 W S
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float mouse = Input.GetAxis("Mouse ScrollWheel"); // 鼠标滑轮
        transform.Translate(new Vector3(h*speed, mouse * mouseSpeed, v*speed) * Time.deltaTime, Space.World); // 方向* 时间*速度

    }
}
