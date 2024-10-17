using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //delay before firing again
    private float fireRate = 1;
    private float nextFire = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog. if enough time passed then you can fire again
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; 
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
