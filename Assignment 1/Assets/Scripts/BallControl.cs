using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate is called zero, once, or multiple times per frame
    // Suitable for physics-related functions
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            other.gameObject.SetActive(false);
            CameraControl.CameraChange();
        }
        else if (other.gameObject.CompareTag("Token"))
        {
            other.gameObject.SetActive(false);
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
