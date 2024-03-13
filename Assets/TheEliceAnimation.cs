using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEliceAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] float VelocityRotation = 500;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, VelocityRotation) * Time.deltaTime);
    }
}
