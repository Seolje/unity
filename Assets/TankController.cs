using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public int playerNum = 1;

    string mvAxisName;
    string rotAxisName;

    float tkMvSpeed = 10.0f;   //tankMoveSpeed
    float tkRotSpeed = 150.0f;   //tankRotationSpeed

    // Start is called before the first frame update
    void Start()
    {
        mvAxisName = "Vertical" + playerNum;
        rotAxisName = "Horizontal" + playerNum;
    }

    // Update is called once per frame
    void Update()
    {
        float mv = Input.GetAxis(mvAxisName)* tkMvSpeed * Time.deltaTime;   //이동속도를 나타냄. Input.GetAxis는 -1, 0, 1의 값임
        float rot = Input.GetAxis(rotAxisName)* tkRotSpeed * Time.deltaTime;   //회전속도

        transform.Translate(0,0,mv);
        transform.Rotate(0,rot,0);
        
    }
}
