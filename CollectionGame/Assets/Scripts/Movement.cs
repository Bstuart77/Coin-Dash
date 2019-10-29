﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float moveSpeed = 200f;
    private Rigidbody rb;
    public int points = 0;

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
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 200), "Score " + points);
    }
}
