//LookAt
//If target is a transform
Vector3 dir = (target.transform.position - transform.position).normalized;
//If target is a vector
Vector3 dir = (target - transform.position).normalized;
//MoveTo
rigidbody.MovePosition(transform.position + dir * speed * Time.deltaTime);
