using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float acceleration;
    public float maxVelocity;
    public Transform cameraPivot;

    public float resetHeight;
    public Material HappyMaterial;
    public Material DeadMaterial;

    private Vector3 moveDirection = Vector3.zero;
    private Rigidbody rb;

    private bool hardSceneChangeOccurring = false;
    
    public static Player Instance;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Instance = this;
    }

    private void Update()
    {
        moveDirection = (cameraPivot.forward * Input.GetAxis("Vertical") +
                         cameraPivot.right * Input.GetAxis("Horizontal")).normalized;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Instance.QuitGame();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameManager.Instance.ReloadScene();
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDirection * acceleration, ForceMode.Acceleration);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);
        
        if (transform.position.y < resetHeight)
        {
            PlayerDeath();
        }
    }

    public void PlayerDeath()
    {
        if (hardSceneChangeOccurring) return;
        GameManager.Instance.ReloadScene(1.2f);
        gameObject.GetComponent<MeshRenderer>().material = DeadMaterial;
        hardSceneChangeOccurring = true;
    }

    public void PlayerWin()
    {
        if (hardSceneChangeOccurring) return;
        GameManager.Instance.LoadNextScene(3f);
        gameObject.GetComponent<MeshRenderer>().material = HappyMaterial;
        hardSceneChangeOccurring = true;
    }
}
