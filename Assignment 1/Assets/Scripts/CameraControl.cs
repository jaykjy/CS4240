using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ball;
    private static Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ball.transform.position;
    }

    // LateUpdate is called once all methods in Update are called
    void LateUpdate()
    {
        transform.position = ball.transform.position + offset;
    }

    public static void CameraChange()
    {
        offset = new Vector3(offset.x, offset.y + 1, offset.z);
    }
}
