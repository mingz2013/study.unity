using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(delegate {

            print("click..");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
