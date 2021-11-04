using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class SelectObject : MonoBehaviour
{
    private int[,] poss = new int[4, 4];
    private bool[,] bol = new bool[4, 4];
    public GameObject pos;
    private GameObject obj;
    private RaycastHit hit;
    private bool flog = false;
    [SerializeField] private Camera Camera;
    private bool flagForRigidbodyOn = true;
    private bool flagForRigidbodyOff = true;
    [SerializeField] private RawImage poeint;
    private bool cube = false;
    [SerializeField] private MeshRenderer[] meshRenderers = new MeshRenderer[12];
    [SerializeField] private Material materials ;
    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                bol[i, j] = false;
            }
        }
        bol[2, 1] = true;
        bol[1, 2] = true;
        bol[2, 2] = true;
        bol[2, 0] = true;
        bol[0, 2] = true;

    }

    void Update()
    {
        // Call every frame
        MouseInput();
        if (flog)
        {
            if (obj != null)
            {
                obj.transform.position = new Vector3(pos.transform.position.x, pos.transform.position.y, pos.transform.position.z);
            }
            else
            {
                obj = null;

            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (cube)
            {
                flog = false;
                if (flagForRigidbodyOn)
                {
                    obj.GetComponent<Rigidbody>().isKinematic = false;
                    flagForRigidbodyOff = true;
                    flagForRigidbodyOn = false;
                }
                cube = false;
            }
                
            
            poeint.color = Color.white;
           
        }
    }

    void MouseInput()
    {
        // When Mouse 0 is pressed
        if (Input.GetMouseButtonDown(0))
        {

            poeint.color = Color.green;
           
           
                RaycastHit hitInfo;

            // Setup ray based on mouse input position
            Ray rayFromMouseInput = Camera.ScreenPointToRay(Input.mousePosition);

            // Populates hitInfo if returns true
            if (Physics.Raycast(rayFromMouseInput, out hitInfo))
            {
               
                if (hitInfo.collider.gameObject.name != "Plane")
                {
                    //hitInfo.collider.gameObject.transform.SetParent(gameObject.transform);
                    if (hitInfo.distance <= 2.7f)
                    {
                        if (hitInfo.collider.gameObject.tag== "Cubes")
                        {
                            cube = true;
                            Debug.Log(hitInfo.collider.gameObject.name);
                            obj = hitInfo.collider.gameObject;
                     
                            flog = true;
                            flagForRigidbodyOn = true;
                            if (flagForRigidbodyOff)
                            {
                                obj.GetComponent<Rigidbody>().isKinematic = true;
                                flagForRigidbodyOff = false;
                            }
                        }
                        else if (hitInfo.collider.gameObject.tag=="Tile")
                        {
                            switch(hitInfo.collider.gameObject.name)
                            {
                                case "01":
                                    if (poss[0,0]==3)
                                    {
                                        poss[0, 0] = 0;
                                    }else
                                    {
                                       
                                        poss[0, 0] += 1;

                                    }
                                    hitInfo.collider.gameObject.transform.Rotate(new Vector3(0,0, hitInfo.collider.gameObject.transform.rotation.z+90) );
                                    if (poss[0,0]==3)
                                    {
                                        bol[0,0] = true;
                                    }else
                                    {
                                        bol[0,0] = false;

                                    }


                                    break;
                                //case "02":
                                //    if (poss[0, 1] == 3)
                                //    {
                                //        poss[0, 1] = 0;
                                //    }
                                //    else
                                //    {

                                //        poss[0, 1] += 1;

                                //    }
                                //  //  hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                   

                                //    break;
                                case "03":
                                    if (poss[0, 2] == 3)
                                    {
                                        poss[0, 2] = 0;
                                    }
                                    else
                                    {

                                        poss[0, 2] += 1;

                                    }
                                    hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                    if (poss[0, 2] == 0)
                                    {
                                        bol[0, 2] = true;
                                    }
                                    else
                                    {
                                        bol[0, 2] = false;

                                    }
                                    break;
                                case "04":
                                    if (poss[0, 3] == 3)
                                    {
                                        poss[0, 3] = 0;
                                    }
                                    else
                                    {

                                        poss[0, 3] += 1;

                                    }

                                    hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                    if (poss[0, 3] == 3)
                                    {
                                        bol[0, 3] = true;
                                    }
                                    else
                                    {
                                        bol[0, 3] = false;

                                    }
                                    break;
                                case "11":
                                    if (poss[1, 0] == 3)
                                    {
                                        poss[1, 0] = 0;
                                    }
                                    else
                                    {

                                        poss[1, 0] += 1;

                                    }

                                    hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                    if (poss[1, 0] ==1)
                                    {
                                        bol[1, 0] = true;
                                    }
                                    else
                                    {
                                        bol[1, 0] = false;

                                    }
                                    break;
                                case "12":
                                    if (poss[1, 1] == 3)
                                    {
                                        poss[1, 1] = 0;
                                    }
                                    else
                                    {

                                        poss[1, 1] += 1;

                                    }
                                    hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                    if (poss[1, 1] == 3)
                                    {
                                        bol[1, 1] = true;
                                    }
                                    else
                                    {
                                        bol[1, 1] = false;

                                    }
                                    break;
                                //case "13":
                                //    if (poss[1, 2] == 3)
                                //    {
                                //        poss[1, 2] = 0;
                                //    }
                                //    else
                                //    {

                                //        poss[1, 2] += 1;

                                //    }
                                //   // hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                 
                                //    break;
                                case "14":
                                    if (poss[1, 3] == 3)
                                    {
                                        poss[1, 3] = 0;
                                    }
                                    else
                                    {

                                        poss[1, 3] += 1;

                                    }
                                    hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                    if (poss[1, 3] == 2)
                                    {
                                        bol[1, 3] = true;
                                    }
                                    else
                                    {
                                        bol[1, 3] = false;

                                    }
                                    break;
                                case "21":
                                    if (poss[2, 0] == 3)
                                    {
                                        poss[2, 0] = 0;
                                    }
                                    else
                                    {

                                        poss[2, 0] += 1;

                                    }
                                    hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                    if (poss[2, 0] == 0)
                                    {
                                        bol[2, 0] = true;
                                    }
                                    else
                                    {
                                        bol[2, 0] = false;

                                    }
                                    break;
                                //case "22":
                                //    if (poss[2, 1] == 3)
                                //    {
                                //        poss[2, 1] = 0;
                                //    }
                                //    else
                                //    {

                                //        poss[2, 1] += 1;

                                //    }
                                //   // hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                //    break;
                                //case "23":
                                //    if (poss[2, 2] == 3)
                                //    {
                                //        poss[2, 2] = 0;
                                //    }
                                //    else
                                //    {

                                //        poss[2, 2] += 1;

                                //    }
                                // //   hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                //    break;
                                case "24":
                                    if (poss[2, 3] == 3)
                                    {
                                        poss[2, 3] = 0;
                                    }
                                    else
                                    {

                                        poss[2, 3] += 1;

                                    }
                                    hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                    if (poss[2, 3] == 0)
                                    {
                                        bol[2, 3] = true;
                                    }
                                    else
                                    {
                                        bol[2, 3] = false;

                                    }
                                    break;
                                //case "31":
                                //    if (poss[3, 0] == 3)
                                //    {
                                //        poss[3, 0] = 0;
                                //    }
                                //    else
                                //    {

                                //        poss[3, 0] += 1;

                                //    }
                                //    //hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                //    break;
                                case "32":
                                    if (poss[3, 1] == 3)
                                    {
                                        poss[3, 1] = 0;
                                    }
                                    else
                                    {

                                        poss[3, 1] += 1;

                                    }
                                    hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                    if (poss[3, 1] == 0)
                                    {
                                        bol[3, 1] = true;
                                    }
                                    else
                                    {
                                        bol[3, 1] = false;

                                    }
                                    break;
                                case "33":
                                    if (poss[3, 2] == 3)
                                    {
                                        poss[3, 2] = 0;
                                    }
                                    else
                                    {

                                        poss[3, 2] += 1;

                                    }
                                    hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                    if (poss[3, 2] == 3)
                                    {
                                        bol[3, 2] = true;
                                    }
                                    else
                                    {
                                        bol[3, 2] = false;

                                    }
                                    break;
                                //case "34":
                                //    if (poss[3, 3] == 3)
                                //    {
                                //        poss[3, 3] = 0;
                                //    }
                                //    else
                                //    {

                                //        poss[3, 3] += 1;

                                //    }
                                //   // hitInfo.collider.gameObject.transform.Rotate(new Vector3(0, 0, hitInfo.collider.gameObject.transform.rotation.z + 90));
                                //    break;

                                   

                            }

                            if (bol[0,0])
                            {
                                meshRenderers[0].material = materials;
                                Debug.LogWarning("pss=" + "poss[0, 0]" + " bol " + bol[0, 0]);
                                if (bol[1,0])
                                {
                                    meshRenderers[1].material = materials;
                                    Debug.LogWarning("pss=" + "poss[1, 0]" + " bol " + bol[1, 0]);
                                    if (bol[2,0])
                                    {
                                        meshRenderers[2].material = materials;
                                        Debug.LogWarning("pss=" + "poss[2, 0]" + " bol " + bol[2, 0]);
                                        if (bol[2,1])
                                        {
                                            meshRenderers[3].material = materials;
                                            Debug.LogWarning("pss=" + "poss[2, 1]" + " bol " + bol[2, 1]);
                                            if (bol[1,1])
                                            {
                                                meshRenderers[4].material = materials;
                                                Debug.LogWarning("pss=" + "poss[1, 1]" + " bol " + bol[1, 1]);
                                                if (bol[1, 2])
                                                {
                                                    meshRenderers[5].material = materials;
                                                    Debug.LogWarning("pss=" + "poss[1, 2]" + " bol " + bol[1, 2]);
                                                    if (bol[1,3])
                                                    {
                                                        meshRenderers[6].material = materials;
                                                        Debug.LogWarning("pss=" + "poss[1, 3] "+ " bol " + bol[1, 3]);
                                                        if (bol[0,3])
                                                        {
                                                            meshRenderers[7].material = materials;
                                                            Debug.LogWarning("pss=" + "poss[0, 3]" + " bol " + bol[0, 3]);
                                                            if (bol[0,2])
                                                            {
                                                                meshRenderers[8].material = materials;
                                                                Debug.LogWarning("pss=" +" poss[0, 2]" + " bol " + bol[0, 2]);
                                                                if (bol[2,2])
                                                                {
                                                                    meshRenderers[9].material = materials;
                                                                    Debug.LogWarning("pss=" + "poss[2, 2]" + " bol " + bol[2, 2]);
                                                                    if (bol[3,2])
                                                                    {
                                                                        meshRenderers[10].material = materials;
                                                                        meshRenderers[11].material = materials;
                                                                        Debug.LogWarning("pss=" +" poss[3, 2]" + " bol " + bol[3, 2]);
                                                                        Debug.Log("Good");
                                                                        if (GameObject.Find("Cube.042 (1)").GetComponent<AutomaticDoor>().Moving == false)
                                                                            {
                                                                                GameObject.Find("Cube.042 (1)").GetComponent<AutomaticDoor>().Moving = true;
                                                                            }
                                                                            if (GameObject.Find("Cube.043 (1)").GetComponent<AutomaticDoor>().Moving == false)
                                                                            {
                                                                                GameObject.Find("Cube.043 (1)").GetComponent<AutomaticDoor>().Moving = true;
                                                                            }
                                                                    }
                                                                      
                                                                }

                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                       
                    }

                }



            }
          
        }
        

        }


    }

