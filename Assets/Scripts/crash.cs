using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.contacts[0].point);
        //Debug.Log(collision.transform.position);
        //Debug.Log(transform.position);
        if (collision.gameObject.CompareTag("bar"))
        {
            GameObject.FindGameObjectWithTag("ball").GetComponent<ball_move>().ball_rotation((float)collision.transform.position.x - collision.contacts[0].point.x);
        }
        else
        {
            if (collision.contacts[0].point.x - transform.position.x > 0.1 || collision.contacts[0].point.x - transform.position.x < -0.1)
            {
                GameObject.FindGameObjectWithTag("ball").GetComponent<ball_move>().horizontal_rev();
            }
            if (collision.contacts[0].point.y - transform.position.y > 0.1 || collision.contacts[0].point.y - transform.position.y < -0.1)
            {
                GameObject.FindGameObjectWithTag("ball").GetComponent<ball_move>().vertical_rev();
            }
        }
        if(collision.gameObject.CompareTag("gameover"))
        {

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
