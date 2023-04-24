using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 2.5f;
    public Rigidbody rigidbody;
    bool[] holdkey = new bool[4];

    void FixedUpdate()
    {
        bool isShiftKeyDown = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        Vector3 moveVector = new Vector3(0, 0, 0);
        moveVector.x += (-1 * Convert.ToInt32(Input.GetKey(KeyCode.A))) + Convert.ToInt32(Input.GetKey(KeyCode.D));
        moveVector.z += (-1 * Convert.ToInt32(Input.GetKey(KeyCode.S))) + Convert.ToInt32(Input.GetKey(KeyCode.W));
        rigidbody.MovePosition(transform.position + moveVector * (movespeed * (1 + Convert.ToInt32(isShiftKeyDown))) * Time.deltaTime);
    }
}
