using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraczRuch : MonoBehaviour
{
    [SerializeField] 
    private Vector3 ruch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float prawaLewa = Input.GetAxis("Horizonmtal");
        float goraDol = Input.GetAxis("Vertical");

        ruch = new Vector3(prawaLewa, 0, goraDol) * predkosc;

        transform.Translate(ruch);
    }
}
