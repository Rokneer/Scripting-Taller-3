using System.Collections;
using UnityEngine;
using TMPro;

public class Proyectile1 : BaseProyectile
{
    [SerializeField] TextMeshProUGUI impactText;

    public override void ProyectileAction(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            StartCoroutine(SummonText());
            Debug.Log("Proyectile Impact");
            Invoke("Recicle", 1.5f);
        }
    }

    private IEnumerator SummonText()
    {
        impactText.text = "Proyectile Impact";
        yield return new WaitForSeconds(1.4f);
        impactText.text = null;
    }
}
