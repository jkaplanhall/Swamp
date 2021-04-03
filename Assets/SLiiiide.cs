using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLiiiide : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Vector3 Dir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Dir * Time.deltaTime;
    }
}
