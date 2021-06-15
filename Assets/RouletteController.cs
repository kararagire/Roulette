using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 50;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= Random.Range(0.93f, 1.0f);
    }
}
