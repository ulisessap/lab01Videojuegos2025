using UnityEngine;

public class lateupdate : MonoBehaviour
{
    private void OnEnable() {
        Debug.Log("Enable");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.Translate(0,0,0.1f*Time.deltaTime*5);
    }
}
