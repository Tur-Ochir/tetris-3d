using System;
using UnityEngine;

public class TetrisBlock : MonoBehaviour
{
    public float fallSpeed = 1f;
    private Vector3 inputVector;
    private bool active = true;

    void Update()
    {
        if (!active)
            return;
        
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.A))
            transform.position += Vector3.left;
        if (Input.GetKeyDown(KeyCode.D))
            transform.position += Vector3.right;
        if (Input.GetKeyDown(KeyCode.W))
            transform.position += Vector3.forward;
        if (Input.GetKeyDown(KeyCode.S))
            transform.position += Vector3.back;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Floor"))
        {
            Placed();
        }
    }

    private void Placed()
    {
        active = false;
    }
}