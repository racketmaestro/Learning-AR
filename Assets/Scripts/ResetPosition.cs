using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("aeroplanewall"))
        {
            transform.localPosition = originalPos;
        }
    }
}

