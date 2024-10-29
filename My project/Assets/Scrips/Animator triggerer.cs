using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatortriggerer : MonoBehaviour, IInteractable
{
    [Serializable]struct TriggerTarget {
        public string animationTrigger;
        public Animator animator;
    }
    [SerializeField] TriggerTarget[] TriggerTargets;

    public void Interact()
    {
        for (int i = 0; i < TriggerTargets.Length; i++)
        {
            TriggerTargets[i].animator.SetTrigger(TriggerTargets[i].animationTrigger);
        }
    }

  
}
