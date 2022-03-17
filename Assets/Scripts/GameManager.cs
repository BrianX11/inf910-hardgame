using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject Player;
    void Start()
    {
        Instantiate(Player, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
}
