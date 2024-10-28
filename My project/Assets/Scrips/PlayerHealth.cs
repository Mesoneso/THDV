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
    private float timer = 0;
    private bool isBeingWatched = false;
    public float HealthPer => health/(float)maxHealth;

    public void Damage(int damage)
    {
        health -= damage;
        timer = healthRegenTime;
        if (health <= 0)
        {
            health = 0;
        }
    }

    public void Watched()
    {
        isBeingWatched=true;
    }
   
  private void Update()
    {
        
        Debug.Log(health);
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0 && health < maxHealth)
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
