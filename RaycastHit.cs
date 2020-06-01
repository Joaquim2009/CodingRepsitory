RaycastHit hit;
Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask) && Input.GetButtonDown(0))
{
  //Do Something
}
