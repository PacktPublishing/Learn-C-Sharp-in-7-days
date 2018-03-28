using System.Collections.Generic;
using static System.Console;

namespace Day02
{
    /// <summary>
    /// Formatting:https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netcore-2.0
    /// </summary>
    public class CSharpType
    {
        public static void Display()
        {
            WriteLine("Table :: Data Types");
            var dataTypes = DataTypes();
            WriteLine(RepeatIt('\u2500', 100));
            WriteLine("{0,-10} {1,-20} {2,-50} {3,-5}", "Type", "CLR Type", "Range", "Default Value");
            WriteLine(RepeatIt('\u2500', 100));
            foreach (var dataType in dataTypes)
                WriteLine("{0,-10} {1,-20} {2,-50} {3,-5}", dataType.Type, dataType.CLRType, dataType.Range,
                    dataType.DefaultValue);
            WriteLine(RepeatIt('\u2500', 100));
        }

        private static List<DataType> DataTypes()
        {
            sbyte eightBitSignedInteger = 0;
            short sixteenBitSignedInteger = 0;
            int thirtytwoBitSignedInteger = 0;
            long sixtyfourBitsignedInteger = 0L;
            byte eightBitunsignedInteger = 0;
            ushort sixteenBitUnsignedInteger = 0;
            uint thirtytwoBitUnsignedInteger = 0;
            ulong sixtyfourBitUnsignedInteger = 0;
            char UTFSixteenCodeUnitCharacter = '\0';
            float singlepreciationPointfloatingNumber = 0.0F;
            double doublepreciationPointfloatingNumber = 0.0D;
            decimal  decimalNumber = 0.0M;
            bool boolean = false;

            
           return new List<DataType>
            {
                new DataType
                {
                    Type = "sbyte",
                    CLRType = eightBitSignedInteger.GetType().FullName,
                    DefaultValue = eightBitSignedInteger.ToString(),
                    Range = $"{sbyte.MinValue} to {sbyte.MaxValue}"
                },
                new DataType
                {
                    Type = "short",
                    CLRType = sixteenBitSignedInteger.GetType().FullName,
                    DefaultValue = sixteenBitSignedInteger.ToString(),
                    Range = $"{short.MinValue} to {short.MaxValue}"
                },
                new DataType
                {
                    Type = "int",
                    CLRType = thirtytwoBitSignedInteger.GetType().FullName,
                    DefaultValue = thirtytwoBitSignedInteger.ToString(),
                    Range = $"{int.MinValue} to {int.MaxValue}"
                },
                new DataType
                {
                    Type = "long",
                    CLRType = sixtyfourBitsignedInteger.GetType().FullName,
                    DefaultValue = sixtyfourBitsignedInteger.ToString("0L"),
                    Range = $"{long.MinValue:E} to {long.MaxValue:E}"
                },
                new DataType
                {
                    Type = "byte",
                    CLRType = eightBitunsignedInteger.GetType().FullName,
                    DefaultValue = eightBitunsignedInteger.ToString(),
                    Range = $"{byte.MinValue} to {byte.MaxValue}"
                },
                new DataType
                {
                    Type = "ushort",
                    CLRType = sixteenBitUnsignedInteger.GetType().FullName,
                    DefaultValue = sixteenBitUnsignedInteger.ToString(),
                    Range = $"{ushort.MinValue} to {ushort.MaxValue}"
                },
                new DataType
                {
                    Type = "uint",
                    CLRType = thirtytwoBitUnsignedInteger.GetType().FullName,
                    DefaultValue = thirtytwoBitUnsignedInteger.ToString(),
                    Range = $"{uint.MinValue} to {uint.MaxValue}"
                },
                new DataType
                {
                    Type = "ulong",
                    CLRType = sixtyfourBitUnsignedInteger.GetType().FullName,
                    DefaultValue = sixtyfourBitUnsignedInteger.ToString(),
                    Range = $"{ulong.MinValue} to {ulong.MaxValue}"
                },
                new DataType
                {
                    Type = "char",
                    CLRType = UTFSixteenCodeUnitCharacter.GetType().FullName,
                    DefaultValue = "\\0",
                    Range = "U +0000 to  U +ffff"
                },
                new DataType
                {
                    Type = "float",
                    CLRType = singlepreciationPointfloatingNumber.GetType().FullName,
                    DefaultValue = singlepreciationPointfloatingNumber.ToString("0.0F"),
                    Range = $"{float.MinValue:E} to {float.MaxValue:E}"
                },
                new DataType
                {
                    Type = "double",
                    CLRType = doublepreciationPointfloatingNumber.GetType().FullName,
                    DefaultValue = doublepreciationPointfloatingNumber.ToString("0.0D"),
                    Range = $"{double.MinValue:E} to {double.MaxValue:E}"
                },
                new DataType
                {
                    Type = "decimal",
                    CLRType = decimalNumber.GetType().FullName,
                    DefaultValue = decimalNumber.ToString("0.0M"),
                    Range = $"{decimal.MinValue:E2} to {decimal.MaxValue:E2}"
                }
                ,
                new DataType
                {
                    Type = "bool",
                    CLRType = boolean.GetType().FullName,
                    DefaultValue = boolean.ToString(),
                    Range = $"{bool.TrueString} to {bool.FalseString}"
                }
            };
        }
        private static string RepeatIt(char c, int length)
        {
            
            return new string(c, length);
        }
        public class DataType
        {
            public string Type { get; set; }
            public string CLRType { get; set; }
            public string Range { get; set; }
            public string DefaultValue { get; set; }
        }
    }

    public struct BookAuthor
    {
        public string Name;
        public string BookTitle;
        public int Age;
        public string City;
        public string State;
        public string Country;

        public BookAuthor(string name, string bookTitle, int age, string city, string state, string country)
        {
            Name = name;
            BookTitle = bookTitle;
            Age = age;
            City = city;
            State = state;
            Country = country;
        }

        public override string ToString()
        {
            return $"Author {Name} is of {Age} yrs old from {City},{State},{Country} has written book: '{BookTitle}'";
        }
    }

    public class ClassBookAuthor
    {
        public string Name;
        public string BookTitle;
        public int Age;
        public string City;
        public string State;
        public string Country;

        public ClassBookAuthor(string name, string bookTitle, int age, string city, string state, string country)
        {
            Name = name;
            BookTitle = bookTitle;
            Age = age;
            City = city;
            State = state;
            Country = country;
        }

        public override string ToString()
        {
            return $"Author {Name} is of {Age} yrs old from {City},{State},{Country} has written book: '{BookTitle}'";
        }
    }
}