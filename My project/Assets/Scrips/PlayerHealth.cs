using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health = 300;
    [SerializeField] int healthRegenTime = 3;
    [SerializeField] int healthRegenValue = 1;
    [SerializeField] int maxHealth = 300;
    private bool beingSeen;
    public void Damage(int damage)
    {
        
        health -= damage;
    }
    public void OnBeholderView(bool beingSeen)
    {
      this.beingSeen = beingSeen;
    }
  private void Update()
    {
        Debug.Log(health);
        if (!beingSeen && health < maxHealth)
        {
            health += healthRegenValue;

        }
      
    }
    IEnumerator Regeneration()
    {
        health += healthRegenValue;
        yield return new WaitForSeconds(healthRegenTime);
    }
    
}
