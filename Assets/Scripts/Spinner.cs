using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private Vector3 spinDirection;
    [SerializeField] float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinDirection * Time.deltaTime * moveSpeed);
    }
}
