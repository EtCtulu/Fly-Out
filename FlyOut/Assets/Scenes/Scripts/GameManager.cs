using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool paused = false;

    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(paused == false){
                PauseGame();
            }
            else{
                ResumeGame();
            }
        }
    }

    public void PauseGame(){
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        paused = true;
    }

    public void ResumeGame(){
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        paused = false;
    }
    
    public void QuitGame(){
        Application.Quit();
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    }

    public void PlayGame(){
        SceneManager.LoadScene(1);
    }
}
