using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonText : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
        }
    }
}
