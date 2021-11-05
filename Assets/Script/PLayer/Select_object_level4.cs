using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Select_object_level4 : MonoBehaviour
{
    public GameObject pos;
    private GameObject obj;
    private RaycastHit hit;
    private bool flog = false;
    [SerializeField] private Camera Camera;
    private bool flagForRigidbodyOn = true;
    private bool flagForRigidbodyOff = true;
    [SerializeField] private RawImage poeint;
    private bool cube = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
                        if (hitInfo.distance <= 3.5f)
                        {
                            if (hitInfo.collider.gameObject.tag == "Cubes")
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
                        }
                    }
                }
            }
        }
    }
}
