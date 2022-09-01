using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPendulmFront : MonoBehaviour
{
	public float speed;
	public float limit = 75f; //Limit in degrees of the movement

    void Update()
    {
            float angle = limit * (1-Mathf.Sin((Time.time+1.5f)* speed)); 
            transform.localRotation = Quaternion.Euler(angle, 0, 0);
	}
}
