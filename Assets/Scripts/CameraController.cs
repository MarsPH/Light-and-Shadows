using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float distance;
    public Vector3 offset;
    
    public float smoothTime = 0.25f;
    
    private Vector3 _currentVelocity;
    private Vector3 _targetPosition;

    private void LateUpdate()
    {
        _targetPosition = player.position + (transform.position - player.position).normalized * distance;
        transform.position = Vector3.SmoothDamp(transform.position, _targetPosition, ref _currentVelocity, smoothTime);
    }


}
