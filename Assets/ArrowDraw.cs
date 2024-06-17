using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ArrowDraw : MonoBehaviour
{

    

    [SerializeField]
    private Image arrowImage;
    private Vector3 clickPosition;



    // Start is called before the first frame update
    void Start()
    {
        //arrowImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
            arrowImage.gameObject.SetActive(true);

        }
        if (Input.GetMouseButton(0))
        {
            Vector3 dist = clickPosition - Input.mousePosition;
            
            // UnityEngine.Debug.Log(dist);

            float size = dist.magnitude;
        
            float angleRad = Mathf.Atan2(dist.y, dist.x);

            //Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(clickPosition.x, clickPosition.y, arrowImage.canvas.worldCamera.nearClipPlane));
            //arrowImage.rectTransform.position = worldPosition;

            arrowImage.rectTransform.position = clickPosition;
        
            arrowImage.rectTransform.rotation =
                Quaternion.Euler(0, 0, angleRad * Mathf.Rad2Deg);
        
            arrowImage.rectTransform.sizeDelta = new Vector2(size, size);



        }
        
    }
}
