using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public GameObject head;
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

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            head.transform.LookAt(hit.point);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0f,0f,2f * Time.deltaTime );
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -2f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f * Time.deltaTime, 0.5f, 0f);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f * Time.deltaTime, -0.5f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        
        
    }

    void Fire()
    {
        GameObject newBullet = Instantiate(bullet, bulletpawnposition.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
    }
    
    
    
    
    
    
    
}
