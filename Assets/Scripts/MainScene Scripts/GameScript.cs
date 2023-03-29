using Assets.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    [System.NonSerialized]
    public string currentLevel = "0";

    [System.NonSerialized]
    public Game currentGame = new Game();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void FailGame()
    {

        var failBlock = SceneManager.GetActiveScene()
            .GetRootGameObjects()
            .FirstOrDefault(x => x.name == "Canvas")
            .GetComponentsInChildren<Transform>().FirstOrDefault(x => x.name == "LevelsBlock")
            .GetComponentsInChildren<Transform>().FirstOrDefault(x => x.name == "LevelEndBlock")
            .GetComponentsInChildren<Transform>(true).FirstOrDefault(x => x.name == "LevelFailed");

        failBlock.gameObject.SetActive(true);

        var failBlockAnimator = failBlock.GetComponent<Animator>();
        failBlockAnimator.SetTrigger("GameFailedInteraction");

        var level = SceneManager.GetActiveScene()
        .GetRootGameObjects()
        .FirstOrDefault(x => x.name == "Canvas")
        .GetComponentsInChildren<Transform>().FirstOrDefault(x => x.name == "LevelsBlock")
        .GetComponentsInChildren<Transform>().FirstOrDefault(x => x.name == "Levels")
        .GetComponentsInChildren<Transform>(true).FirstOrDefault(x => x.name.Contains("Level " + currentLevel));

        level.gameObject.SetActive(false);
    }
}
