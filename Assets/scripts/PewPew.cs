using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewPew : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float muzzleVelocity = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            Vector3 firePosition = transform.position + transform.forward * 1.5f;
            GameObject bullet = GameObject.Instantiate(bulletPrefab,
                firePosition, Quaternion.identity);

            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 bulletForce = transform.forward * muzzleVelocity;
                rb.AddForce(bulletForce, ForceMode.Impulse);
            }
        }
  
    }
}
