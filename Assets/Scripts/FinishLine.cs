using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{       
    public GameObject finishLine;

    private void Start() 
    {
        finishLine.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            OnSpawnFinishCollider();
        }
    }

    public void OnSpawnFinishCollider() 
    {
        finishLine.SetActive(true);
    }
}
