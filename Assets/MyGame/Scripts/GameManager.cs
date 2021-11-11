using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject target;
    public GameObject parentOfTargets;

    public bool won;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        won = false;
        InvokeRepeating("Spawn", 1f, 2f);
    }

    private void Spawn()
    {
        float randomX = Random.Range(-100, 100);
        float randomY = Random.Range(-100, 100);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        GameObject myTarget = Instantiate(target, parentOfTargets.transform);
        myTarget.transform.localPosition = random2DPosition;

    }

    // Update is called once per frame
    void Update()
    {
        if(won == true)
        {
            CancelInvoke("Spawn");
        }
        else
        {
           
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse pressed GameManager");
        }

    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("increment ..." + score);

        if(score == 10)
        {
            won = true;
        }
    }
}
