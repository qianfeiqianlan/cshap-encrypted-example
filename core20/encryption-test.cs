using System;
using System.Security.Cryptography;
using System.Text;
using XC.RSAUtil;
using Xunit;

namespace core20
{
    public class Tests
    {
        private string PublicKey = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC4xKeUgQ+Aoz7TLfAfs9+paePb
5KIofVthEopwrXFkp8OCeocaTHt9ICjTT2QeJh6cZaDaArfZ873GPUn00eOIZ7Ae
+TiA2BKHbCvloW3w5Lnqm70iSsUi5Fmu9/2+68GZRH9L7Mlh8cFksCicW2Y2W2uM
GKl64GDcIq3au+aqJQIDAQAB
-----END PUBLIC KEY-----";

        [Fact]
        public void Test1()
        {
            var util = new RsaPkcs1Util(Encoding.UTF8, PublicKey);
            var messageAfterEncrypted = util.Encrypt("Message will be encrypted", RSAEncryptionPadding.Pkcs1);
            Assert.NotNull(messageAfterEncrypted);
        }
    }
}
