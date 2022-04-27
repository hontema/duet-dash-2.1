using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float rotateDirection = 0f;
    private float rotateSpeed = 2f;

    [SerializeField] Vector3 rotateVector = new Vector3(0, 0, -1);

    public UserInput ui;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateVector * rotateDirection * rotateSpeed);
    }
}
