using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    // Start is
    
    Vector3 lastPos;
    // called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other. gameObject.CompareTag("KillTrigger"))
        {
            transform.position = lastPos;
        }
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            lastPos = transform.position;
        }
    }
}
