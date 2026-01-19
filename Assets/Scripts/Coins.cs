using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //Estes scrip es para el obejeto moneda

    [SerializeField] GameObject Coin;
    
    float tim = 0f;
    float repeticion = 4f;

    //Con este metodo indicas que el spawn() se relaice desde el principio.
    void Start()
    {
        spawn();
    }    

    //Este metodo ayuda a monitriar que el juego sea infinito al indicarle cada cuanto el 
    // metodo spawn se tiene que repetir de esta forma las monedas continuaran apareciendo.

    void Update()
    {
        tim += Time.deltaTime;
        if (tim >= repeticion)
        {
            spawn();
            tim = 0f;
        }
    }

    // Esta es la parte en la que usaste random.range en este caso se uso para hacer que las
    // moneras aparecieran en a una altura especifica pero con una ceparacion random entre 
    // ellas estandoe stas o muy pegadas o muy separadas. Usando el eje X y Y

    void spawn()
    {
        float y = 13.0f;
        float x = Random.Range(14.0f, 15.0f);

        int monedas = Random.Range(1, 8);

        //Se usa un for loop para que esta se sigan creando

        for (int i = 0; i < monedas; i++)
        {
            Vector3 pos = new Vector3(x, y, 0);
            Instantiate(Coin, pos, Quaternion.identity);
            //esto es para indicar uin min y max de separacion
            x += Random.Range(1.0f, 4.0f);
        }

    }

}
