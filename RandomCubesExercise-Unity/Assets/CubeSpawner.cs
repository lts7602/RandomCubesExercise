using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefabVar;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(cubePrefabVar);
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(cubePrefabVar);
        GameObject cubeGO = Instantiate<GameObject>(cubePrefabVar);
        Material mat = cubeGO.GetComponent<Renderer>().material;
        mat.color=Random.ColorHSV( 0, 1, .5f, 1, .75f, 1);
    }
}
