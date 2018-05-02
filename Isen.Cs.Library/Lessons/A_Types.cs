using System;

namespace Isen.Cs.Library.Lessons
{
    public class A_Types
    {
        public void PrimitiveTypes()
        {
            // short : entier 16 bits signé
            short s = 12;
            // short et System.Int16 sont synonymes
            Int16 shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            // Concaténation avec +
            Console.WriteLine(
                "short (Int16) range : " + shortMin + " < " + s + " < " + shortMax);
            // String.Format (comme en java)
            Console.WriteLine(
                String.Format("short (Int16) range : {0} < {1} < {2}", shortMin, s, shortMax));
            // Syntaxe $"....{variable}...." : string interpolation (C# 6 et +)
            Console.WriteLine(
                $"short (Int16) range : {shortMin} < {s} < {shortMax}");

            // Liste des primitifs entiers (pages 14 et 15)
            // Toujours préférer la version courte quand elle existe
            // short/Int16
            // ushort/UInt16
            // int/Int32
            // uint/UInt32
            // long/Int64
            // ulong/UInt64

            // Litéraux
            // litéral de string
            string myString = "Hello"; // Ceci est un litéral
            // Litéraux des entiers
            // Le underscore est autorisé sur les types numériques
            // Pour la lisibilité
            int veryMuch = 123_456_789;
            // Types numériques décimaux
            // Par défaut, un litéral à virgule est un double
            double dbl = 12.3;
            double dblExplicit = 12.3d;
            float flt = 12.3f;
            decimal dec = 12.3m;
            // Cast explicite
            double castDbl = (double)flt;

            // Bits (bool), octets (Bytes)
            bool bTrue = true;
            Boolean bFalse = !bTrue;
            // sbyte : entier signé
            sbyte byteB = 0b101_1110;
            SByte minusByteB = -0xF;
            Console.WriteLine($"sbytes : {byteB} = {(int)byteB}");
            Console.WriteLine($"sbytes : {minusByteB} = {(int)minusByteB}");
            // Byte : non signé
            byte byteBB = 0xFF;
            Byte byteBB2 = 0b1111_1111;
            Console.WriteLine($"bytes : {byteBB} = {(int)byteBB}");
            Console.WriteLine($"bytes : {byteBB} = {(char)byteBB}");
            
            // Char
            char letterC = 'c';
            Console.WriteLine($"Le code ASCII de {letterC} est {(int)letterC}");
            int ascii80 = 80;
            Console.WriteLine($"Le code ASCII de {(char)ascii80} est {ascii80}");

            // object <=> System.Object
            string str2 = "Hello"; // string <=> System.String
            object oStr2 = (object)str2;
            Console.WriteLine($"oStr2 = {oStr2}");
            Console.WriteLine($"typeof(oStr2) = {oStr2.GetType()}");
            // is pour tester si une variable est d'un certain type
            Console.WriteLine($"is oStr2 a string ? {oStr2 is string}"); // true
            Console.WriteLine($"is oStr2 a string ? {oStr2.GetType() == typeof(string)}"); // true
            Console.WriteLine($"is oStr2 a object ? {oStr2 is object}"); // true
            Console.WriteLine($"is oStr2 a int ? {oStr2 is int}"); // false

            // Casts
            int myInt = 42;
            object objMyInt = (object)myInt;
            // Compile error
            // string castIntToString = (string)myInt;
            // runtime error car cast impossible
            //string castIntToString = (string)objMyInt;
            // Cast => null
            string castIntToString = objMyInt as string; // castIntToString == null;
            Console.WriteLine($"castIntToString is null ? {castIntToString == null}");
            // Convertir
            string intDisplayedAsString = myInt.ToString();
            Console.WriteLine(intDisplayedAsString);
        }
    }
}