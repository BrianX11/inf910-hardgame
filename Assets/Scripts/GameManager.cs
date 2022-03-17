using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject Player;

    public Text deadsText;
    public Text finishText;

    private GameObject playerInstance;

    public static GameManager Instance { get; private set; }
    public static int playerDeads { get; set; }

    void Awake()
    {
        if (Instance != null)
            Destroy(Instance);
        Instance = this;
    }

    void Start()
    {
        if (finishText != null)
        {
            finishText.text = "Has completado el juego con tan solo " + playerDeads + " muertes!";
        }
        if (spawnPoint == null) return;
        else
            playerInstance = Instantiate(Player, spawnPoint.transform.position, spawnPoint.transform.rotation);

        deadsText.text = "Muertes: " + playerDeads;
    }
    void Update()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (Input.GetKeyDown(KeyCode.P) || Input.GetMouseButton(0))
            {
                nextLevel();
                return;
            }
        }

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings - 1)
        {
            if (Input.GetKeyDown(KeyCode.P) || Input.GetMouseButton(0))
            {
                playerDeads = 0;
                UnityEngine.SceneManagement.SceneManager.LoadScene(1);
                return;
            }
        }
    }

    public void Respawn()
    {
        deadsText.text = "Muertes: " + playerDeads;
        playerInstance.transform.position = spawnPoint.transform.position;
    }

    public void nextLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }
    void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }
}
