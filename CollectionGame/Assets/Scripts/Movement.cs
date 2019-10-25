using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float moveSpeed = 200f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        rb.MovePosition(transform.position + movement);
    }
}
