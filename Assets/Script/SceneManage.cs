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
        SceneManager.LoadScene("MainMenu");
    }
    public void Exit(){
        Application.Quit();
    }
    public void StartGame(){
        SceneManager.LoadScene("blabal");
    }
    public void retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void CutScene(){
        SceneManager.LoadScene("CutScene_prologe");
        
    }
    public void Map1(){
        SceneManager.LoadScene("Map01");
    }
    public void Map2(){
        SceneManager.LoadScene("Map02");
    }
    public void Map3(){
        SceneManager.LoadScene("Map03_Prototype");
    }
    public void End(){
        SceneManager.LoadScene("CutScene_End");
    }
}
