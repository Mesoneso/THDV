using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DialogueRange : MonoBehaviour
{
    [SerializeField] private GameObject dialogueWindow;

    private void OnTriggerExit(Collider other)
    {
        dialogueWindow.SetActive(false);
    }
}
