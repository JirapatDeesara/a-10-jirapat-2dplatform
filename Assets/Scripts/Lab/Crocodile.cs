using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy // ᴧ���еԴ Abstract
{
    [SerializeField]private float attackRange;
    // -player: Player
    [SerializeField]private Player player;
    // ���ҧ����ع
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform  bulletSpawnPoint;
    [SerializeField] private float bulletWaitTime;
    [SerializeField] private float bulletTimer;
    //��ᴧ
    // ��� Private void Start � class �١�ء���
    private void Start()
    {
        Init(100);
        
    }

    private void FixedUpdate()
    {
        // �Ѻ���Ҷ����ѧ Cooldown
        bulletTimer -= Time.deltaTime;
        Behaviour();

        if (bulletTimer < 0)
        {
            bulletTimer = bulletWaitTime;
        }
    }// End Crocodile FixedUpdate
    public override void Behaviour()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;
        //  ���������� Attack range
        if (distance < attackRange)
        {
            Shoot();
        }
    }// End Override
    private void Shoot()
    {
        if (bulletTimer < 0)
        {
            bullet = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
        } // End if bulletTimer
       
    }
}// End Crocodile
