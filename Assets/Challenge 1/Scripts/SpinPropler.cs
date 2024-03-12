using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropler : MonoBehaviour
{
    public GameObject propler;
    private Vector3 proplerRotate = new Vector3 (0,0,10f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        propler.transform.Rotate(proplerRotate);
    }
}
