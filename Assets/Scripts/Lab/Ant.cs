using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy // Ant แดงเพราะว่ามี Abstract 
{
    // - velocity: Vector2
    [SerializeField]private Vector2 velocity;
    //-movePoints: Transform[]
    // TransForm[] บอก Position ตำแหน่งใน Unity ตัวแปรที่เป็น array จะเติม s ด้วย
    [SerializeField]private Transform[] movePoints;

    // ใส่ Private void Start ใน class ลูกทุกตัว
    private void Start()
    { 
        // <> generic , () parameter
        rb = GetComponent<Rigidbody2D>();
        Init(10);
        Debug.Log(Health);

       
    }// End start

    private void FixedUpdate()
    {
        Behaviour();
    }// End Ant FixedUpdate = Run consisntant สม่ำเสมอ

    // ประกาศให้ใช้ override ทับ Abstract ในตัวลูก
    public override void Behaviour()
    {
        // ให้มดเดินโดยที่ Rb = ใช้ Physic ในการเดิน
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        //Check ตำแหน่ง ถ้าถึงแล้วให้เปลี่ยนตำแหน่ง
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
      // ความเร็วตัวละคร
      velocity.x *= -1;

      // กลับข้างตัวละคร
      Vector2 charScale = transform.localScale;
      charScale.x *= -1;
      transform.localScale = charScale;
    }// End Flip 
}// End Ant
