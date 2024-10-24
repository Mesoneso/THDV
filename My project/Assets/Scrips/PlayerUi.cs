using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] FirstPersonLook fpsLook;
    [SerializeField] private Beholder beholder;
    [SerializeField] private GameObject openEyes;

    private bool isInPause = false;

   

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            isInPause = !isInPause;
            
            pauseMenu.SetActive(isInPause);

            if (isInPause)
            {
                Time.timeScale = 0;
                fpsLook.enabled = false;
            }
            else 
            { 
                Time.timeScale = 1;
                fpsLook.enabled = true;
            }
        }
        if (beholder.playerDetected == true)
        {
            openEyes.SetActive(true);
        }
        else 
        {
            openEyes.SetActive(false);
        }

    }
}
