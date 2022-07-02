using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public GameObject pauseUI;
    public GameObject passUI;
    public Transform spawnPos;
    public static int requiredkey;

    public static List<int> key = new List<int>();


    private void Awake()
    {
          if (instance == null)
          {
              instance = this;
          }
          else if (instance != this)
          {
              Destroy(gameObject);
          }
          DontDestroyOnLoad(gameObject);

        SetSpawnPos(spawnPos.position);

    }
    void Start()
    {
        requiredkey = 2;
    }

    void Update()
    {
        // Debug.Log(key.Count);
       
    }
    public void pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void  pass()
    {
        passUI.SetActive(true);
        Time.timeScale = 0f;

    }

    public void SetSpawnPos(Vector3 pos)
    {
        spawnPos.position = pos;
    }
}
