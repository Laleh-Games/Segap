using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SelectObject : MonoBehaviour
{
    
    public GameObject pos;
    private GameObject obj;
    private RaycastHit hit;
    private bool flog = false;
    [SerializeField] private Camera Camera;
    private bool flagForRigidbodyOn = true;
    private bool flagForRigidbodyOff = true;

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
            flog = false;
            if(flagForRigidbodyOn)
            {
                obj.GetComponent<Rigidbody>().isKinematic = false;
                flagForRigidbodyOff = true;
                flagForRigidbodyOn = false;
            }
        }
    }

    void MouseInput()
    {
        // When Mouse 0 is pressed
        
        if (Input.GetMouseButtonDown(0))
        {


            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2, Color.blue);
            //RaycastHit hit;
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2, Color.white);
            //// Does the ray intersect any objects excluding the player layer
            //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward) * 2, out hit, Mathf.Infinity))
            //{
            //    if (hit.distance <= 2)
            //    {
            //        Debug.Log(hit.collider.gameObject.name);
            //        if (hit.collider.gameObject.name != "Plane")
            //        {



            //        }

            //    }
            //    else
            //    {

            //    }
            //    }
           
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
                       
                    }

                }



            }
        }
        

        }


    }

