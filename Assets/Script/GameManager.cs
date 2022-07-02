using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager instance;
    public GameObject deadUI;
    public GameObject passUI;

    public int requiredkey;

    public List<GameObject> key;


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
        
    }

    void Update()
    {
        if (requiredkey == key.Count)
        {
            pass();
        }
    }
    void dead()
    {
        deadUI.SetActive(true);
        Time.timeScale = 0f;
    }
    void pass()
    {
        passUI.SetActive(true);
        Time.timeScale = 0f;

    }
}
