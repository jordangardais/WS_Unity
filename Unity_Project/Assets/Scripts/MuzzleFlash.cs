using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour
{
    public ParticleSystem Flash;
    void Start()
    {
        
    }
    void Marche()
    {
         Flash.Play();
    }
    
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) Flash.Play();
    }
}
