using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private Collider2D _collider;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jump;

    private bool _isGrounded = true;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _isGrounded = false;

            _rigidbody.velocity = new Vector2(
                _rigidbody.velocity.x,
                _jump
                
            );

            _isGrounded = true;


        }

        
    }
}
