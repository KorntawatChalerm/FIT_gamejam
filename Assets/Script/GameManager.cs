using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    
    public bool ispause ;
    public Text timerUI;
    public GameObject pauseUI;
    public GameObject passUI;
    public Transform spawnPos;
    public static int requiredkey;
    public int timercount;
    public GameObject onestar;
    public GameObject twostar;
    public GameObject threestar;

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
          //DontDestroyOnLoad(gameObject);

        SetSpawnPos(spawnPos.position);
        ispause = false;
        Time.timeScale = 1f;


    }
    void Start()
    {
        requiredkey = 2;
        StartCoroutine(countdown());
        
    }

    void Update()
    {
       timerUI.text = "Time : "+ timercount.ToString();
       
    
       if ((Input.GetKeyDown("escape")) && ispause == false ){
        Debug.Log("pasuuuu");
        pause();
       }else if ((Input.GetKeyDown("escape")) && ispause == true) {
        Debug.Log("resu");
        resume();
       }
    }
   
    public void pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        ispause = true;
    }
    public void resume(){
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        ispause = false;
    }
    public void  pass()
    {
        passUI.SetActive(true);
        
        Time.timeScale = 0f;
        if (timercount <= 12){
            threestar.SetActive(true);
            twostar.SetActive(true);
            onestar.SetActive(true);
        }else if (timercount <= 15){
            twostar.SetActive(true);
            onestar.SetActive(true);
        }else {
            onestar.SetActive(true);
        }
    }

    public void SetSpawnPos(Vector3 pos)
    {
        spawnPos.position = pos;
    }

    IEnumerator countdown(){
        while(true){
            yield return new WaitForSeconds(1);
            timercount++;
        }
    }
}
