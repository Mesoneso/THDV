using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private MeshRenderer model;
    
  

    private void CollectableObject()
    {
        model.enabled = false;
        GameManager.Instance.IncreaseCollectableCounter();
        Destroy(this.gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3 & model.enabled)
        {
            CollectableObject();
        }
    }

    }
