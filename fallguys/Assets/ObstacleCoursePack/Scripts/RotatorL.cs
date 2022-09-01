using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorL : MonoBehaviour
{
	public float speed = 2f;

    // Update is called once per frame
  void Update()
  {
    transform.Rotate(0f, 0f, -speed * Time.deltaTime / 0.01f, Space.Self);
  }
}
