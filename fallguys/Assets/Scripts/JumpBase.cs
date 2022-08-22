using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBase : MonoBehaviour
{
    public float force = 10f;
    public float stunTime = 0.001f;
	private Vector3 hitDir;

	void OnCollisionEnter(Collision collision) //콜라이더 충돌
	{
		foreach (ContactPoint contact in collision.contacts) // 배열 인덱스 끝까지 알아서 순환
        //형태: foreach(데이터타입 변수명 in 배열,컬렉션등)
        //contacts[포지션 벡터, 노말 벡터, 색 벡터]
		{
			Debug.DrawRay(contact.point, contact.normal, Color.white);//Debug.DrawRay(지점, 방향, 색)
			if (collision.gameObject.tag == "Player")
			{
				hitDir = contact.normal;
				collision.gameObject.GetComponent<CharacterControls>().HitPlayer(-hitDir * force, stunTime);
				return;
			}
		}
    }
}
