using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {
    new Camera camera;
    float previousFire1 = 0;

    void Start()
    {
        camera = GetComponent<Camera>();
    }

	void Update () {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        float fire1 = Input.GetAxisRaw("Fire1");
        if (Physics.Raycast(ray, out hitInfo))
        {
            Interactor interact = hitInfo.transform.GetComponent<Interactor>();
            if (interact)
            {
                if (fire1 == 1 && previousFire1 == 0)
                {
                    interact.run();
                }
            }
        }
        previousFire1 = fire1;
    }
}
