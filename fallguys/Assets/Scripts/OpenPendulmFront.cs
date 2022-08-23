using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPendulmFront : MonoBehaviour
{
	public float speed;
	public float limit = 75f; //Limit in degrees of the movement
	public bool randomStart = false; //If you want to modify the start position

    void Update()
    {
            float angle = limit * (-1+Mathf.Sin(Time.time* speed)); 
            transform.localRotation = Quaternion.Euler(angle, 0, 0);
	}
}
