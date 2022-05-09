using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
            //Shoot(new Vector3(0, 0, 500));
        //}

        
    }
    //총알 발사 함수
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "WALL")
        {
            Destroy(gameObject, 0.2f);  //충돌하고 0.2초 후에 오브젝트 파괴
        }

        if(collision.collider.tag == "ENEMY")
        {
            GameObject manager = GameObject.Find("ScoreManager");
            manager.GetComponent<ScoreManager>().IncScore();
            Destroy(gameObject, 0.1f);  //충돌하고 0.2초 후에 오브젝트 파괴
        }
    }
}
