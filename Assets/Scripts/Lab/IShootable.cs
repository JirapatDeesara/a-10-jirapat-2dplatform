using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    GameObject Bullet { get; set; }
    Transform BulletSpawnPoint { get; set; }
    float bulletWaitTime { get; set; }
    float bulletTimer { get; set; }

    void Shoot();

}
