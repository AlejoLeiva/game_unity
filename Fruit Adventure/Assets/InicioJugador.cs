using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioJugador : MonoBehaviour
{
    public void Start()
    {
        int IndexJugador = PlayerPrefs.GetInt("JugadorIndex");
        Instantiate(GameManager.Instance.personajes[IndexJugador].personajeJugable, transform.position, Quaternion.identity);

    }
}
