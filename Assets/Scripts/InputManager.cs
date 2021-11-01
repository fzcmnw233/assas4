using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
	public Tweener tweener;
	
	public Vector3 end;
	
	public GameObject pac;
    
    public int pacmove;
    

    // Start is called before the first frame update
    void Start()
    {	
	    pacmove = 0;
		 
        end = new Vector3(24.32f,-18.28f,0f);
       
        tweener = GetComponent<Tweener>();
      
        pac.GetComponent<Animator>();
        
        tweener.AddTween(pac.transform, end, end, 4f); 
      
       
    }

    // Update is called once per frame
void Update()
    {

        //If get to the target point
        if (pacmove ==0 && pac.transform.position == end)
        {
                    //set position
                    end = new Vector3(24.32f, -18.28f, 0f);        
                    //Set Pac-Man to spin
                    pac.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
                    tweener.AddTween(pac.transform, pac.transform.position, end, 4f);
                    pacmove = 1;
		}
		else if(pacmove ==1 && pac.transform.position ==end)
		{
                
                    end = new Vector3(29.56f,-18.2f,0f);
					tweener.AddTween(pac.transform, pac.transform.position,end, 4f);
                    pac.transform.Rotate(0f, 0f, -90f);
                    pacmove= 2;
		}
		else if(pacmove ==2 && pac.transform.position == end)
		{
                
                    end = new Vector3(29.56f,-22.3f,0f);
					tweener.AddTween(pac.transform, pac.transform.position, end, 4f);
                    pac.transform.Rotate(180f, 0f, 90f);
                    pacmove = 3;
		}
		else if(pacmove ==3 && pac.transform.position == end)
		{
                
                    end = new Vector3(24.44f,-22.18f,0f); 
					tweener.AddTween(pac.transform, pac.transform.position,end, 4f);
                    pac.transform.Rotate(0f, 0f, 90f);
                    pacmove = 0;
        }
	}
}
	
        