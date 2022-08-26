using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorGun : MonoBehaviour
{
    [SerializeField]
    private Scissor _scissor;

    [SerializeField]
    private Transform _scissorPosition;

    [SerializeField]
    private Transform _scissorContainer;

    private void Shoot()
    {
        var projectil = Instantiate(_scissor, _scissorContainer);

        if(projectil != null)
        {
            projectil.transform.position = _scissorPosition.position;

            var newScissor = projectil.GetComponent<Scissor>();
        }     
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private IEnumerator MakeShoot()
    {
        yield return new WaitForSeconds(2f);
    }
}
