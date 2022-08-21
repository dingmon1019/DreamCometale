using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBase : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if(other.tag == "Player")
        {
            rb.AddForce(Vector3.up * 20f);
        }
    }

}
