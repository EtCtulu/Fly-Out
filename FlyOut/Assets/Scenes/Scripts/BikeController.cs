using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Serialization;
using System;

public class BikeController : MonoBehaviour
{

    [SerializeField] private CinemachineDollyCart _cart;
    [SerializeField] private AnimationCurve _accelerationCurve;
    [SerializeField] private float maxHorizontalDistance; //the max distance where the player will be able to move the bike on the x axis 
    [SerializeField] private float horizontalSpeed; //define the speed for each input along the path based 
    [SerializeField] private float returnHorizontalSpeed; // define at what speed the bike gonna return on the path 
    [SerializeField] private float timer;
    [SerializeField] private float timerHorizontal;
    [SerializeField] private float addedValue; //this is the value added to the current value for the speed of the bike
    [SerializeField] private float substractValue;
    [SerializeField] private float currentValue;
    [SerializeField] private float timeBeforeDecreasingSpeed = 1; //this variable will make the bike loose speed when the player stop pushing
    [SerializeField] private float timeBeforeDecreasingPosition = 1; //this variable will make the player return to the path when is stop rotate
    [SerializeField] private float maxSpeed;
    [SerializeField] private CinemachineSmoothPath path;
    [SerializeField] private BirdInput input;

    void Awake()
    {
        input = new BirdInput();
        input.bird.Enable();
        
        
    }

    private void FixedUpdate()
    {
        _cart.m_Speed = maxSpeed * _accelerationCurve.Evaluate(currentValue);
        MoveBird();
    }

    private void MoveBird()
    {
        Vector2 d = new Vector2(0 , InputStick().y * horizontalSpeed * Time.deltaTime * currentValue);
        if(d.y == 0)
        {
            if (timerHorizontal >= timeBeforeDecreasingPosition)
            {
                this.transform.localPosition = new Vector3(0, Mathf.Lerp(this.transform.localPosition.y, 0, (returnHorizontalSpeed * currentValue) / 1000), 0);
            }
            else
            {
                timerHorizontal += Time.deltaTime;
            }
        }
        else
        {
            this.transform.localPosition = new Vector3(0, Mathf.Clamp(this.transform.localPosition.y + d.y, -maxHorizontalDistance, maxHorizontalDistance), 0);
            timerHorizontal = 0;
        }
    }

    

    private Vector2 InputStick()
    {
        Vector2 delta = input.bird.fly.ReadValue<Vector2>();
        return delta;
    }
}
