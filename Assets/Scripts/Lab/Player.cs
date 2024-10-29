using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField]
    GameObject bullet;
    public GameObject Bullet { get { return bullet; } set { bullet = value; } }
    [field: SerializeField]
    Transform bulletSpawnPoint;
    public Transform BulletSpawnPoint { get { return bulletSpawnPoint; } set { bulletSpawnPoint = value; } }
    [field: SerializeField] public float bulletWaitTime { get; set; }
    [field: SerializeField] public float bulletTimer { get; set; }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && bulletWaitTime >= bulletTimer)
        {
            Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
        }// Input = get keyboard/mouse input to click
    }

    void Start()
    {
        Init(100);
        bulletWaitTime = 0.0f;
        bulletTimer = 1.0f;
    }

    void Update()
    {
        Shoot();
    }
    private void FixedUpdate()
    {
        // นับเวลาถอยหลัง Cooldown
        bulletTimer -= Time.deltaTime;
    }
}// End Player
