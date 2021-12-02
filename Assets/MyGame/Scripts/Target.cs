using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private int secToDestroy;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        secToDestroy = 1;
        Destroy(gameObject, secToDestroy);
    }

    private void OnMouseDown()
    {
        Debug.Log("Mouse Down");
        gameManager.IncrementScore();
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
