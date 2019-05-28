using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTestGun : MonoBehaviour {

    private Transform target;
    public GameObject impactEffect;
    public float speed = 70f;
    public void Seek(Transform _target)
    {
        target = _target;
    }

    void Update() {

        transform.position += transform.forward * (speed * Time.deltaTime);
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        if (dir.magnitude + 2 <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
    }

    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 3f);
        Destroy(target.gameObject);
        Destroy(gameObject);
        PlayerStat.money += 10;
    }
}
