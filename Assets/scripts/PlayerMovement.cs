using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 pos;
    private bool moving = false;
    public GameObject Child;
    private Vector3 origin, direction1, direction2, direction3, direction4;
    Ray newRay1, newRay2, newRay3, newRay4;
    RaycastHit hit;
    public float Distance;
    // Use this for initialization
    void Start()
    {
        pos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        PositionSetup();
        DrawRayCast();
        CheckInput();
        if (moving)
        {
            transform.position = pos;
            moving = false;
        }
    }

    void CheckInput()
    {
        if (Physics.Raycast(newRay1, out hit, Distance))
        {
            if (hit.collider.CompareTag("Cube"))
            {
                if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
                {
                    pos += Vector3.right;
                    moving = true;
                }
            }
        }
        if (Physics.Raycast(newRay2, out hit, Distance))
        {
            if (hit.collider.CompareTag("Cube"))
            {
                if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    pos += Vector3.left;
                    moving = true;
                }
            }
        }
        if (Physics.Raycast(newRay3, out hit, Distance))
        {
            if (hit.collider.CompareTag("Cube"))
            {
                if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
                {
                    pos += Vector3.forward;
                    moving = true;
                }
            }
        }
        if (Physics.Raycast(newRay4, out hit, Distance))
        {
            if (hit.collider.CompareTag("Cube"))
            {
                if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
                {
                    //transform.position = Vector3.back;
                    pos += Vector3.back;
                    moving = true;
                }
            }
        }
    }
    void DrawRayCast()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 5;
        Vector3 backward = transform.TransformDirection(Vector3.back) * 5;
        Vector3 left = transform.TransformDirection(Vector3.left) * 5;
        Vector3 right = transform.TransformDirection(Vector3.right) * 5;

        Debug.DrawRay(origin, forward, Color.green);
        Debug.DrawRay(origin, backward, Color.blue);
        Debug.DrawRay(origin, left, Color.red);
        Debug.DrawRay(origin, right, Color.yellow);
    }
    void PositionSetup()
    {
        origin = Child.transform.position;
        direction1 = Vector3.forward;
        direction2 = Vector3.back;
        direction3 = Vector3.left;
        direction4 = Vector3.right;
        newRay1 = new Ray(origin, direction1);
        newRay2 = new Ray(origin, direction2);
        newRay3 = new Ray(origin, direction3);
        newRay4 = new Ray(origin, direction4);
    }
}