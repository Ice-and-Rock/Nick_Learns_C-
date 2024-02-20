// Out Errors
// As with return, out is a very useful keyword, but it can lead to errors if used incorrectly. Here are two common ones:

// This error means that the out parameter needs to be assigned a value within the method:

    // error CS0177: The out parameter 'success' must be assigned to before control leaves the current method

// This error means you called a method that expects an ‘out’ parameter but you didn’t use the out keyword when calling it:

    // error CS1620: Argument 2 must be passed with the 'out' keyword

    