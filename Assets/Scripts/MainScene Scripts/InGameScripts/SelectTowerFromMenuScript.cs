using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class SelectTowerFromMenuScript : MonoBehaviour
{
    [System.NonSerialized]
    public OpenTowerMenuScript openTowerMenuScript;

    [SerializeField]
    Transform towerPrefabTransform;

    Image image;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChooseTower()
    {
        towerPrefabTransform.GetComponent<Image>().sprite = GetComponent<Image>().sprite;

        Instantiate(towerPrefabTransform, openTowerMenuScript.towerPlaceForPoint);
    }
}
