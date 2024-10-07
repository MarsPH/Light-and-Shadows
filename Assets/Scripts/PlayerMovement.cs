using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;

    private Camera _cam;
    private Collider _floorCollider;
    private RaycastHit _hit;

    private void Start()
    {
        _cam = GameObject.Find("Main Camera").GetComponent<Camera>(); //it will set Camera component in obj camera to _cam
        _floorCollider = GameObject.Find("Floor").GetComponent<Collider>(); // it will set collider of floor to the variable
    }

    private void Update()
    {
        if (!Input.GetMouseButton(0)) return;
        Ray ray = _cam.ScreenPointToRay(Input.mousePosition); // it will make a ray from the camera to the position of mouse
        Physics.Raycast(ray, out _hit); //calculate the raycast of ray and store date in _hit

        if (_hit.collider != _floorCollider) return; // one of _hit data is the collider that hit

        transform.position = Vector3.MoveTowards(transform.position, _hit.point, Time.deltaTime * movementSpeed); // For moving from obj
        transform.LookAt(new Vector3(_hit.point.x, transform.position.y, _hit.point.z));// For direction

        
    }
}