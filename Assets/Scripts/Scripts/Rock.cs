using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon // base class from Weapon
{
    // - rb2d : RigidBody2D
    Rigidbody2D rb2d;
    // - force: Vector2
     Vector2 force;
    void Start()
    {
        Damage = 20;
        force = new Vector2(GetShootDirection() * 100, 400);
        Move();
    } // End Start Rock


    //Method
    // + Move();
    public override void Move()
    {
        //Debug.Log("Rock move with Rigidbody: force");
        rb2d.AddForce(force, ForceMode2D.Impulse);

    } // End Override Move() in Rock

    // + OnHitWith (Character):void
    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(this.Damage);
        }
    } // End OnHitWith method Rock
    // Start 
   

}// End Class Rock