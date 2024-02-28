### You built an automated encryption engine that your team can use to communicate in secrecy. The hackathon is all but won!

# Additional points to keep building:

The app doesn’t work with uppercase letters. Fix that by converting any message to lowercase.
The app doesn’t work with symbols, like ! or ?. Skip any symbols in your loop so that they are not encrypted.

Rewrite the loop as a method Encrypt() which takes a character array and key and returns an encrypted character array .

Write a Decrypt() method which takes a character array and key and returns a decrypted character array.

<code>
char[] secretMessage = {'h', 'e', 'l', 'l', 'o'};
</code>

<code>
// encrypted should equal  {'k', 'h', 'o', 'o', 'r'}
string encrypted = Encrypt(secretMessage, 3);
</code>

<code>
// decrypted should equal {'h', 'e', 'l', 'l', 'o'}
string decrypted = Decrypt(encrypted, 3);
</code>
