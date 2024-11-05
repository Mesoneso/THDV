using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketsDoor : MonoBehaviour
{
    [SerializeField] private int socketsNeeded;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3 && GameManager.Instance.GetCollectableCounter() == socketsNeeded)
        {
            Destroy(this.gameObject);
        }
    }
}
