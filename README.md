This is implementation of symmetric-key block cipher, designed in 1993 by Bruce Schneier. 

The algorithm can encrypt/decrypt following types:
-Int32 and Int64
-UInt32 and UInt64
-byte array
-string

For performance, security or special storage process requirements you can use your methods for converting a string to a byte array and back. Just inject functions to the overrided constructor.

```csharp
BlowFish(string password, Func<string, byte[]> stringToBytes, Func<byte[], string> bytesToString)
```

Encoding.UTF8 using for converting by default. The code can safety work on both big and little endian mashines, and work correct even with simple casting to bytes char by char.

For additional security please use a code obfuscation. You can also change SBoxes and PKey, the Pi digits are using by default.