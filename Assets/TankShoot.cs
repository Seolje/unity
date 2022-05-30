using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour   //포탄 만들어서 발사
{
    public Rigidbody prefabShell;   //물리엔진 불러오기. Inspector에서 어떤 물체 나가게 할건지 불러오면 됨
    public Transform fireTransform;   //어느 위치에서 포탄을 만들건지 위치 받아오는 것. Inspector에서 어느 위치에서 나갈건지 불러오면 됨

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
        
    }

    void Fire()
    {
        Rigidbody InstanceShell = Instantiate(prefabShell, fireTransform.position, fireTransform.rotation) as Rigidbody;

        InstanceShell.velocity = 10.0f * fireTransform.forward;   //30.0f(속도) * 방향
    }
}
