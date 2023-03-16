using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevelScript : MonoBehaviour
{
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
        var levelNumber = "1";

        var level = SceneManager.GetActiveScene()
            .GetRootGameObjects()
            .FirstOrDefault(x => x.name == "Canvas")
            .GetComponentsInChildren<Transform>().FirstOrDefault(x => x.name == "Levels")
            .GetComponentsInChildren<Transform>(true).FirstOrDefault(x => x.name.Contains(levelNumber));


        level.gameObject.SetActive(true);
    }
}