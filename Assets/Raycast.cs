using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public GameObject RayBullet;

   void Update()
    {
        if (Input.GetMouseButtonUp (0))
        {
            Vector3 worldMousePositon = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 100f));
            Vector3 direction = worldMousePositon - Camera.main.transform.position;
            RaycastHit hit;

            if(Physics.Raycast(Camera.main.transform.position,direction,out hit, 100f))
            {
                Debug.Log("Acertou");
                Debug.DrawLine(Camera.main.transform.position, hit.point, Color.green, 0.5f);
                
                if(hit.collider.gameObject.tag == "alvo")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
            else
            {
                Debug.Log("Não Acertou");
                Debug.DrawLine(Camera.main.transform.position, hit.point, Color.red, 0.5f);
            }
        }
    }
}
