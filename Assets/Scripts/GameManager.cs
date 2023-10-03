using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int points = 0;
    public float time = 0;
    //public Fades fadesScript;
    //public List<string> exitTimes = new List<string>();

    private void Awake()
    {
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
            //List<Pregunta> l = new List<Pregunta>();
            //Pregunta p1 = new Pregunta();
            //p1.enunciado = "aaaa";
            //p1.a = "a";
            //Pregunta p2 = new Pregunta();
            //p2.enunciado = "bbbb";
            //l.Add(p1);
            //l.Add(p2);
            //StreamWriter streamWriter = new StreamWriter("no.json");
            //streamWriter.Write(JsonConvert.SerializeObject(l));
            //streamWriter.Close();   
            StreamReader sr = new StreamReader("no.json");
            string fileContent = sr.ReadToEnd();
            List<Pregunta> preguntas = JsonConvert.DeserializeObject<List<Pregunta>>(fileContent);
            sr.Close();
        }
    }

    //public void SetFadesScript(Fades script) //Asignamos el objeto Fades a la variable fadeScript.
    //{
    //    fadesScript = script;

    //}

    public void AddPunt(int value) //Agrega la cantidad de puntos designada.
    {
        points += value;
        //if (fadesScript != null) //Preguntamos si fadeScript es diferente de null.
        //{
        //    // Inicia la corutina de fade en el objeto con el script Fades al actualizarse la puntuación.
        //    StartCoroutine(fadesScript.FadeIn());
        //}
    }

    public void ResetPunt(int value) //Resetea la cantidad de puntos.
    {
        points *= value;
    }

    public int GetPunt() //Recibe los puntos.
    {
        return points;
    }

    //public void AddExitHour (String ExitT)
    //{
    //    exitTimes.Add((System.DateTime.Now.ToString("HH:mm:ss")));
    //}
}