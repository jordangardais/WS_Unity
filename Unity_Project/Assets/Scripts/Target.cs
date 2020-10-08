
using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 50f;
    
    public float healthp = 50f;
    public void TakePower(float amount)
    {
        healthp -= amount;
        if (healthp <= 0f)
        {
            //set boolean(armorBroken) == true;
        }
        
    }
    public void TakeDamage (float amount)
    {
        //if boolean(armorBroken) == true;
        health -= amount;
        if (health <= 0f && healthp <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}