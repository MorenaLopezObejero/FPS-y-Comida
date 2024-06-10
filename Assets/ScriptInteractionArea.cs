using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptInteractionArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        

    }
    void Alimentarse(int ValorAlimentario)
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        FileteScript filete;
        filete = other.GetComponent<FileteScript>();

        if (filete)
        {
            Destroy(other.gameObject);
            Debug.Log("Hubo interaccion");
        }
    }
}
