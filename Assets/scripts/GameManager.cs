using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cube;
    public int noOfRow;
    public int noOfCol;
    public GameObject[,] array;
    static float temp;
    private float HorizontalSpacing = 1.0f, VerticalSpacing = 1.0f;
    public float Horizontal_Spacing, Vertical_Spacing;
    // Start is called before the first frame update
    void Start()
    {
        temp = VerticalSpacing;
        //array = new GameObject[noOfRow,noOfCol];
        for(int i=0; i<noOfRow; i++)
        {
            VerticalSpacing= temp;
            for (int j=0; j<noOfCol; j++)
            { 
              // array[noOfRow,noOfCol]=
                    Instantiate(cube,new Vector3(HorizontalSpacing,0,VerticalSpacing),cube.transform.rotation);
               VerticalSpacing += Vertical_Spacing;
            }
            HorizontalSpacing += Horizontal_Spacing;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
