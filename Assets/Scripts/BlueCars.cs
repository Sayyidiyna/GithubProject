using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the blue vehicles forward
        transform.Translate(Vector3.back * Time.deltaTime * 10);
    }
}
