using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 1.0f;
    public float waitTime = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // update timer
        timer += Time.deltaTime;
        // On spacebar press and timer is bigger than wait time, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timer >= waitTime)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = 0;
            }
        }
    }
}
