using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public Rigidbody rb;
    float moveSpeed = -4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = rb.velocity;

        v.x = moveSpeed;
        rb.velocity = v;
    }
}
