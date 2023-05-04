using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlclick : MonoBehaviour
{
    public GameObject girlGo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 girlScreenPos = Input.mousePosition;
            Vector2 girlWorldPos = Camera.main.ScreenToWorldPoint(girlScreenPos);
            girlGo.GetComponent<girl>().moveGirl(girlWorldPos);
            //girl.instance.moveMouse(girlWorldPos);
        }
    }
}
