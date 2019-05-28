using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour {

    private Transform target;
    public GameObject bulletArme;
    public GameObject impactEffect;
    public float bulletSpeed = 50f;
    public string enemyTag = "Enemy";
    public PlayerWeapon weapon;
    public Tir rotateToMousse;

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] ennemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in ennemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    public void Seek(Transform _target)
    {
        target = _target;
    }

    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletGO = (GameObject)Instantiate(bulletArme, transform.position, transform.rotation);
            BulletTestGun bullet = bulletGO.GetComponent<BulletTestGun>();
            if (bullet != null)
            {
                bullet.Seek(target);
            }
        }
    }
}
