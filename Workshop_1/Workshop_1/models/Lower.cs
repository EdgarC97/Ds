using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public static class Lower
    {
        public static string? Input { get; set; }

        public static string ToLowerCase(string input)
        {
            return $"Tu palabra en minusculas es --> {input.ToLower()}";
        }
    }
}