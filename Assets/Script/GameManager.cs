using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public GameObject deadUI;
    public GameObject passUI;

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

    }
    void Start()
    {
        requiredkey = 2;
    }

    void Update()
    {
       // Debug.Log(key.Count);
       
    }
    public void dead()
    {
        deadUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void  pass()
    {
        passUI.SetActive(true);
        Time.timeScale = 0f;

    }
}
