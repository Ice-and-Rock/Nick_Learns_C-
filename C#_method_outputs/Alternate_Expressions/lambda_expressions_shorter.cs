// To make our Lambda expressions ever shorter:

// if the type is inferred (obvious) and there is one parameter...


bool hasEvenNumbers = Array.Exists(numbers, (int num) => num % 2 == 0 );
// The modulo operator (%) is only used with numbers, so num must be a number
// The result of the operation num % 2 is compared to the integer 0. We can only compare similar types, so num must also be an integer!

// Therefore, we can remove int without causing any errors:
bool hasEvenNumbers2 = Array.Exists(numbers, (num) => num % 2 == 0 );

// When there is just one parameter in a lambda expression, we don’t need the parentheses around the parameter either:
bool hasEvenNumbers3 = Array.Exists(numbers, num => num % 2 == 0 );