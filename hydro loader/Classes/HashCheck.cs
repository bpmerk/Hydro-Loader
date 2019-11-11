using System;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Threading;

namespace hydroLIB
{
    class HashCheck
        {
            public static bool isValidDLL = false;
            public static void HashChecks()
            {
                // 1st one is NewtonJson Hash, 2nd is AuthGG.dll to get updated hash download hash checker and drag the dll ontop of the unopened app!
                if (CalculateMD5("Newtonsoft.Json.dll") != "a907da945d77abd7d7ad83bbcbd67b68" || CalculateMD5(typeof(AuthGG.Auth).Assembly.Location) != "1d8da1d2798a45abfba937047a78e004")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hashcheck has failed!");
                    Thread.Sleep(3000);
                    Process.GetCurrentProcess().Kill();
                }
                else
                {
                    isValidDLL = true;
                }
            }
            private static string CalculateMD5(string filename)
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filename))
                    {
                        var hash = md5.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
        }
}

