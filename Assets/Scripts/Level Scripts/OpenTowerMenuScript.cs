using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class OpenTowerMenuScript : MonoBehaviour
{
    [SerializeField]
    Transform menuPrefab;

    Transform menuContainer;
    Vector3 menuPosition;

    [DoNotSerialize]
    public Vector3 dotPosition;

    [DoNotSerialize]
    public Transform towerPlaceForPoint;

    private void Start()
    {
        dotPosition = transform.position;

        menuContainer = transform.parent.parent.parent.GetComponentsInChildren<Transform>()
            .FirstOrDefault(x => x.name == "MenuContainer");

        menuPosition = transform.parent.GetComponentsInChildren<Transform>()
            .FirstOrDefault(x => x.name == "MenuPlaceForPoint").position;

        towerPlaceForPoint = transform.parent.GetComponentsInChildren<Transform>()
            .FirstOrDefault(x => x.name == "TowerPlaceForPoint");
    }

    public void OpenTowerMenu()
    {
        while (menuContainer.childCount > 0)
        {
            DestroyImmediate(menuContainer.GetChild(0).gameObject);
        }

        var menu = Instantiate(menuPrefab, menuContainer);

        menu.position = menuPosition;

        // getting each menu item's script and setting this script as a parameter

        var menuItemsScripts = menu.GetComponentsInChildren<SelectTowerFromMenuScript>();

        foreach (var item in menuItemsScripts)
        {
            item.openTowerMenuScript = this;
        }
    }
}
