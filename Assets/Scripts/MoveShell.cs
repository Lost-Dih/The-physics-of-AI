using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShell : MonoBehaviour 
{
    float speed = 1.0f;

    void Start()
    {
        
    }

    void Update() 
    {
        this.transform.Translate(0, Time.deltaTime * 0.5f, Time.deltaTime * speed);
    }
}
