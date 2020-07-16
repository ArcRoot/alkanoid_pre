using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ball;
    public GameObject bar;
    public List<GameObject> wall;
    public List<GameObject> brick;
    public float ball_spawnp;
    public float bar_spawnp;
    public float wall_spawnp;
    public float brick_spawnp;
    public int ball_count=0;
    // Start is called before the first frame update
    void ball_spawn()
    {
        ball = Instantiate<GameObject>(Resources.Load<GameObject>("ball"), new Vector3(0, -3.25f, 0), Quaternion.identity);
        ball_count++;
    }
    void bar_spawn()
    {
        bar = Instantiate<GameObject>(Resources.Load<GameObject>("bar"), new Vector3(0, -3.5f, 0), Quaternion.identity);
    }
    void wall_spawn()
    {
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_l"), new Vector3(-9, 0, 0), Quaternion.identity));
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_r"), new Vector3(9, 0, 0), Quaternion.identity));
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_u"), new Vector3(0, 5, 0), Quaternion.identity));
        wall.Add(Instantiate<GameObject>(Resources.Load<GameObject>("wall_d"), new Vector3(0, -5, 0), Quaternion.identity));
    }
    void brick_spawn()
    {
        int i, j;
        for(i=0;i<5;i++)
        {
            for(j=0;j<17;j++)
            {
                brick.Add(Instantiate<GameObject>(Resources.Load<GameObject>("brick"), new Vector3(-8 + j, 4-0.5f*i, 0), Quaternion.identity));
            }
        }
    }
    public void destroy_evr()
    {
        Destroy(bar);
        Destroy(ball);
        while(wall.Count!=0)
        {
            Destroy(wall[0]);
            wall.RemoveAt(0);
        }
        while(brick.Count!=0)
        {
            Destroy(brick[0]);
            brick.RemoveAt(0);
        }

    }
    void Start()
    {
        ball_spawn();
        bar_spawn();
        wall_spawn();
        brick_spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
