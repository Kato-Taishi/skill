using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody rb;
    float moveSpeed = 7; 
    public GameObject gameOverText;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 v = rb.velocity;
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    v.x = moveSpeed;
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    v.x = -moveSpeed;
        //}
        //else
        //{
        //    v.x = 0;
        //}
        v.x = moveSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            v.y = 16;
        }

         rb.velocity = v;

        Vector3 position = transform.position;
        if (position.y <-10)
        {
            gameOverText.SetActive(true);
            position.y = -10;
            transform.position = position;
            rb.velocity = Vector3.zero;
            moveSpeed = 0;
            
        }
       
    }                                                                                       
}
