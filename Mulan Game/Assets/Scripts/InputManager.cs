using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    private bool draggingItem = false;
    private GameObject draggedObject;
    private Vector2 touchOffset;
<<<<<<< HEAD

    void Update()
=======
	private int i = 0;

	void Update()
>>>>>>> a9fd71bb4186004e69c88cda540c84436d787391
    {
        if (HasInput)
        {
            DragOrPickUp();
<<<<<<< HEAD
=======
			sceneTransition ();

>>>>>>> a9fd71bb4186004e69c88cda540c84436d787391
        }
        else
        {
            if (draggingItem)
                DropItem();
<<<<<<< HEAD
        }
    }
=======
			sceneTransition ();
        }
		sceneTransition ();
    }

	private void sceneTransition(){
		if (Input.GetKeyDown (KeyCode.N)) {
			print ("key was pressed");
			Application.LoadLevel (i);
			i++;
			print (i);
			if (i > 19) {
				i = 0;
			}
			print (i);
		}

	}


>>>>>>> a9fd71bb4186004e69c88cda540c84436d787391
    Vector2 CurrentTouchPosition
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
<<<<<<< HEAD
=======

>>>>>>> a9fd71bb4186004e69c88cda540c84436d787391
    private void DragOrPickUp()
    {
        var inputPosition = CurrentTouchPosition;
        if (draggingItem)
        {
            draggedObject.transform.position = inputPosition + touchOffset;
        }
        else
        {
            var layerMask = 1 << 0;
            RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 0.5f, layerMask);
            if (touches.Length > 0)
            {
                var hit = touches[0];
                if (hit.transform != null && hit.transform.tag == "Tile")
                {
                    draggingItem = true;
                    draggedObject = hit.transform.gameObject;
                    touchOffset = (Vector2)hit.transform.position - inputPosition;
                    hit.transform.GetComponent<Tile>().PickUp();
                }
            }
        }
    }
    private bool HasInput
    {
<<<<<<< HEAD
        get
        {
            // returns true if either the mouse button is down or at least one touch is felt on the screen
            return Input.GetMouseButton(0);
=======
		get{
            // returns true if either the mouse button is down or at least one touch is felt on the screen
			i++;
			sceneTransition();
			return Input.GetMouseButton (0);
>>>>>>> a9fd71bb4186004e69c88cda540c84436d787391
        }
    }
    void DropItem()
    {
        draggingItem = false;
        draggedObject.transform.localScale = new Vector3(1, 1, 1);
        draggedObject.GetComponent<Tile>().Drop();
    }
}
