using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class SelectTowerScript : MonoBehaviour
{
    [SerializeField]
    Transform menuPrefab;

    public void ChooseTower()
    {
        var parent = transform.parent.GetComponentsInChildren<Transform>().FirstOrDefault(x => x.name == "MenuBlock");

        while (parent.childCount > 0)
        {
            DestroyImmediate(parent.GetChild(0).gameObject);
        }

        Instantiate(menuPrefab, parent);
    }
}
