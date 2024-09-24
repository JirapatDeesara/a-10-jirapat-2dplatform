using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    // ตั้งค่าพวก Attributes ที่เป็น pubic ex: +Health: int {get; set;}
    private int health;
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
      return  Health <= 0; // ตายยัง???ถ้าน้อยกว่าหรือเท่ากับ 0 คือ ตุยเย่   
    }// End Method IsDead
    // +TakeDamage(int):void
    public void TakeDamage(int damage)
    { 
    Health -= damage;   
    }//End Method TakeDamage
}//End abstract
