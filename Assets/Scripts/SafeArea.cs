using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeArea : MonoBehaviour
{
    public bool isEndOfLevel;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && isEndOfLevel)
        {
            GameManager.Instance.nextLevel();
        }
    }

}
