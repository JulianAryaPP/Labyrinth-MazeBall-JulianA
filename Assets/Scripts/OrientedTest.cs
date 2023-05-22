using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class OrientedTest : MonoBehaviour
{
    [SerializeField] TMP_Text systemInfoText;
    [SerializeField] Mode mode;
    enum Mode
    {
        gravity,
        acceleration,
        userAcceleration,
        rotationRate,
        rotationRateUnbiased,
        attitude
    }
    void Start()
    {
        systemInfoText.text = " sensor";
        if(SystemInfo.supportsAccelerometer)
            systemInfoText.text += "accelerometer";
        if (SystemInfo.supportsGyroscope)
        {
            systemInfoText.text += "gyroscope";
            Input.gyro.enabled = true;
        }
        
    }

    void Update()
    {
        Debug.Log("gravity" + Input.gyro.gravity);
        Debug.Log("acceleration" + Input.acceleration);
        Debug.Log("userAcceleration" + Input.gyro.userAcceleration);
        Debug.Log("rotationRate" + Input.gyro.rotationRate);
        Debug.Log("rotationRateUnbiased" + Input.gyro.rotationRateUnbiased);
        Debug.Log("attitude" + Input.gyro.attitude);

        this.transform.rotation = Input.gyro.attitude;
           
        switch (mode)
        {
            case Mode.gravity:
                this.transform.up = -Input.gyro.gravity;
                break;
            case Mode.acceleration:
                this.transform.up = -Input.acceleration;
                break;
            case Mode.userAcceleration:
                this.transform.up = -Input.gyro.userAcceleration;
                break;
            case Mode.rotationRate:
                this.transform.Rotate  (Input.gyro.rotationRate);
                break;
            case Mode.rotationRateUnbiased:
                this.transform.Rotate  (Input.gyro.rotationRateUnbiased);
                break;
            case Mode.attitude:
                this.transform.rotation = Quaternion.Euler(90,0,0) * Input.gyro.attitude * new Quaternion(0,0,-1,0);
                break;
        }
    }


}
