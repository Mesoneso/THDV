using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] private Transform target;
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        quaternion rotation = Quaternion.LookRotation(-direction);
        transform.rotation = rotation;
    }
}
