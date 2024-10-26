using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.Examples;
using System.Threading;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] public Rigidbody rb;
    [SerializeField] public WheelJoint2D Frontwheel;
    [SerializeField] public WheelJoint2D Backwheel;
    [SerializeField] public float CartSpeed;
    [SerializeField] public TextMeshProUGUI ScorePoint;
    [SerializeField] public float coalpoint;
    [SerializeField] public Collider2D Collider;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Score();
    }

    void Movement()
    {
        float h = Input.GetAxis("Horizontal") * CartSpeed;

        Frontwheel.useMotor = true;
        var fmotor = Frontwheel.motor;
        fmotor.motorSpeed = h;
        Frontwheel.motor = fmotor;

        Backwheel.useMotor = true;
        var bmotor = Backwheel.motor;
        bmotor.motorSpeed = h;
        Backwheel.motor = bmotor;

    }

    void Score()
    {
        ScorePoint.text = coalpoint.ToString();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        coalpoint+=1;
        Destroy(gameObject);
    }

   
}
