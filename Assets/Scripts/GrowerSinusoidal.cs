using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowerSinusoidal : MonoBehaviour
{

    private float scaleSpeed = 5;

    private bool getSmaller = false;

    [SerializeField] Vector3 scaleDirection = new Vector3(1, 1, 1);

    [SerializeField] private Vector3 maxSize = new Vector3(2, 2, 2);
    [SerializeField] private Vector3 minSize = new Vector3(1, 1, 1);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //sucks to suck
        IsGettingSmaller();
        IsGettingBigger();

    }

    void IsGettingBigger()
    {
        if (getSmaller == false)
        {
            if (transform.localScale.x < maxSize.x)
            {
                transform.localScale += (scaleDirection * scaleSpeed * Time.deltaTime);
            }
            if (transform.localScale.x > maxSize.x)
            {
                getSmaller = true;
            }
        }
    }

    void IsGettingSmaller()
    {
        if (getSmaller == true)
        {
            if (transform.localScale.x < minSize.x)
            {
                getSmaller = false;
            }
            if (transform.localScale.x > minSize.x)
            {
                transform.localScale -= (scaleDirection * scaleSpeed * Time.deltaTime);
            }
        }
    }
}

/*
 float theta = 0.0;
float amplitude = 75.0;
float yvalues;

void setup() {
  size(640, 360);
}

void draw() {
  background(0);

  theta += 0.02;
    yvalues = cos(theta)*amplitude;
    
      noStroke();
  fill(255);
    ellipse(10, height/2+yvalues, 16, 16);
}
 */