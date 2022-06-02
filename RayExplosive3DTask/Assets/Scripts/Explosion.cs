using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    
    [SerializeField] GameObject button;
    public bool buttonTriggered = false;

    public void Update()
    {
       
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == button)
        { 
            buttonTriggered = true;
        }
    }


}
