using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    //Este script se le asingno al jugador.

    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jump;

    private bool _isGrounded = true;

    //Este es el sitema de salto usando Grounded.
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && _isGrounded)
        {
            _isGrounded = false;

            _rigidbody.velocity = new Vector2(
                _rigidbody.velocity.x,
                _jump
                
            );

        }
 
    }
    
    //Este es para crear una collisiom entre el piso y el pinguino de esta forma este saltara.

    //Importante no olvidar asignar tag al piso para que no recivamos error.

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        string tag = collision.gameObject.tag;
        if (tag.Equals("Ground"))
        {
            _isGrounded = true;
        }

    }


    
}
