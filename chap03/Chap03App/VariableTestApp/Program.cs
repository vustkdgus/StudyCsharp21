﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int v1 = 30, v2 = 40;
             int result = v1 + v2;
             Console.WriteLine("결과는 " + result);*/
            // byte 형
            sbyte sbMinVal = sbyte.MinValue, sbMaxVal = sbyte.MaxValue;
            Console.WriteLine($"sbyte 최소, 최대값은 {sbMinVal}, {sbMaxVal} 입니다.");
            byte bMinVal = byte.MinValue, bMaxbal = byte.MaxValue;
            Console.WriteLine($"byte 최소, 최대값은 {bMinVal}, {bMaxbal} 입니다.");
            // short 형
            short shMinVal = short.MinValue, shMaxVal = short.MaxValue;
            Console.WriteLine($"short 최소, 최대값은 {shMinVal}, {shMaxVal} 입니다.");
            ushort usMinVal = ushort.MinValue, usMaxVal = ushort.MaxValue;
            Console.WriteLine($"ushort 최소, 최대값은 {usMinVal}, {usMaxVal} 입니다.");
            // int 형
            int inMinVal = int.MinValue, inMaxVal = int.MaxValue;
            Console.WriteLine($"int 최소, 최대값은 {inMinVal}, {inMaxVal} 입니다.");
            uint uiMinVal = uint.MinValue, uiMaxVal = uint.MaxValue;
            Console.WriteLine($"ushort 최소, 최대값은 {uiMinVal}, {uiMaxVal} 입니다.");
            // long 형
            long lnMinVal = long.MinValue, lnMaxVal = long.MaxValue;
            Console.WriteLine($"long 최소, 최대값은 {lnMinVal}, {lnMaxVal} 입니다.");
            ulong ulMinVal = ulong.MinValue, ulMaxVal = ulong.MaxValue;
            Console.WriteLine($"ushort 최소, 최대값은 {ulMinVal}, {ulMaxVal} 입니다.");

            // float형
            float fMinVal = float.MinValue, fMaxVal = float.MaxValue;
            Console.WriteLine($"float 최소,최대값은 {fMinVal},{fMaxVal} 입니다.");
            // double형
            double dMinVal = double.MinValue, dMaxVal = double.MaxValue;
            Console.WriteLine($"double 최소,최대값은 {dMinVal},{dMaxVal} 입니다.");
            // decimal형
            decimal dcMinVal = decimal.MinValue, dcMaxVal = decimal.MaxValue;
            Console.WriteLine($"decimal 최소,최대값은 {dcMinVal},{dcMaxVal} 입니다.");
        }
    }
}
