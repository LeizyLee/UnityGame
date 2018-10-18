using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
	void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, movevertical);

        rb.AddForce(movement * speed);

    }
}
