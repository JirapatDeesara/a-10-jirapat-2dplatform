using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy // Ant á´§à¾ÃÒÐÇèÒÁÕ Abstract 
{
    // - velocity: Vector2
    [SerializeField] private Vector2 velocity;
    //-movePoints: Transform[]
    // TransForm[] ºÍ¡ Position µÓáË¹è§ã¹ Unity µÑÇá»Ã·Õèà»ç¹ array ¨ÐàµÔÁ s ´éÇÂ
    [SerializeField] private Transform[] movePoints;

    // ãÊè Private void Start ã¹ class ÅÙ¡·Ø¡µÑÇ
    private void Awake()
    {
        Init(30);
        healthBar.SetMaxHealth(100);
    }
    private void Start()
    {
        // <> generic , () parameter
        rb = GetComponent<Rigidbody2D>();
        


    }// End start

    private void FixedUpdate()
    {
        Behaviour();
    }// End Ant FixedUpdate = Run consisntant ÊÁèÓàÊÁÍ

    // »ÃÐ¡ÒÈãËéãªé override ·Ñº Abstract ã¹µÑÇÅÙ¡
    public override void Behaviour()
    {
        // ãËéÁ´à´Ô¹â´Â·Õè Rb = ãªé Physic ã¹¡ÒÃà´Ô¹
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        //Check µÓáË¹è§ ¶éÒ¶Ö§áÅéÇãËéà»ÅÕèÂ¹µÓáË¹è§
        if (rb.position.x <= movePoints[0].position.x && velocity.x < 0)
        {
            FlipCharacter();
        } // End movepoint < 0

        else if (rb.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            FlipCharacter();
        } // End movepoint > 0
    }// end override Behaviour

    private void FlipCharacter()
    {
        // ¤ÇÒÁàÃçÇµÑÇÅÐ¤Ã
        velocity.x *= -1;

        // ¡ÅÑº¢éÒ§µÑÇÅÐ¤Ã
        Vector2 charScale = transform.localScale;
        charScale.x *= -1;
        transform.localScale = charScale;
    }// End Flip 
}// End Ant