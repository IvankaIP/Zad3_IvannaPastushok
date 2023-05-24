using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    Rigidbody myRigidbody;
    Slider forceSlider;
    float force;


    // Start is called before the first frame update
    void Start()
    {
        forceSlider = GameObject.Find("forceSlider").GetComponent<Slider>();
        force = forceSlider.value;
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Destroy(collision.gameObject);
        }
    }



}
