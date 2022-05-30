using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    public ParticleSystem ShellExplosion;   //ParticleSystem : 폭파효과

    private void OnCollisionEnter(Collision other)
    {
        ParticleSystem fire = Instantiate(ShellExplosion, transform.position, Quaternion.identity);   // Quaternion : 회전과 관련된 변수

        fire.Play();

        Destroy(gameObject);
        Destroy(fire.gameObject, 1.0f);   //폭발 효과(ShellExplosion) 1초 후에 삭제하기
    }
}
