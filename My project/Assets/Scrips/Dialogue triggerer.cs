using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Dialoguetriggerer : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject dialogueWindow;
    
    // Start is called before the first frame update
    public void Interact()
    {
        dialogueWindow.SetActive(true);
    }

}
