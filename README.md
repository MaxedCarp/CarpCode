# CarpCode
Allows the creation of complex passwords using a code and a key.

Arguments
-
Key:
t: Text. When encoding using the Text modifier, the piece of code will remain the same at that spot.
a: ASCII. Every key in your keyboard has a numeric value behind it. This is called ASCII.
b: Basic. Every letter in the alphabet will always remain in it's own spot in the order. So both A and a will remain 1, B and b will remain 2, ETC.

Commands
-
KeyEncode \<code\> \<key\>
This command uses a key to turn the code into an unreadable message.
Code: A piece of text you want to encode.
Key: A piece of text at the length of your code which is combined from modifiers (look above) to turn your code into an encrypted message.

KeyEncode+ \<code\> \<key\>
KeyEncode+ does the same as KeyEncode but copies the result into your clipboard.

RNDEncode \<code\>
This command randomizes a key and uses it to encrypt your code. It will print both the result, the code and the key it used.
Code: A piece of text you want to encode.

NOT YET IMPLEMENTED FEATURES
-
Decode \<code\> \<key\>
This command will allow you to decode a code using a key back into the original piece of text that was used to create it.
Code: An encrypted code that was made previously using this application.
Key: The key that was used to create the encrypted code.
