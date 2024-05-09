using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        transform.Translate(Vector3.left * horiz * Time.deltaTime * 5.0f);
        transform.Translate(Vector3.forward * vert * Time.deltaTime * 5.0f);

    }
}
