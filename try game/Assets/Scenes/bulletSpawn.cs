using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawn : MonoBehaviour
{
    

        public float force=1000f;
        public GameObject bulletPrefab;
        public GameObject gunEnd;
        private Vector3 aim;

        // Update is called once per frame
        void Update()
        {

        Vector3 mousePos = Input.mousePosition;
        mousePos += Camera.main.transform.forward * 10f; // Make sure to add some "depth" to the screen point
        aim = Camera.main.ScreenToWorldPoint(mousePos);



        if (Input.GetKey(KeyCode.Mouse0))
        {
            gunEnd.transform.LookAt(aim);

            GameObject bullet = Instantiate(bulletPrefab, gunEnd.transform.position, Quaternion.identity);

            bullet.transform.LookAt(aim);


            Rigidbody b = bullet.GetComponent<Rigidbody>();
            b.AddRelativeForce(-transform.forward * force);

        }
    }

    }


