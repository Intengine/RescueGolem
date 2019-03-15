using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemMovement : MonoBehaviour
{
    private Rigidbody golemBody;
    private float moveForce = 10f;

    void Awake()
    {
        golemBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        golemBody.velocity = new Vector3(-h * moveForce, 0f, 0f);
    }
}