using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject Player;

    private GameObject playerInstance;

    public static GameManager Instance { get; private set; }

    void Awake()
    {
        if (Instance != null)
            Destroy(Instance);
        Instance = this;
    }

    void Start()
    {
        playerInstance = Instantiate(Player, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
    
    public void Respawn()
    {
        playerInstance.transform.position = spawnPoint.transform.position;
    }
    void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }
}
