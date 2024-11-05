using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerDataSO playerData;
    [SerializeField] int health = 1000;
    
    
    private float timer = 0;
    
    public float HealthPer => health/(float)playerData.maxHealth;

    [SerializeField] private Transform spawnLocation;

    public void Damage(int damage)
    {
        health -= damage;
        timer = playerData.healthRegenTime;
        if (health <= 0)
        {
            
            transform.position = spawnLocation.position;
            health = playerData.maxHealth;
        }
    }

    
   
  private void Update()
    {
        
        
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0 && health < playerData.maxHealth)
        {
            health += playerData.healthRegenValue;
        }


      
    }
    IEnumerator Regeneration()
    {
        health += playerData.healthRegenValue;
        yield return new WaitForSeconds(playerData.healthRegenTime);
    }
    
}
