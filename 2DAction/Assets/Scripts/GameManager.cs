using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] GameObject gameoverUiObject = null;
    [SerializeField] ActionController actionController = null;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReStart();
        }
    }

    public void GameOver()
    {
        gameoverUiObject.SetActive(true);
        actionController.GameOver();
    }

    void ReStart()
    {
        actionController.ReStart();
        gameoverUiObject.SetActive(false);
    }
}
