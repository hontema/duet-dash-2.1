using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : MonoBehaviour
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

