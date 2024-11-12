using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{

    [SerializeField] private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }
    // +anim: Animator
    public Animator animator;
    // +rb: RigidBody2D
    public Rigidbody2D rb;

    public HealthBar healthBar;
    public int currentHealth;
    //Method
    // +IsDead(): bool
    public bool IsDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else return false;  
    }// End Method IsDead
    // +TakeDamage(int):void
    public void TakeDamage(int damage)
    {
        Health -= damage;
        healthBar.SetHealth(Health);
        Debug.Log($"{this.name} take {damage} damage, Remaining HP : {this.Health}");
        IsDead();

    }//End Method TakeDamage

    public virtual void Init(int newHealth)
    {
        Health = newHealth;
        healthBar.SetMaxHealth(newHealth);
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    } // End Health constructor
}//End abstract