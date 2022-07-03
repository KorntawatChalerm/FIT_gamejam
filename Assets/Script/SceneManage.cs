using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManage : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void MainMenu(){
        SceneManager.LoadScene("dsa");
    }
    public void Exit(){
        Application.Quit();
    }
    public void StartGame(){
        SceneManager.LoadScene("blabal");
    }
    public void LoadNextScene(){
        SceneManager.LoadScene("vd");
    }
}
