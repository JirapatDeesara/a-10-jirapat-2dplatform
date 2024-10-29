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
        Debug.Log("Banana move with constant speed using Transform");
    }// End Override Move() in Banana
    public override void OnHitWith(Character B)
    {

    } // End OnHitWith method Banana
    // Start 
    void Start()
    {
        Damage = 30;
        speed = 4f;
        Move();
    }// End Start Banana

}// End Class Banana

