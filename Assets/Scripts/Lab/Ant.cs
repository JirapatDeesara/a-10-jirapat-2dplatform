using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy // Ant ᴧ��������� Abstract 
{
    // - velocity: Vector2
    [SerializeField]private Vector2 velocity;
    //-movePoints: Transform[]
    // TransForm[] �͡ Position ���˹�� Unity ����÷���� array ����� s ����
    [SerializeField]private Transform[] movePoints;

    // ��� Private void Start � class �١�ء���
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
    }// End Ant FixedUpdate = Run consisntant ��������

    // ��С������� override �Ѻ Abstract 㹵���١
    public override void Behaviour()
    {
        // ������Թ�·�� Rb = �� Physic 㹡���Թ
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        //Check ���˹� ��Ҷ֧�����������¹���˹�
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
      // �������ǵ���Ф�
      velocity.x *= -1;

      // ��Ѻ��ҧ����Ф�
      Vector2 charScale = transform.localScale;
      charScale.x *= -1;
      transform.localScale = charScale;
    }// End Flip 
}// End Ant
