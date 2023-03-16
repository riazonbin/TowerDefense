using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
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

    public void ChooseLevel()
    {
        gameScript.currentLevel = transform.GetComponentInChildren<Text>().text;
    }
}
