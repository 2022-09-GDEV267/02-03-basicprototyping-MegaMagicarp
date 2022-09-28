using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOutManager : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject prefabBall;
    public GameObject[] levels;
    public Vector3 levelPos;
    
    [Header("Set Dynamicaly")]
    public GameObject ball;
    public GameObject level;
    public int spot;
    public int brickCount;


    // Start is called before the first frame update
    void Start()
    {
        brickCount = 20;
        spot = 0;
        StartLevel();
    }

    public void StartLevel()
    {
        level = Instantiate<GameObject>(levels[spot]);
        NewBall();
        level.transform.position = levelPos;
        BrickCount = 20;
    }

    public int BrickCount
    {
        get { return brickCount; }
        set { brickCount = value; }
    }
    void NextLevel()
    {
        Destroy(ball);

        spot++;
        if(spot <= levels.Length)
        {
            StartLevel();
        }else
        {
            spot = 0;
            StartLevel();
        }
    }
    public void NewBall()
    {
        ball = Instantiate(prefabBall) as GameObject;
        ball.transform.position = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {

        if(brickCount == 0)
        {
            NextLevel();
        }
        //if(ball.transform.position.y < -4.5f)
        //{
        //    Destroy(this.gameObject);
        //    NewBall();
        //}
    }
}
