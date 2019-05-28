using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour {
    public Camera cam;
    public float MaximumLenght;
    private Ray rayMouse;
    private Vector3 pos;
    private Vector3 direction;
    private Quaternion rotation;

    void Update () {
        RaycastHit hit;
        var mousePos = Input.mousePosition;
        rayMouse = cam.ScreenPointToRay(mousePos);
        Debug.DrawRay(transform.position, direction, Color.red);    
        if (Physics.Raycast(rayMouse.origin, rayMouse.direction, out hit, MaximumLenght))
       {
           RotateToMouseDirection(gameObject, hit.point);
       }
	}
    void RotateToMouseDirection(GameObject obj, Vector3 destination)
    {
        direction = destination - obj.transform.position;
        rotation = Quaternion.LookRotation(direction);
    }
    public Quaternion GetRotation()
    {
        return rotation;
    }
}
