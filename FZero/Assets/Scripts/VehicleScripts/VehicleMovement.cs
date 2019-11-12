using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    //floats
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _turnSpeed;
    [SerializeField]
    private float _pInput; //power input
    [SerializeField]
    private float _tInput; //turn input


    [SerializeField]
    private bool _tInputBool;

    //rigidBody
    private Rigidbody _rigidBody;

    void Awake()
    {
        _rigidBody = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _pInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) && _tInputBool == false)
        {
            
            _tInputBool = true;
            _tInput = 1f;
            Debug.Log(_tInputBool + "val: " + _tInput);
        }
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            _tInputBool = false;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) && _tInputBool == false)
        {
            _tInputBool = true;
            _tInput = -1f;
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _tInputBool = false;
        }

        if (!_tInputBool)
        {
            _tInput = 0;
        }
    }

    void FixedUpdate()
    {
       
        if (_pInput > 0f || _pInput < 0f)
        {
           _rigidBody.AddRelativeForce(0f, 0f, _pInput * _speed);
        }
        else
        {
            _rigidBody.velocity = Vector3.Lerp(_rigidBody.velocity, Vector3.zero, Time.deltaTime);
        }
        
        if (_tInput == 1f || _tInput == -1f)
        {
            _rigidBody.AddRelativeTorque(0f, _tInput * 12.5f, 0f);
            _rigidBody.velocity = Vector3.Lerp(_rigidBody.velocity, Vector3.zero, Time.deltaTime * 1.25f);
        }
        else
        {
            _rigidBody.angularVelocity = Vector3.zero;
        }

    }
}
