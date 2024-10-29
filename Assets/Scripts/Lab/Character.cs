using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    // สร้าง Constructor เป็น Intialize = public void Character(int newHp){ Hp = new Hp;} 

    // ตั้งค่าพวก Attributes ที่เป็น pubic ex: +Health: int {get; set;}
    // [SerializeField] = Attribute ทำหน้าที่ให้ Private เห็นได้ใน Inspector
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
    public Animator anim;
    // +rb: RigidBody2D
    public Rigidbody2D rb;

    //Method
    // +IsDead(): bool
    public bool IsDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        } 
      else return false; // ตายยัง???ถ้าน้อยกว่าหรือเท่ากับ 0 คือ ตุยเย่   
    }// End Method IsDead
    // +TakeDamage(int):void
    public void TakeDamage(int damage)
    { 
    Health -= damage;
        
        IsDead();

    }//End Method TakeDamage

    public void Init(int newHealth)
    {
        Health = newHealth;
    } // End Health constructor
}//End abstract
