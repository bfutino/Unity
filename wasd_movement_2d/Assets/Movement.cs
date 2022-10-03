using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode jumpKey;
    public float speed = 10f;

    // regular movement with the added ability to "dash"(skip distance) in any direction when pressing the space bar and direction wanted 
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w") && Input.GetKey("space"))
        {
            pos.y += (float) 0.2;
        }else if(Input.GetKey("w")){
             pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey("s") && Input.GetKey("space"))
        {
            pos.y -= (float) 0.2;
        }else if(Input.GetKey("s")){
             pos.y -= speed * Time.deltaTime;
        }

        
        if (Input.GetKey("d") && Input.GetKey("space"))
        {
            pos.x += (float) 0.2;
        }else if(Input.GetKey("d")){
            pos.x += speed * Time.deltaTime;
        }
        
        if (Input.GetKey("a") && Input.GetKey("space"))
        {
            pos.x -= (float) 0.2;
        }else if(Input.GetKey("a")){
            pos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


        transform.position = pos;
    }
}
