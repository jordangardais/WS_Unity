using UnityEngine.AI;
using UnityEngine;

public class Target : MonoBehaviour
{
    //public NavMeshAgent agent;
    NavMeshAgent nm;
    public Transform target;
    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject projectile;

    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

   
    
    public Material blue;
    public Renderer fireEnemy;
    public float health = 50f;
    public bool armorBroken; 
    public float healthp = 50f;
    public void TakePower(float amount)
    

    {
        healthp -= amount;
        if (healthp <= 0f)
        {
            armorBroken = true;
            fireEnemy.material = blue;
        }
        
    }
    public void TakeDamage (float amount)
    {
        if (armorBroken) 
        {
            
            health -= amount;
        
        }
        
        if (health <= 0f && healthp <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
    
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        nm.SetDestination(target.position);
    }
    void Update()
    {
        nm.SetDestination(target.position);
        

    }
}