using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubebehaviour : MonoBehaviour
{ public Vector3 Vec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { Vec = transform.localPosition;

        if(Vec.x>=3||Vec.x<=-3)
        {if (Vec.x >= 3)
            { Vec.x=Vec.x-0.5f; }
        else { Vec.x = Vec.x + 0.5f; ; }
        }
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;
        Vec.x += Input.GetAxis("Horizontal")*Time.deltaTime * 20;
        Vec.z += Input.GetAxis("Vertical")*Time.deltaTime * 20;
        
        transform.localPosition=Vec;

    }
}
