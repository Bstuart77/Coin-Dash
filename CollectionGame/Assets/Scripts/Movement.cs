using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float moveSpeed = 20f;
    private Rigidbody rb;

    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * (moveSpeed * Time.deltaTime), 0f, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        rb.MovePosition(transform.position + movement);


    }
}
