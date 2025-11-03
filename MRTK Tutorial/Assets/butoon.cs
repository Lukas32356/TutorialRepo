using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionExample : MonoBehaviour
{
    public Rigidbody toast; // Rigidbody des Objekts, das die Explosionskraft erhalten soll
    public Vector3 explosionPosition; // Position der Explosion
    public float explosionForce = 10f; // Stärke der Explosion
    public float explosionRadius = 5f; // Radius der Explosion
    public float upwardModifier = 1f; // Modifikator für den Aufwärtseffekt

    public void Clicked()
    {
        Debug.Log("Button gedrückt!");

        toast.isKinematic = false;
        toast.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, upwardModifier);
    }
}