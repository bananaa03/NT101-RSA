using System.Numerics;

struct PublicKey
{
    public BigInteger n;
    public BigInteger e;
}
struct PrivateKey
{
    public BigInteger n;
    public BigInteger d;
}

namespace RSA
{
    class RSA
    {
        public BigInteger Encryption(BigInteger P, PublicKey x)
        {
            BigInteger C;
            C = pow(P, x.e, x.n);
            return C;
        }
        public BigInteger Decryption(BigInteger C, PrivateKey y)
        {
            BigInteger P;
            P = pow(C, y.d, y.n);
            return P;
        }
        public BigInteger pow(BigInteger a, BigInteger d, BigInteger n)
        {
            BigInteger result = 1;
            a = a % n;
            while (d > 0)
            {
                if ((d & 1) == 1) result = result * a % n;
                d >>= 1;
                a = a * a % n;
            }
            return result;
        }
    }
}
