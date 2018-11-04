using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void EncryptDecryptTest()
    {
        for (var i = 0; i < 100; ++i)
        {
            var clear = RandomString.Generate(200, RandomString.Chars.All);
            var pass = RandomString.Generate(32, RandomString.Chars.English | RandomString.Chars.Numbers);

            var bf = new Blowfish(pass);
            var encrypted = bf.Encrypt(clear);
            var decrypted = bf.Decrypt(encrypted);

            Assert.True(clear == decrypted);
        }
    }
}
