using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowerSinusoidal : MonoBehaviour
{
    float theta = 0f;
    float amplitude = 1.5f;

    private float scaleSpeed;
    private float scaleIncrement = .05f;

    [SerializeField] Vector3 scaleDirection = new Vector3(1, 1, 1);
    [SerializeField] private Vector3 nowSize;

    private void Start()
    {
        nowSize = transform.localScale;
    }
    // Update is called once per frame
    void Update()
    {

        
        scaleSpeed = Mathf.Sin(theta) * amplitude;

        //transform.localScale = nowSize + (scaleDirection * scaleSpeed * Time.deltaTime);
        transform.localScale += (scaleDirection * scaleSpeed * Time.deltaTime);
        Debug.Log("scale speed is " + scaleSpeed);

        theta += scaleIncrement;
    }

}