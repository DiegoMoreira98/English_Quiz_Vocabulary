using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int points = 0;
    public float time = 0;


    private void Awake()
    {
        GetPunt();
        if (!instance) //instance  != null  //Detecta que no haya otro GameManager en la escena.
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); //Si hay otro GameManager lo destruye.
        }
        if (File.Exists("si.json"))
        {
            StreamReader sr = new StreamReader("no.json");
            string fileContent = sr.ReadToEnd();
            List<Pregunta> preguntas = JsonConvert.DeserializeObject<List<Pregunta>>(fileContent);
            sr.Close();
        }
    }

    public void AddPunt(int value) //Agrega la cantidad de puntos designada.
    {
        points += value;

    }

    public void ResetPunt(int value) //Resetea la cantidad de puntos.
    {
        points *= value;
    }

    public int GetPunt() //Recibe los puntos.
    {
        return points;
    }

}