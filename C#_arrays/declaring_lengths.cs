
// Once we create an array, the size of that array is fixed. 
// However, it’s possible to change the values it contains.
// For example, we can initialize an array that has a FIXED length of three without specifying what those values are
// then later go back and edit the array to include a new value. This is useful if we know how many things we’re expecting, but we don’t know their specific values yet:

// plantHeights.Length will be FIXED length and equal to [0, 0, 0]
int[] plantHeights = new int[3]; 

// plantHeights will now be [0, 0, 8]
plantHeights[2] = 8; 