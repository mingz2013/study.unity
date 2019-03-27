using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCube : MonoBehaviour
{
    [HideInInspector] // 不需要显示到面板上
    public GameObject turretGo; // 当前cube身上的炮台

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void BuildTurret(GameObject turretPrefab)
    {
        turretGo = GameObject.Instantiate(turretPrefab, transform.position, Quaternion.identity);

    }

}
