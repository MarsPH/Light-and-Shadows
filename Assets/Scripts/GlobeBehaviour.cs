using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;
using Random = UnityEngine.Random;


public class GlobeBehaviour : MonoBehaviour
{
    public float globeStartTime = 5;
    public float globeRepeatIntervals = 30f;
    
    private float _x;
    private float _z;

    public float minX;
    public float maxX;
    
    public float minZ;
    public float maxZ;
    
    public float speed; 
    private void Awake()
    {
        InvokeRepeating("AssignX", globeStartTime, globeRepeatIntervals);
        InvokeRepeating("AssignZ", globeStartTime, globeRepeatIntervals);
    }
    // ReSharper disable Unity.PerformanceAnalysis
    private void AssignX()
    {
        _x = Random.Range(minX, maxX);
    }

    private void AssignZ()
    {
        _z = Random.Range(minZ, maxZ);
        //Debug.Log(_z);
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(_x, transform.position.y, _z), Time.deltaTime * speed);
    }
}