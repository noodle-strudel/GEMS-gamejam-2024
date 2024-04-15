using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour
{

    public string sceneName;
    public string credit;
    public string title;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }


    public void creditScene()
    {
        SceneManager.LoadScene(credit);
    }


    public void titleScreen()
    {
        SceneManager.LoadScene(title);
    }


    public void exitGame()
    {
        Application.Quit();
    }
}
