using UnityEngine;

public class AppleKiler_exe : MonoBehaviour
{
    public static float     bottomY = -20f;

    void Update () {
        if ( transform.position.y < bottomY ) {
            Destroy( this.gameObject );
        }
    }
}
