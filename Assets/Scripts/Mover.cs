using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float moveSpeed = 5;

    [SerializeField] Vector3 moveDirection = new Vector3(0, 0, -1);

    // Update is called once per frame
    void Update()
    {
        //this line moves the position down in local space
        //transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        //this line moves the position down in global space
        transform.position += (moveDirection * moveSpeed * Time.deltaTime);
    }
}
