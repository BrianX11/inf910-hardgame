using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeArea : MonoBehaviour
{
    public bool isEndOfLevel;
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SafeArea") && isEndOfLevel)
        {
            Debug.Log("Termino");
        }
    }

}
