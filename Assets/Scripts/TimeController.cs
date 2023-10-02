using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public Slider slider; // Referencia al slider en el Inspector.
    public float TimeMax = 15f; // Tiempo máximo en segundos.
    private float CurrentTime = 0f;
    private bool StopTime = false;

    void Update()
    {
        if (!StopTime)
        {
            CurrentTime += Time.deltaTime;
            slider.value = CurrentTime;

            if (CurrentTime >= TimeMax)
            {
                StopTime = true;
                
            }
        }
    }
}
