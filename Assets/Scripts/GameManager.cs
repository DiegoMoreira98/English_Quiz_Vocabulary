using UnityEngine;

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