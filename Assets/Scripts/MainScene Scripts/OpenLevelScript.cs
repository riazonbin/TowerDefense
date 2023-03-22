using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevelScript : MonoBehaviour
{
    [SerializeField]
    GameScript gameScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        var levelNumber = gameScript.currentLevel;

        var level = SceneManager.GetActiveScene()
            .GetRootGameObjects()
            .FirstOrDefault(x => x.name == "Canvas")
            .GetComponentsInChildren<Transform>().FirstOrDefault(x => x.name == "LevelsBlock")
            .GetComponentsInChildren<Transform>().FirstOrDefault(x => x.name == "Levels")
            .GetComponentsInChildren<Transform>(true).FirstOrDefault(x => x.name.Contains("Level " + levelNumber));

        try
        {
            level.gameObject.SetActive(true);
        }
        catch { }
    }
}
