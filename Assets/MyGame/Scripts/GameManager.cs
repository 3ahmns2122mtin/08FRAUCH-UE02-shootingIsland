using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private const int maxHit = 10;
    public GameObject target;
    public GameObject parentOfTargets;
    public GameObject objCounter;
    public GameObject wonObj;
    public GameObject wonSound;
    public GameObject shootSound;

    private Text textCounter;
    public bool won;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        textCounter = objCounter.GetComponent<Text>();
        won = false;
        InvokeRepeating("Spawn", 1f, 2f);
        wonObj.SetActive(false);
        wonSound.SetActive(false);
    }

    private void Spawn()
    {
        float randomX = Random.Range(-250, 250);
        float randomY = Random.Range(-250, 250);

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
            wonObj.SetActive(true);
            wonSound.SetActive(true);
        }
        else
        {
           
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse pressed GameManager");
            shootSound.GetComponent<AudioSource>().Play();
        }

    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("increment ..." + score);
        textCounter.text = score.ToString();

        if(score == maxHit)
        {
            won = true;
        }
    }
}
