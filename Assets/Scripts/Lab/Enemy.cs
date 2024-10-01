using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    // +DamageHit: int {get; set;}

    private int damageHit;
    public int DamageHit 
    {
        get 
        {
            return damageHit;
        }
        set
        { 
           damageHit = value;
        }
    }
    // อันนี้ตัวเอียงเป็น Abstract + Behaviour:void

    private void Start()
    {
        Behaviour(); // เรียกได้เพราะว่าเป็น class แม่ ถ้าเรียกในไหนจะเป็นใน Obj นั้น
    }// end Start ให้ code มันรัน
    public abstract void Behaviour();
    // Abstract ไม่มี Body {} เพราะว่าให้ตัวที่สืบทอดไปทำเอง เช่น แม่ทำพินัยกรรมให้ลูกทำตาม แม่ทำไม่ได้เพราะว่า Rip
    // อยากกินไก่ย่างห้าดาว

} // End Enemy
