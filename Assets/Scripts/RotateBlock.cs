using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlock : MonoBehaviour
{
    public float rotateDirection = 1f;
    private float rotateSpeed = 200f;

    [SerializeField] Vector3 rotateVector = new Vector3(0, 0, -1);

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateVector * rotateDirection * rotateSpeed * Time.deltaTime);
    }
}
