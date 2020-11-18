using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGeneratorController : MonoBehaviour
{

    public GameObject trashPrefab;
    public float generatorTimer = 1.75f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateTrash(){
        Instantiate(trashPrefab, transform.position, Quaternion.identity);
    }

    public void StartGenerator(){
        InvokeRepeating("CreateTrash", 0f, generatorTimer);
    }

    public void CancelGenerator(bool clean = false){
        CancelInvoke("CreateTrash");
        if (clean) {
            Object[] allTrash = GameObject.FindGameObjectsWithTag("Point"); 
            foreach(GameObject trash in allTrash){
                Destroy(trash);
            }
        }
    }

}
