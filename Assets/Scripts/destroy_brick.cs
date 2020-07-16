using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_brick : MonoBehaviour
{

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
