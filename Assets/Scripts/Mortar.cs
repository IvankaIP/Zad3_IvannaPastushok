using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Mortar : MonoBehaviour
{
    public GameObject mortarBottom;
    public GameObject mortarTop;
    public GameObject Bullet;
    public Transform shootpoint;
    public Slider speedSlider;
    public float speed = 10;
    float rotY = 0;
    float rotX = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        mortarBottom.transform.Rotate(0, rotY * Time.deltaTime, 0);
        mortarBottom.transform.Rotate( rotX * Time.deltaTime,0, 0);

    }

    public void RotLeft()
    {
        rotY = -speed;
    }

    public void RotRight()
    {
        rotY = speed;
    }

    public void RotStop()
    {
        rotY = 0;
        rotX = 0;
    }

    public void RotUp()
    {
        rotX = -speed;
    }

    public void RotDown()
    {
        rotX = speed;
    }

    public void SetSpeed()
    {
        speed = speedSlider.value;
    }

    public void Fire()
    {
        Instantiate(Bullet, shootpoint.position, shootpoint.rotation);
    }
}

