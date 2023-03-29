using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManagerScript : MonoBehaviour
{
    public void StopTime()
    {
        Time.timeScale = 0f;
    }
}
