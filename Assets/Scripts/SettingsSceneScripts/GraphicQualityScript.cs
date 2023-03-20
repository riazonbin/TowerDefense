using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicQualityScript : MonoBehaviour
{
    [SerializeField]
    Image filledImage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetQuality(float value)
    {
        filledImage.fillAmount += value;
    }
}
