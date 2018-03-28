using System;
using static System.Console;

namespace Day02
{
    public class CSharpOperator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public int Num4 { get; set; }


        public void Display()
        {
            WriteLine($"{nameof(Num1)}={Num1}");
            WriteLine($"{nameof(Num2)}={Num2}");
            WriteLine();
            ArithmeticOperators();
            RelationalOperators();
            LogicalOperators();
            BitwiseOperators();
            AssignmentOperators();
            OperatorPrecedence();
        }

       private void ArithmeticOperators()
        {
            WriteLine("\nArithmetic operators\n");
            WriteLine($"Operator '+' (add): {nameof(Num1)} + {nameof(Num2)} = {Num1 + Num2}");
            WriteLine($"Operator '-' (substract): {nameof(Num1)} - {nameof(Num2)} = {Num1 - Num2}");
            WriteLine($"Operator '*' (multiplication): {nameof(Num1)} * {nameof(Num2)} = {Num1 * Num2}");
            WriteLine($"Operator '/' (division): {nameof(Num1)} / {nameof(Num2)} = {Num1 / Num2}");
            WriteLine($"Operator '%' (modulus): {nameof(Num1)} % {nameof(Num2)} = {Num1 % Num2}");
            WriteLine($"Operator '++' (incremental): pre-increment: ++{nameof(Num1)} = {++Num1}");
            WriteLine($"Operator '++' (incremental): post-increment: {nameof(Num1)}++ = {Num1++}");
            WriteLine($"Operator '--' (decremental): pre-decrement: --{nameof(Num2)} = {--Num2}");
            WriteLine($"Operator '--' (decremental): post-decrement: {nameof(Num2)}-- = {Num2--}");
            ReadLine();
        }

        private void RelationalOperators()
        {
            WriteLine("\nRelational operators\n");
            WriteLine($"Operator '==' (equal): {nameof(Num1)} == {nameof(Num2)} = {Num1 == Num2}");
            WriteLine($"Operator '!=' (not equal): {nameof(Num1)} != {nameof(Num2)} = {Num1 != Num2}");
            WriteLine($"Operator '>' (greater than): {nameof(Num1)} > {nameof(Num2)} = {Num1 > Num2}");
            WriteLine($"Operator '<' (less than): {nameof(Num1)} < {nameof(Num2)} = {Num1 < Num2}");
            WriteLine($"Operator '>=' (greater than or equal): {nameof(Num1)} >= {nameof(Num2)} = {Num1 >= Num2}");
            WriteLine($"Operator '<=' (less than or equal): {nameof(Num1)} <= {nameof(Num2)} = {Num1 <= Num2}");
            ReadLine();
        }

        private void LogicalOperators()
        {
            WriteLine("\nLogical operators\n");
            var bln1 = Num1 == Num2;
            var bln2 = Num1 >= Num2;
            WriteLine($"{nameof(bln1)} = {bln1}");
            WriteLine($"{nameof(bln2)} = {bln2}");
            WriteLine();
            WriteLine($"Operator '&&' (AND): {nameof(bln1)} && {nameof(bln2)} = {bln1 && bln2}");
            WriteLine($"Operator '||' (OR): {nameof(bln1)} || {nameof(bln2)} = {bln1 || bln2}");
            WriteLine($"Operator '!' (NOT): {nameof(bln1)} ! {nameof(bln2)} = {!(bln1 && bln2)}");


            ReadLine();
        }

        private void BitwiseOperators()
        {
            WriteLine("\nBitwise operators\n");
            var bln1 = ConvertToBinaryEightBits(Num1); //8-bit
            var bln2 = ConvertToBinaryEightBits(Num2); //8-bit
            WriteLine($"Binary of {Num1} = {bln1}");
            WriteLine($"Binary of {Num2} = {bln2}");
            WriteLine();
            WriteLine($"Operator '|' (OR): {nameof(Num1)} | {nameof(Num2)} = {Num1 | Num2}");
            WriteLine($"In Binary: {bln1} | {bln2} = {ConvertToBinaryEightBits(Num1 | Num2)}");
            WriteLine($"Operator '&' (AND): {nameof(Num1)} & {nameof(Num2)} = {Num1 & Num2}");
            WriteLine($"In Binary: {bln1} & {bln2} = {ConvertToBinaryEightBits(Num1 & Num2)}");
            WriteLine($"Operator '^' (XOR): {nameof(Num1)} ^ {nameof(Num2)} = {Num1 ^ Num2}");
            WriteLine($"In Binary: {bln1} ^ {bln2} = {ConvertToBinaryEightBits(Num1 ^ Num2)}");
            WriteLine($"Operator '~' (COMPLEMENT): ~{nameof(Num1)} = {~Num1}");
            WriteLine($"In Binary: ~{bln1} = {ConvertToBinaryEightBits(~Num1)}");
            WriteLine($"Operator '~' (COMPLEMENT): ~{nameof(Num2)} = {~Num2}");
            WriteLine($"In Binary: ~{bln2} = {ConvertToBinaryEightBits(~Num2)}");
            WriteLine($"Operator '<<' (Shift Left): {nameof(Num1)}<<1 = {Num1 << 1}");
            WriteLine($"In Binary: {bln1}<<1 = {ConvertToBinaryEightBits(Num1 << 1)}");
            WriteLine($"Operator '>>' (Shift Right): {nameof(Num1)}>>1 = {Num1 >> 1}");
            WriteLine($"In Binary: {bln1}>>1 = {ConvertToBinaryEightBits(Num1 >> 1)}");

            ReadLine();
        }

        private void AssignmentOperators()
        {
            var result = 0;
            WriteLine("\nAssignment operators\n");
            WriteLine($"Operator '=' (assignmnet): {nameof(result)}={nameof(Num1)} + {nameof(Num2)} where {nameof(result)} contains value: {Num1+Num2}");
            WriteLine($"Operator '+=' (add and assign): {nameof(result)}+={nameof(Num1)}  where {nameof(result)} contains value: {result+=Num1}");
            WriteLine($"Operator '-=' (substrcat and assign): {nameof(result)}-={nameof(Num1)}  where {nameof(result)} contains value: {result -= Num1}");
            WriteLine($"Operator '*=' (multiply and assign): {nameof(result)}*={nameof(Num1)}  where {nameof(result)} contains value: {result *= Num1}");
            WriteLine($"Operator '/=' (divide and assign): {nameof(result)}/={nameof(Num1)}  where {nameof(result)} contains value: {result /= Num1}");
            WriteLine($"Operator '%=' (modulus and assign): {nameof(result)}%={nameof(Num1)}  where {nameof(result)} contains value: {result %= Num1}");

            ReadLine();
        }

        private void OperatorPrecedence()
        {
            Write("Enter first number:");
            Num1 = Convert.ToInt32(ReadLine());
            Write("Enter second number:");
            Num2 = Convert.ToInt32(ReadLine());
            Write("Enter third number:");
            Num3 = Convert.ToInt32(ReadLine());
            Write("Enter fourth number:");
            Num4 = Convert.ToInt32(ReadLine());
            int result = Num1 + Num2 * Num3/Num4;
            WriteLine($"Num1 + Num2 * Num3/Num4 = {result}");
            result = Num1 + Num2 * (Num3 / Num4);
            WriteLine($"Num1 + Num2 * (Num3/Num4) = {result}");
            result = (Num1 + (Num2 * Num3)) / Num4;
            WriteLine($"(Num1 + (Num2 * Num3)) /Num4 = {result}");
            result = (Num1 + Num2) * Num3 / Num4;
            WriteLine($"(Num1 + Num2) * Num3/Num4 = {result}");
            ReadLine();
        }

        private string ConvertToBinaryEightBits(int number) => Convert.ToString(number, 2).PadLeft(8,'0');
    }

    public struct Coordinate
    {
        public bool Equals(Coordinate other) => _xAxis == other._xAxis && _yAxis == other._yAxis;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Coordinate && Equals((Coordinate) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_xAxis * 397) ^ _yAxis;
            }
        }

        private readonly int _xAxis;
        private readonly int _yAxis;
        public Coordinate(int xAxis, int yAxis)
        {
            _xAxis = xAxis;
            _yAxis = yAxis;
        }

        public static Coordinate operator +(Coordinate coordinate1, Coordinate coordinate2) =>
            new Coordinate(coordinate1._xAxis + coordinate2._xAxis, coordinate1._yAxis + coordinate2._yAxis);
        public static Coordinate operator-(Coordinate coordinate1, Coordinate coordinate2) =>
            new Coordinate(coordinate1._xAxis - coordinate2._xAxis, coordinate1._yAxis - coordinate2._yAxis);
        public static Coordinate operator *(Coordinate coordinate1, Coordinate coordinate2) =>
            new Coordinate(coordinate1._xAxis * coordinate2._xAxis, coordinate1._yAxis * coordinate2._yAxis);
        public static Coordinate operator /(Coordinate coordinate1, Coordinate coordinate2) =>
            new Coordinate(coordinate1._xAxis / coordinate2._xAxis, coordinate1._yAxis / coordinate2._yAxis);
        public static Coordinate operator %(Coordinate coordinate1, Coordinate coordinate2) =>
            new Coordinate(coordinate1._xAxis % coordinate2._xAxis, coordinate1._yAxis % coordinate2._yAxis);

        public static bool operator ==(Coordinate coordinate1, Coordinate coordinate2) =>
            coordinate1._xAxis == coordinate2._xAxis && coordinate1._yAxis == coordinate2._yAxis;

        public static bool operator !=(Coordinate coordinate1, Coordinate coordinate2) => !(coordinate1 == coordinate2);

        public static bool operator <(Coordinate coordinate1, Coordinate coordinate2) =>
            coordinate1._xAxis < coordinate2._xAxis && coordinate1._yAxis < coordinate2._yAxis;

        public static bool operator >(Coordinate coordinate1, Coordinate coordinate2) =>
            coordinate1._xAxis > coordinate2._xAxis && coordinate1._yAxis > coordinate2._yAxis;

        public static bool operator <=(Coordinate coordinate1, Coordinate coordinate2) =>
            coordinate1._xAxis <= coordinate2._xAxis && coordinate1._yAxis <= coordinate2._yAxis;

        public static bool operator >=(Coordinate coordinate1, Coordinate coordinate2) =>
            coordinate1._xAxis >= coordinate2._xAxis && coordinate1._yAxis >= coordinate2._yAxis;

        public double Area() => _xAxis * _yAxis;

        public override string ToString() => $"({_xAxis},{_yAxis})";
    }
}