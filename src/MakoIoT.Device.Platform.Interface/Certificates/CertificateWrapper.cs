using System.Security.Cryptography.X509Certificates;

namespace MakoIoT.Device.Platform.Interface.Certificates
{
    //In unit tests we can't use X509Certificate as ParseCertificate is not implemented. So we need this wrapper.
    public class CertificateWrapper
    {
        private string _certStr;
        private X509Certificate _cert;

        public CertificateWrapper(string certStr)
        {
            _certStr = certStr;
        }

        public X509Certificate X509Certificate
        {
            get
            {
                if (_cert == null)
                {
                    _cert = new X509Certificate(_certStr);
                    _certStr = null;
                }

                return _cert;
            }
        }

        public bool IsEqual(CertificateWrapper cert)
        {
            return _certStr == cert._certStr;
        }
    }
}
