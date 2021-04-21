using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour , IDamageable
{
    public float GetHealth => currentHealth;
    public float MaxHealth => totalHealth;

    [SerializeField] private float currentHealth;
    [SerializeField] private float totalHealth;

    protected virtual void Start()
    {
        currentHealth = totalHealth;
    }
    public virtual void Destroy()
    {
        Destroy(gameObject); 
        throw new System.NotImplementedException();
    }

    public virtual void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Destroy();
        }
       // throw new System.NotImplementedException();
    }

 
}
