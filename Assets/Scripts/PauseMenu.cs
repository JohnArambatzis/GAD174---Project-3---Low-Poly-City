using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;

    public GameObject pausePanel;
    

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Time.timeScale > 0 && isPaused == true)
        {
            isPaused = false;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        if (Time.timeScale == 0 && isPaused == false)
        {
            isPaused = true;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }


        if (Input.GetKeyDown(KeyCode.Tab) && !isPaused)
        {
            Time.timeScale = 0;

            pausePanel.SetActive(true);
            
        }
    }

    public void ContinueButton()
    {
        Time.timeScale = 1;

        pausePanel.SetActive(false);
        
    }
}
