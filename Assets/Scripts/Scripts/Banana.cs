
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Banana : Weapon // base class from Weapon
{

    // - speed: float
    // SerializeField  Unity
    [SerializeField] private float speed;


    //Method
    // + Move(): void
    public override void Move()
    {
        // Debug.Log("Banana move with constant speed using Transform");
        // s = vt aka distance = speed * time
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
    }// End Override Move() in Banana
    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
            character.TakeDamage(this.Damage);
        
        return;
    } // End OnHitWith method Banana
    // Start 
    void Start()
    {
        Damage = 10;
        speed = 4.0f * GetShootDirection();

    }// End Start Banana
    private void FixedUpdate()
    {
        Move();
    }
}// End Class Banana
