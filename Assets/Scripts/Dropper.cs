using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Rigidbody rb;
    [SerializeField]
    private float timeToWait = 0f;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        //An object khi start game
        meshRenderer.enabled = false;
        //Tat gravity cua object
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Time from start game: " + Time.time);
        //Kiem tra thoi gian
        if (Time.time > timeToWait)
        {
            //Hien thi object
            meshRenderer.enabled = true;
            //Bat gravity
            rb.useGravity = true;
        }

    }
}
