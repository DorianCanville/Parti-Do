using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectiles : MonoBehaviour
{
    public RotateToMouse rotateToMouse;
    public GameObject firePoint;
    public List<GameObject> vfx = new List<GameObject>();
    private GameObject effectToSpawn;
    private float timeToFire = 0f;
    void Start () {
        effectToSpawn = vfx[0];
	}
	void Update () {
        if (Input.GetMouseButton(0) && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1 / effectToSpawn.GetComponent<ProjectilesMove>().fireRate;
            SpawnVFX();
        }
	}
    void SpawnVFX()
    {
        GameObject vfx;
        vfx = Instantiate(effectToSpawn, firePoint.transform.position, Quaternion.identity);
        if (rotateToMouse != null)
        {
            vfx.transform.localRotation = rotateToMouse.GetRotation();
        }
    }
}
