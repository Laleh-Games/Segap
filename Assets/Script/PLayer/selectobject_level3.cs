using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class selectobject_level3 : MonoBehaviour
{

    private GameObject obj;
    private RaycastHit hit;
    private bool flog = false;
    [SerializeField] private Camera Camera;
    private bool flagForRigidbodyOn = true;
    private bool flagForRigidbodyOff = true;
    [SerializeField] private RawImage poeint;
    private bool cube = false;
    [SerializeField] private float timer = 3f;
    [SerializeField] private GameObject[] agameObjects;
    private GameObject showobj;
    private int scor = 0;
    private int loop = 0;
    private int wrongs = 0;
    [SerializeField] private Text tscor;
    [SerializeField] private Text wrong;
    [SerializeField] private Text Timerrr;
    [SerializeField] private Renderer[] renderer;
    private int x = 0;
    private bool start_floge=false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < agameObjects.Length; i++)
        {
            agameObjects[i].SetActive(false);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (start_floge)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                Timerrr.text = ((int)timer).ToString();
            }
            else
            {

                objectshower();
            }
        }
       
        MouseInput();


        if (Input.GetMouseButtonUp(0))
        {
            //if (cube)
            //{
            //    flog = false;
            //    if (flagForRigidbodyOn)
            //    {
            //        obj.GetComponent<Rigidbody>().isKinematic = false;
            //        flagForRigidbodyOff = true;
            //        flagForRigidbodyOn = false;
            //    }
            //    cube = false;
            //}


            poeint.color = Color.white;

        }
    }
    void MouseInput()
    {
        // When Mouse 0 is pressed
        if (Input.GetMouseButtonDown(0))
        {

            poeint.color = Color.green;

            if (start_floge)
            {

            
            RaycastHit hitInfo;

            // Setup ray based on mouse input position
            Ray rayFromMouseInput = Camera.ScreenPointToRay(Input.mousePosition);

                // Populates hitInfo if returns true
                if (Physics.Raycast(rayFromMouseInput, out hitInfo))
                {

                    if (hitInfo.collider.gameObject.name != "Plane")
                    {
                        //hitInfo.collider.gameObject.transform.SetParent(gameObject.transform);
                        if (hitInfo.distance <= 5f)
                        {
                            if (hitInfo.collider.gameObject.tag == "object")
                            {
                                cube = true;
                                Debug.Log(hitInfo.collider.gameObject.name);
                                obj = hitInfo.collider.gameObject;
                                if (showobj.name == obj.name)
                                {
                                    obj.GetComponent<Renderer>().material.color = Color.green;
                                    scor += 1;
                                    tscor.text = scor.ToString();
                                }
                                else
                                {

                                    obj.GetComponent<Renderer>().material.color = Color.red;
                                    wrongs += 1;
                                    wrong.text = wrongs.ToString();
                                    Invoke("objectshower", 0.1f);
                                }
                                //flog = true;
                                //flagForRigidbodyOn = true;
                                //if (flagForRigidbodyOff)
                                //{
                                //    obj.GetComponent<Rigidbody>().isKinematic = true;
                                //    flagForRigidbodyOff = false;
                                //}
                            }
                        }
                    }
                }
            }
        }
    }
    void objectshower()
    {
        if (loop == 30)
        {

            //Game_over
        }
        else
        {
            agameObjects[x].SetActive(false);
            x = Random.RandomRange(0, agameObjects.Length);
            agameObjects[x].SetActive(true);
            showobj = agameObjects[x];
            loop += 1;
            timer = 3f;
            for (int i = 0; i < renderer.Length; i++)
            {
                renderer[i].material.color = Color.white;
            }
        }




    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="start")
        {
            start_floge = true;
            objectshower();
        }

    }
}
