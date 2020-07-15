using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar_move_keyboard : MonoBehaviour
{
    public float bar_spd = 10;
    void bar_move()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(bar_spd * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-bar_spd * Time.deltaTime, 0, 0);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bar_move();
    }
}
