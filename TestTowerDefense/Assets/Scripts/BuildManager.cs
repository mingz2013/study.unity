using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
// 炮塔建造管理
public class BuildManager : MonoBehaviour
{

    public TurretData laserTurretData;
    public TurretData missileTurretData;
    public TurretData standardTurretData;



    private TurretData selectedTurretData;



    private int money = 1000;
    public Text moneyText;
    public Animator moneyAnimator;

    void ChangeMoney(int change=0)
    {
        money += change;
        moneyText.text = "￥" + money;

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))// 鼠标左键按下
        {
            if (EventSystem.current.IsPointerOverGameObject() == false)// 鼠标是否点击到UI上
            {
                // 鼠标点击在一个空的mapcube上

                // 鼠标的点转换成射线
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                // 射线检测，和mapcube层的碰撞
                RaycastHit hit;
                bool isCollider = Physics.Raycast(ray,out hit, 1000, LayerMask.GetMask("MapCube"));

                if (isCollider)
                {
                    // 得到点击的mapcube
                    MapCube mapcube = hit.collider.GetComponent<MapCube>();
                    if(mapcube.turretGo == null)
                    {// 空的，可以创建
                        // 开始炮台的建造


                        if(selectedTurretData != null)
                        {
                            // 钱够不够
                            if (money > selectedTurretData.cost)
                            {

                                mapcube.BuildTurret(selectedTurretData.turretPrefab);
                                ChangeMoney(-selectedTurretData.cost);


                            }
                            else
                            {
                                //钱不够
                                moneyAnimator.SetTrigger("Flicker");
                            }
                        }

                       

                    }
                    else
                    {
                        // 弹出升级面板
                    }



                }


            }
        }




    }



    public void OnLaserSelected(bool isOn)
    {
        if (isOn)
        {
            selectedTurretData = laserTurretData;
        }

    }
    public void OnMissileSelected(bool isOn)
    {
        if (isOn)
        {
            selectedTurretData = missileTurretData;
        }

    }
    public void OnStandardSelected(bool isOn)
    {
        if (isOn)
        {
            selectedTurretData = standardTurretData;
        }

    }



}
