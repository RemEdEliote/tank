using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletpawnposition;
    public float bulletSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
     private void isTankDetected()
    {
        // RaycastHit hit;
        //Vector3 direction = Vector3.Normalize(r)
    }
    
    
    
    
    void Fire()
    {
        GameObject newBullet = Instantiate(bullet, bulletpawnposition.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
    }
    
    
}
