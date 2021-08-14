using static System.Console;
using ConsoleTables;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            WriteLine("------------------------------------------------------------------------ ");
            WriteLine("Type    Byte(s) of memory             Min                            Max ");
            WriteLine("------------------------------------------------------------------------ ");
            WriteLine($"sbyte   {sizeof(sbyte),-2} {sbyte.MinValue,30} {sbyte.MaxValue,30}      ");
            WriteLine($"byte    {sizeof(byte),-2} {byte.MinValue,30} {byte.MaxValue,30}         ");
            WriteLine($"short   {sizeof(short),-2} {short.MinValue,30} {short.MaxValue,30}      ");
            WriteLine($"ushort  {sizeof(ushort),-2} {ushort.MinValue,30} {ushort.MaxValue,30}   ");
            WriteLine($"int     {sizeof(int),-2} {int.MinValue,30} {int.MaxValue,30}            ");
            WriteLine($"uint    {sizeof(uint),-2} {uint.MinValue,30} {uint.MaxValue,30}         ");
            WriteLine($"long    {sizeof(long),-2} {long.MinValue,30} {long.MaxValue,30}         ");
            WriteLine($"ulong   {sizeof(ulong),-2} {ulong.MinValue,30} {ulong.MaxValue,30}      ");
            WriteLine($"float   {sizeof(float),-2} {float.MinValue,30} {float.MaxValue,30}      ");
            WriteLine($"double  {sizeof(double),-2} {double.MinValue,30} {double.MaxValue,30}   ");
            WriteLine($"decimal {sizeof(decimal),-2} {decimal.MinValue,30} {decimal.MaxValue,30}");
            WriteLine("------------------------------------------------------------------------ ");
            */

            var table = new ConsoleTable("Type", "Byte(s) of memory", "Min", "Max");

            table.AddRow("sbyte",   sizeof(sbyte),      sbyte.MinValue,    sbyte.MaxValue   )
                 .AddRow("byte",    sizeof(byte),       byte.MinValue,     byte.MaxValue    )
                 .AddRow("short",   sizeof(short),      short.MinValue,    short.MaxValue   )
                 .AddRow("ushort",  sizeof(ushort),     ushort.MinValue,   ushort.MaxValue  )
                 .AddRow("int",     sizeof(int),        int.MinValue,      int.MaxValue     )
                 .AddRow("uint",    sizeof(uint),       uint.MinValue,     uint.MaxValue    )
                 .AddRow("long",    sizeof(long),       long.MinValue,     long.MaxValue    )
                 .AddRow("ulong",   sizeof(ulong),      ulong.MinValue,    ulong.MaxValue   )
                 .AddRow("float",   sizeof(float),      float.MinValue,    float.MaxValue   )
                 .AddRow("double",  sizeof(double),     double.MinValue,   double.MaxValue  )
                 .AddRow("decimal", sizeof(decimal),    decimal.MinValue,  decimal.MaxValue );

            table.Write();
            WriteLine();
        }
    }
}