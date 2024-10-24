using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEngine.GraphicsBuffer;

public class Beholder : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float visionRange = 15;
    [SerializeField] private int damage = 10;
    public bool playerDetected = false;


    private void Update()
    {
     
        transform.LookAt(player.position);

        RaycastHit hit;
       
        if (Physics.Raycast(transform.position, transform.forward, out hit, visionRange))
        {
            if (hit.transform.TryGetComponent<PlayerHealth>(out var playerHealth))
            {
                playerHealth.Damage(damage);
                playerHealth.Watched();
            }

           float distance = Vector3.Distance(transform.position, hit.transform.position);
            Debug.DrawRay(transform.position, transform.forward * distance, color: Color.red);
        }
        else
        {
            
            Debug.Log("no se ve el jugador");
        }

    }
}
 //transform.TransformDirection(Vector3.forward)