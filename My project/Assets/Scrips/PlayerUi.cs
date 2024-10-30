using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] FirstPersonLook fpsLook;
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Image healthImg;
    [SerializeField] private Color fullHealthColor;
    [SerializeField] private Color noHealthColor;
    [SerializeField] private BeholderManager beholderManager;
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
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else 
            { 
                Time.timeScale = 1;
                fpsLook.enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
      
            openEyes.SetActive(beholderManager.IsPlayerWatched());
      

        healthImg.color = Color.Lerp(noHealthColor, fullHealthColor, playerHealth.HealthPer);
    }
}
