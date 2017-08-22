using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverPlayerController : MonoBehaviour
{
    public float Speed = 10f;
    private Rigidbody rb;
    // Use this for initialization
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        float moveHorizontal = Input.GetAxisRaw( "Horizontal" );
        float moveVertical = Input.GetAxisRaw( "Vertical" );

        Vector3 movement = new Vector3( moveHorizontal, 0f, moveVertical );
        rb.AddForce( movement * Speed );
    }
}
