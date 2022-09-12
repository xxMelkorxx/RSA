using System;
using System.Numerics;
using System.Text;

namespace RSA
{
    class RSA
    {
        private static Random rnd;
        /// <summary>
        /// Метод кодировки.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        public static BigInteger[] EncryptRSA(char[] M, uint e, uint n)
        {
            var length = M.Length;
            var bigIntC = new BigInteger[length];
            var byteM = Encoding.Default.GetBytes(M, 0, M.Length);
            for (var i = 0; i < length; i++)
                bigIntC[i] = BigInteger.ModPow(byteM[i], e, n);
            return bigIntC;
        }
        /// <summary>
        /// Метод декодировки.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        public static string DecryptRSA(BigInteger[] bigIntC, uint d, uint n)
        {
            var length = bigIntC.Length;
            var bigIntM = new BigInteger[length];
            var byteM = new byte[length];
            for (var i = 0; i < length; i++)
            {
                bigIntM[i] = BigInteger.ModPow(bigIntC[i], d, n);
                byteM[i] = (byte)bigIntM[i];
            }
            string M = Encoding.Default.GetString(byteM);
            return M;
        }
        /// <summary>
        /// Метод генерации ключей.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <param name="n"></param>
        public static void GenerateKeys(out uint e, out uint d, out uint n)
        {
            rnd = new Random(DateTime.Now.Millisecond);
            GeneratePQ(out uint p, out uint q);
            n = p * q;                          // Модуль системы
            uint fn = (p - 1) * (q - 1);        // Значение функции Эйлера от модуля системы
            e = GenerateE(fn);
            while (true)
            {
                GCD(e, fn, out int l, out _);
                if (l > 0)
                {
                    d = (uint)l;
                    if ((ulong)(e * d) % fn != 1) break;
                }
                e = GenerateE(fn);
            }
        }

        /// <summary>
        /// Генерация числа е
        /// </summary>
        /// <param name="fn"></param>
        /// <returns></returns>
        private static uint GenerateE(uint fn)
        {
            uint e = (uint)(rnd.Next(0, (int)(fn >> 2)) + rnd.Next(0, (int)(fn >> 2)));
            while (!BigInteger.GreatestCommonDivisor(e, fn).IsOne)
                e = (uint)(rnd.Next(0, (int)(fn >> 2)) + rnd.Next(0, (int)(fn >> 2)));

            return e;
        }
        /// <summary>
        /// Генерация p и q - простые числа одинакового порядка.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static void GeneratePQ(out uint p, out uint q)
        {
            rnd = new Random(DateTime.Now.Millisecond);
            p = FermaTest();
            q = FermaTest();
            var lengthP = p.ToString().Length;
            var lengthQ = q.ToString().Length;
            if (lengthP > lengthQ)
                while (lengthP > lengthQ)
                {
                    q = FermaTest();
                    lengthQ = q.ToString().Length;
                }
            else
                while (lengthP > lengthQ)
                {
                    p = FermaTest();
                    lengthP = p.ToString().Length;
                }
        }
        /// <summary>
        /// Поиск наибольшего общего делителя.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static uint GCD(uint a, uint b, out int x, out int y)
        {
            if (b < a)
            {
                uint r = a;
                a = b;
                b = r;
            }
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            uint gcd = GCD(b % a, a, out x, out y);

            int newY = x;
            int newX = checked(y - (int)(b / a) * x);

            x = newX;
            y = newY;
            return gcd;
        }
        /// <summary>
        /// Тест ферма на простоту.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private static uint FermaTest()
        {
            uint n = (uint)rnd.Next(30000, 65535);
            for (uint a = 1; a < 100; a++)
                while (BigInteger.ModPow(a, n - 1, n) != 1)
                    n = (uint)rnd.Next(30000, 65535);
            return n;
        }
    }
}