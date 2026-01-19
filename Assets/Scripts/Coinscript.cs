using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinscript : MonoBehaviour
{

    [SerializeField] private float _speed = 1.0f;
    
    private GameController GameController;
    // Este codigo estan el Prefab de moneda

    //Esto ayuda a organizar el UI
    void Start()
    {
        GameController = FindObjectOfType<GameController>();
    }

    // Esto el codigo responsable de que las monedas se muevan a la derecha y paresca que el pinguno se 
    // resbala.
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    // Notas: 
    // Intente usar OnCollisionEnter2D para hacer que la moneda desaparesca peor me di cuenta que 
    // apesar de que funcionaba bastanyte bein no era de forma limpia ya que el pinguino habeces se 
    // movia un la isquierda o rebotaba lo cual no era correcto por enede decidi cambiar a OnTrigger 
    // que me lo hace ver todo mas limpio.
        
    //private void OnCollisionEnter2D(Collision2D collision)
    //{   
        //string tag = collision.gameObject.tag;
        //if (tag.Equals("Player"))
        //{
        //    capturada = true;
        //    Destroy(gameObject);
        //}
    //}
    
    //Este es mas comun y mas correcto para causar este efecto en monedas o puntos en vidojuegos! 
    // recuerda el objeto que tienen el scrip en este caso el prefab necesita tener IsTriger on !!


        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //desaparece a la moneda
            Destroy(gameObject);
            // llama a el metodo que suma los puntos 
            GameController.UpdateCoins();
        }
    }
}
