using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Crocodile : Enemy, IShootable // แดงเพราะติด Abstract
{
    [field: SerializeField]
    float attackRange;
    public float AttackRange { get { return attackRange; } set { attackRange = value; } }
    // -player: Player
    [SerializeField]private Player player;
    // สร้างกระสุน
    [field: SerializeField]
    GameObject bullet;
    public GameObject Bullet { get { return bullet; } set { bullet = value; } }
    [field : SerializeField]
    Transform bulletSpawnPoint;
    public Transform BulletSpawnPoint { get { return bulletSpawnPoint; } set { bulletSpawnPoint = value; } }
    [field : SerializeField]public float bulletWaitTime { get; set; }
     [field : SerializeField]public float bulletTimer { get; set; }
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
    public void Shoot()
    {
        if (bulletTimer < 0)
        {
            bullet = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
            
        } // End if bulletTimer
       
    }
}// End Crocodile
