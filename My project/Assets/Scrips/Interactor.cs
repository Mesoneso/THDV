using System.Collections;
using System.Collections.Generic;
using UnityEngine;


interface IInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    [SerializeField] Transform InteractorSource;
    public PlayerDataSO playerData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E pressed");
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, playerData.InteractRange))
            {
                Debug.Log("Objetc detected");
                IInteractable[] interactables = hitInfo.collider.gameObject.GetComponents<IInteractable>();
                for (int i = 0; i < interactables.Length; i++)
                {
                    Debug.Log("Interaction sent");
                    interactables[i].Interact();
                }

            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(InteractorSource.position, InteractorSource.forward * playerData.InteractRange);
    }
}
