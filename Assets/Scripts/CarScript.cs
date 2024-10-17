using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
using TMPro;

public class CarScript : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    private float currentSteerAngle;
    private float currentbreakForce;
    private bool isBreaking;
    public GameObject deadPrefab;
    public float maxSpeed;
    public static int numberOfCoins;
    public TextMeshProUGUI coinsText;
    [SerializeField] GameObject RetryMenu;
    



    [SerializeField] private float motorForce;
    [SerializeField] private float maxSteerAngle;

    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheeTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;

    private void Awake()
    {
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
    }


    void Update()
    {
        coinsText.text = numberOfCoins.ToString();
        GetComponent<Rigidbody>().AddForce(Vector3.forward * motorForce * Time.deltaTime);
        if (motorForce < maxSpeed)
            motorForce += 0.02f * Time.deltaTime;

        
    }
    private void FixedUpdate()
    {
        if (SceneManager.GetActiveScene().name == "awakeScene") return;
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
        
    }


    private void GetInput()
    {
        horizontalInput = CrossPlatformInputManager.GetAxis(HORIZONTAL);
        verticalInput = CrossPlatformInputManager.GetAxis(VERTICAL);
        
    }

    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque =  motorForce;
        frontRightWheelCollider.motorTorque =  motorForce;
       
        ApplyBreaking();
        
    }

    private void ApplyBreaking()
    {
        frontRightWheelCollider.brakeTorque = currentbreakForce;
        frontLeftWheelCollider.brakeTorque = currentbreakForce;
        rearLeftWheelCollider.brakeTorque = currentbreakForce;
        rearRightWheelCollider.brakeTorque = currentbreakForce;
    }

    private void HandleSteering()
    {
        currentSteerAngle = maxSteerAngle * horizontalInput;
        frontLeftWheelCollider.steerAngle = currentSteerAngle;
        frontRightWheelCollider.steerAngle = currentSteerAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheeTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot
; wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wall")
        {
            transform.gameObject.SetActive(false);
            for (int i = 0; i < 17; i++)
            {
                Instantiate(deadPrefab, transform.position, Quaternion.identity);
            }
        }
        if (other.tag == "wall")
        {
            RetryMenu.SetActive(true);
        }


        if (other.tag == "finish")
        {
            Debug.Log("Finish");
        }
    }

}