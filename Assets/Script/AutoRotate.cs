using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void FixedUpdate()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.fixedDeltaTime);
    }
}
