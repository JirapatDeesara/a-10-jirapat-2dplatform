using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    // ��駤�Ҿǡ Attributes ����� pubic ex: +Health: int {get; set;}
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
      return  Health <= 0; // ����ѧ???��ҹ��¡���������ҡѺ 0 ��� ������   
    }// End Method IsDead
    // +TakeDamage(int):void
    public void TakeDamage(int damage)
    { 
    Health -= damage;   
    }//End Method TakeDamage
}//End abstract
