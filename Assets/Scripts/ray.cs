using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ray : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform.tag == "Primer Cubo")
                {
                    Debug.Log("Primer Cubo");
                     SceneManager.LoadScene("Scene1 1");  
                }

                else if(hit.transform.tag == "Segundo Cubo")
                {
                    Debug.Log("Segundo Cubo");
                    SceneManager.LoadScene("Scene1 3");
                }
                else if(hit.transform.tag == "Esfera")
                {
                    Debug.Log("Esfera");
                    SceneManager.LoadScene("Scene1 2");
                }
                
            }
        }

    }


}
