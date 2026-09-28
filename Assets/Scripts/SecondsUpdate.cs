using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{

    float timeStartOffset = 0;
    bool goStartTime = false;
    public float speed = 0.5f;

    void Update()
    {
        if(!goStartTime)
        {
            timeStartOffset = Time.realtimeSinceStartup;
            goStartTime = true;
        }
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, Time.realtimeSinceStartup - timeStartOffset * speed);
    }
}
