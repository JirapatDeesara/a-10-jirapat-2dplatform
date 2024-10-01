using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy // แดงเพราะติด Abstract
{
    [SerializeField]private float attackRange;
    // -player: Player
    [SerializeField]private Player player;
    // สร้างกระสุน
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform  bulletSpawnPoint;
    [SerializeField] private float bulletWaitTime;
    [SerializeField] private float bulletTimer;
    //แก้แดง
    // ใส่ Private void Start ใน class ลูกทุกตัว
    private void Start()
    {
        Init(100);
        
    }

    private void FixedUpdate()
    {
        // นับเวลาถอยหลัง Cooldown
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
        //  เช็คระยะโจมตี Attack range
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
