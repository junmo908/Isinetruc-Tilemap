using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeraController : MonoBehaviour
{
    public float smoothSpeed = 2;
    private Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,
            new Vector3(target.position.x, target.position.y, transform.position.z), 
            smoothSpeed * Time.deltaTime);

    }
}
