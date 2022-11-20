using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x,
            Mathf.Sin(Time.realtimeSinceStartup * 2) * 0.15f + 0.15f + originalPosition.y,
            transform.localPosition.z);
    }
}
