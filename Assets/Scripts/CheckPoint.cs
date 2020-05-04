
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
public GameObject LastCheckPoint;

    
    // Start is called before the first frame update
    void Start()
    {
        
    } 
    public void OnTriggerEnter(Collider collision2D)
	{
		if (collision2D.CompareTag("CheckPoint"))
		{

        }
    }        
}
