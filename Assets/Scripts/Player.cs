using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 1f;
    public bool isDead = false;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpVector = new Vector3(0, jumpForce, 0);
            rb.AddForce(jumpVector);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isDead = true;
        gameObject.SetActive(false);
    }
}
