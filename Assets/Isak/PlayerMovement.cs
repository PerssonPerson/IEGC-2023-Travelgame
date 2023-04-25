using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    GameObject plane;
    public float movespeed = 2.5f;
    public Rigidbody rigidbody;

    void FixedUpdate()
    {
        bool isShiftKeyDown = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        Vector3 moveVector = new Vector3(0, 0, 0);
        moveVector.x += (-1 * Convert.ToInt32(Input.GetKey(KeyCode.A) && transform.position.x > -(plane.transform.localScale.x / 2)+1)) + Convert.ToInt32(Input.GetKey(KeyCode.D) && transform.position.x < (plane.transform.localScale.x / 2) - 1);
        moveVector.z += (-1 * Convert.ToInt32(Input.GetKey(KeyCode.S) && transform.position.z > -(plane.transform.localScale.z / 2)+0.2f)) + Convert.ToInt32(Input.GetKey(KeyCode.W) && transform.position.z < (plane.transform.localScale.z / 2) - 0.2f);
        rigidbody.MovePosition(transform.position + moveVector * (movespeed * (1 + Convert.ToInt32(isShiftKeyDown))) * Time.deltaTime);
    }
}
