using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

    [SerializeField] float rotateDirection = 1;
    
    public Rotator rot;

    // Update is called once per frame
    void Update()
    {
        rotateDirection = Input.GetAxisRaw("Horizontal");
        controller(rotateDirection);
    }

    private void controller(float rspeed)
    {
        rot.rotateDirection = rotateDirection;
    }
}

