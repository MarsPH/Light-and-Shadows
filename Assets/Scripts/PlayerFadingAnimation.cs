using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFadingAnimation : MonoBehaviour
{
    private Animation _animation;

    private void Start()
    {
        _animation = GameObject.Find("PlayerLight").GetComponent<Animation>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //_animation.enabled = true;
            _animation.Play();
            Debug.Log("PlayerFadingAnimation OnTriggerExit");
        }
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //_animation.enabled = false;
            _animation.Stop();
        }
    }
    
}
