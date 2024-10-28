using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BeholderManager : MonoBehaviour
{
    [SerializeField] Beholder[] beholders;
    // Start is called before the first frame update

    public bool IsPlayerWatched()
    {
        for (int i = 0; i < beholders.Length; i++)
        {
            if (beholders[i].playerDetected)
            {
                return true;
            } 
            
        }
        return false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
