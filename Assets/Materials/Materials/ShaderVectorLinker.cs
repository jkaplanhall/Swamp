using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderVectorLinker : MonoBehaviour
{
    Material material;

    [SerializeField]
    GameObject TargetVector;

    // Start is called before the first frame update

    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }
    void Start()
    {
        material.SetVector("_SunPos", TargetVector.transform.position);
    }

    // Update is called once per frame
    void Update()
    {



    }
}
