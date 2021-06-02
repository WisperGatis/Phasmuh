var rand = new Random();

var GhostArea = new byte[5];
rand.NextBytes(bytes);
Console.WriteLine("Five random byte values:");
foreach (byte byteValue in bytes)
    Console.Write("{0, 5}", byteValue);
Console.WriteLine();

Console.WriteLine("Five random integer values:");
for (int ctr = 0; ctr <= 4; ctr++)
    Console.Write("{0,15:N0}", rand.Next());
Console.WriteLine();

Console.WriteLine("Five random integers between 0 and 100:");
for (int ctr = 0; ctr <= 4; ctr++)
    Console.Write("{0,8:N0}", rand.Next(101));
Console.WriteLine();

Console.WriteLine("Five random integers between 50 and 100:");
for (int ctr = 0; ctr <= 4; ctr++)
    Console.Write("{0,8:N0}", rand.Next(50, 101));
Console.WriteLine();

Console.WriteLine("Five Doubles.");
for (int ctr = 0; ctr <= 4; ctr++)
    Console.Write("{0,8:N3}", rand.NextDouble());
Console.WriteLine();

Console.WriteLine("Five Doubles between 0 and 5.");
for (int ctr = 0; ctr <= 4; ctr++)
    Console.Write("{0,8:N3}", rand.NextDouble() * 5);
