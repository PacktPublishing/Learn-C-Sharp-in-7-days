using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;

namespace Day02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WriteLine("Day02 - Learn C# in 7-days");
            
            

            int userInput;
            do
            {
                userInput = DisplayMenu();
                switch (userInput)
                {
                    case 1:
                        Clear();
                        SameClassDifferentNamespacesExample();
                        PressAnyKey();
                        break;
                    case 2:
                        Clear();
                        ConsoleOperationExamples();
                        PressAnyKey();
                        break;
                    case 3:
                        Clear();
                        ConsoleBeepExample();
                        PressAnyKey();
                        break;
                    case 4:
                        Clear();
                        ExampleIsAsOperator();
                        PressAnyKey();
                        break;
                    case 5:
                        Clear();
                        CheckOverFlowExample();
                        PressAnyKey();
                        break;
                    case 6:
                        Clear();
                        SizeofExample();
                        PressAnyKey();
                        break;
                    case 7:
                        Clear();
                        TypeofExample();
                        PressAnyKey();
                        break;
                    case 8:
                        Clear();
                        UsingExample();
                        PressAnyKey();
                        break;
                    case 9:
                        Clear();
                        DynamicTypeExample();
                        PressAnyKey();
                        break;
                    case 10:
                        Clear();
                        DataTypeExample();
                        PressAnyKey();
                        break;
                    case 11:
                        Clear();
                        BoxingUnboxingExample();
                        PressAnyKey();
                        break;
                    case 12:
                        Clear();
                        OperatorExample();
                        PressAnyKey();
                        break;
                    case 13:
                        Clear();
                        OperatorOverloadigExample();
                        PressAnyKey();
                        break;
                    case 14:
                  Clear();
                        ImplicitExplicitTypeConversionExample();
                        PressAnyKey();
                        break;
                    case 15:
                        Clear();
                        StatementExample();
                        PressAnyKey();
                        break;
                    case 16:
                        Clear();
                        IfStatementExample();
                        PressAnyKey();
                        break;
                    case 17:
                        Clear();
                        IfElseStatementExample();
                        PressAnyKey();
                        break;
                    case 18:
                        Clear();
                        IfElseIfElseStatementExample();
                        PressAnyKey();
                        break;
                    case 19:
                        Clear();
                        NestedIfStatementExample();
                        PressAnyKey();
                        break;
                    case 20:
                        Clear();
                        SwitchCaseExample();
                        PressAnyKey();
                        break;
                    case 21:
                        Clear();
                        DoWhileStatementExample();
                        PressAnyKey();
                        break;
                    case 22:
                        Clear();
                        WhileStatementExample();
                        PressAnyKey();
                        break;
                    case 23:
                        Clear();
                        ForStatementExample();
                        PressAnyKey();
                        break;
                    case 24:
                        Clear();
                        ForEachStatementExample();
                        PressAnyKey();
                        break;
                    case 25:
                        Clear();
                        BreakStatementExample();
                        PressAnyKey();
                        break;
                    case 26:
                        Clear();
                        ContinueStatementExample();
                        PressAnyKey();
                        break;
                    case 27:
                        Clear();
                        ArrayExample();
                        PressAnyKey();
                        break;
                    case 28:
                        Clear();
                        StringExample();
                        PressAnyKey();
                        break;
                    case 29:
                        Clear();
                        StructureExample();
                        PressAnyKey();
                        break;
                }
            } while (userInput !=30);


        }
        private static void PressAnyKey()
        {
            Write("Press any key...");
            ReadLine();
            Clear();
        }

        private static int DisplayMenu()
        {
            return ToInt32(SelectedMenu());
        }

        private static int SelectedMenu()
        {
            WriteLine("Example - Day02: Learn C# in 7-days");
            WriteLine();
            WriteLine("1. Same Class Different Namespaces Example.");
            WriteLine("2. Console Operation Example.");
            WriteLine("3. Console Beep Example.");
            WriteLine("4. Example Is As Operator.");
            WriteLine("5. Check Over Flow Example.");
            WriteLine("6. Size of Example.");
            WriteLine("7. Type of Example");
            WriteLine("8. Using Example.");
            WriteLine("9. Dynamic Type Example.");
            WriteLine("10. Data Type Example.");
            WriteLine("11. Boxing Unboxing Example.");
            WriteLine("12. Operator Example.");
            WriteLine("13. Operator Overloadig Example.");
            WriteLine("14. Implicit Explicit Type Conversion Example.");
            WriteLine("15. Statement Example.");
            WriteLine("16. If Statement Example.");
            WriteLine("17. IfElse Statement Example.");
            WriteLine("18. IfElseIfElse Statement Example.");
            WriteLine("19. Nested If Statement Example.");
            WriteLine("20. Switch Case Example.");
            WriteLine("21. Do While Statement Example.");
            WriteLine("22. While Statement Example.");
            WriteLine("23. For Statement Example.");
            WriteLine("24. ForEach Statement Example.");
            WriteLine("25. Break Statement Example.");
            WriteLine("26. Continue Statement Example.");
            WriteLine("27. Array Example.");
            WriteLine("28. String Example.");
            WriteLine("29. Structure Example.");
            WriteLine("30. Exit");
            Write("Enter choice (1-30): ");
            var result = ReadLine();
            return string.IsNullOrEmpty(result) ? 0 : ToInt32(result);
        }
        private static void StructureExample()
        {
            WriteLine("Structure example\n");
            Write("Author name:");
            var name = ReadLine();
            Write("Book Title:");
            var bookTitle = ReadLine();
            Write("Author age:");
            var age = ReadLine();
            Write("Author city:");
            var city = ReadLine();
            Write("Author state:");
            var state = ReadLine();
            Write("Author country:");
            var country = ReadLine();

            BookAuthor author = new BookAuthor(name,bookTitle,Convert.ToInt32(age),city,state,country);
            WriteLine($"{author.ToString()}");
            BookAuthor author1 = author; //copy structur, it will copy only data as this is not a class

            Write("Change author name:");
            var name1 = ReadLine();
            author.Name = name1;

            WriteLine("Author1");
            WriteLine($"{author.ToString()}");
            WriteLine("Author2");
            WriteLine($"{author1.ToString()}");
        }

        private static void StringExample()
        {
            WriteLine("String object creation");
            string authorName = "Gaurav Aroraa"; //string literal assignment
            WriteLine($"{authorName}");
            string property = "Name: ";
            string person = "Gaurav";
            string personName = property + person; //string concatenation
            WriteLine($"{personName}");

            char[] langauge = {'c', 's', 'h', 'a', 'r', 'p'};
            string strLanguage = new string(langauge); //initializing the cosntructor
            WriteLine($"{strLanguage}");
            string repeatMe = new string('*', 5);
            WriteLine($"{repeatMe}");
            string[] members = {"Shivprasad", "Denim", "Vikas", "Gaurav"};
            string name = string.Join(" ", members); //method returing string
            WriteLine($"{name}");
        }

        private static void ArrayExample()
        {
            var charArray = new[] {'a', 'e', 'i', 'o', 'u'};
            string[] cardinalDirections = {"North","East","South","West"};
            //char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            WriteLine("One-Dimensional array.\n");
            WriteLine("Array example.\n");
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            WriteLine("char[] vowels = {'a', 'e', 'i', 'o', 'u'};\n");
            WriteLine("acces array using for loop");
            for (int rankIndex = 0; rankIndex < vowels.Length; rankIndex++)
            {
                Write($"{vowels[rankIndex]} ");
            }
            WriteLine();
            WriteLine("acces array using foreach loop");
            foreach (char vowel in vowels)
            {
                Write($"{vowel} ");
            }
            WriteLine("Two-Dimensional array.\n");

            //int[,] numbers = new int[2, 2];
            int[,] numbers = new int[2, 2] {{1,2},{3,4} };
            for (int rowsIndex = 0; rowsIndex < 2; rowsIndex++)
            {
                for (int colIndex = 0; colIndex < 2; colIndex++)
                {
                    WriteLine($"numbers[{rowsIndex},{colIndex}] = {numbers[rowsIndex, colIndex]}");
                }
            }

            WriteLine("Jagged array.\n");
            string[][,] collaborators = new string[3][,]
            {
                new[,] {{"Name", "Shivprasad Koirala"}, {"Age", "40"}},
                new[,] {{"Name", "Gaurav Aroraa" }, {"Age", "43"}},
                new[,] {{"Name", "Vikas Tiwari"}, {"Age", "28"}}
            };

            for (int index = 0; index < collaborators.Length; index++)
            {
                for (int rowIndex = 0; rowIndex < 2; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < 2; colIndex++)
                    {
                        WriteLine($"collaborators[{index}][{rowIndex},{colIndex}] = {collaborators[index][rowIndex,colIndex]}");
                    }
                }
            }



        }

        private static void BreakStatementExample()
        {
            WriteLine("break statement example");
            WriteLine("break in for loop");
            for (int count = 0; count < 50; count++)
            {
                if (count == 8)
                {
                    break;
                }
                WriteLine($"{count}");
            }
            WriteLine();
            WriteLine("break in switch statement");
            SwitchCaseExample();
        }

        private static void ContinueStatementExample()
        {
            WriteLine("continue statement example");
            WriteLine("continue in for loop");
            for (int count = 0; count < 15; count++)
            {
                if (count < 8)
                {
                    continue;
                }
                WriteLine($"{count}");
            }
        }

        private static void ForEachStatementExample()
        {
            WriteLine("foreach loop example");
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            WriteLine("foreach on Array.");
            foreach (var vowel in vowels)
            {
                WriteLine($"{vowel}");
            }
            WriteLine();
            var persons = new List<Person>
            {
                new Author {Name = "Gaurav Aroraa"},
                new Reviewer {Name = "Shivprasad Koirala"},
                new TeamMember {Name = "Vikas Tiwari"},
                new TeamMember {Name = "Denim Pinto"}
            };
            WriteLine("foreach on collection");
            foreach (var person in persons)
            {
                WriteLine($"{person.Name}");
            }
        }

        private static void ForStatementExample()
        {
            WriteLine("for loop example.");
            Write("Enter repeatitive length:");
            int length = Convert.ToInt32(ReadLine());
            for (int countIndex = 0; countIndex < length; countIndex++)
            {
                WriteLine(new string('*', countIndex));
            }
        }

        private static void DoWhileStatementExample()
        {
            WriteLine("do...while example");
            Write("Enter repeatitive length:");
            int length = Convert.ToInt32(ReadLine());
            int count = 0;
            do
            {
                count++;
                WriteLine(new string('*',count));
                

            } while (count < length);
        }

        private static void WhileStatementExample()
        {
            WriteLine("while example");
            Write("Enter repeatitive length:");
            int length = Convert.ToInt32(ReadLine());
            int count = 0;
            while (count < length)
            {
                count++;
                WriteLine(new string('*', count));
            }

        }

        private static void SwitchCaseExample()
        {
            WriteLine("switch case statement example.");
            Write("Enter character:");
            char inputChar = Convert.ToChar(ReadLine());

            switch (char.ToLower(inputChar))
            {
                case 'a':
                    WriteLine($"Character {inputChar} is a vowel.");
                    break;
                case 'e':
                    WriteLine($"Character {inputChar} is a vowel.");
                    break;
                case 'i':
                    WriteLine($"Character {inputChar} is a vowel.");
                    break;
                case 'o':
                    WriteLine($"Character {inputChar} is a vowel.");
                    break;
                case 'u':
                    WriteLine($"Character {inputChar} is a vowel.");
                    break;
                default:
                    WriteLine($"Character '{inputChar}' is a consonant.");
                    break;
            }
        }

        private static void NestedIfStatementExample()
        {
            WriteLine("nested if statement example.");
            Write("Enter your age:");
            int age = Convert.ToInt32(ReadLine());

            if (age < 18)
            {
                WriteLine("Your age should be equal or greater than 18yrs.");
                if (age < 15)
                {
                    WriteLine("You need to complete your school first");
                }
            }
        }

        private static void IfElseIfElseStatementExample()
        {
            WriteLine("if else if else statement example.");
            Write("Enter character:");
            char inputChar = Convert.ToChar(ReadLine());

           if (char.ToLower(inputChar) == 'a')
            { WriteLine($"Character {inputChar} is a vowel.");}
            else if (char.ToLower(inputChar) == 'e')
            { WriteLine($"Character {inputChar} is a vowel.");}
            else if (char.ToLower(inputChar) == 'i')
            { WriteLine($"Character {inputChar} is a vowel.");}
            else if (char.ToLower(inputChar) == 'o')
            { WriteLine($"Character {inputChar} is a vowel.");}
           else  if (char.ToLower(inputChar) == 'u')
            { WriteLine($"Character {inputChar} is a vowel.");}
            else
            { WriteLine($"Character '{inputChar}' is a consonent.");}
        }
        private static void IfStatementExample()
        {
            WriteLine("if statement example.");
            Write("Enter character:");
            char inputChar = Convert.ToChar(ReadLine());

            //so many if statement, compiler go through all if statement
            //not recommended way
            if (char.ToLower(inputChar) == 'a')
                WriteLine($"Character {inputChar} is a vowel.");
            if (char.ToLower(inputChar) == 'e')
                WriteLine($"Character {inputChar} is a vowel.");
            if (char.ToLower(inputChar) == 'i')
                WriteLine($"Character {inputChar} is a vowel.");
            if (char.ToLower(inputChar) == 'o')
                WriteLine($"Character {inputChar} is a vowel.");
            if (char.ToLower(inputChar) == 'u')
                WriteLine($"Character {inputChar} is a vowel.");
        }
        private static void IfElseStatementExample()
        {
            WriteLine("if else statement example.");
            Write("Enter character:");
            char inputChar = Convert.ToChar(ReadLine());
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            
            if (vowels.Contains(char.ToLower(inputChar)))
                WriteLine($"Character '{inputChar}' is a vowel.");
            else
                WriteLine($"Character '{inputChar}' is a consonent.");
        }

        private static void StatementExample()
        {
            WriteLine("Statement example:");
            int singleLineStatement; //declarative statement
            WriteLine("'int singleLineStatement;' is a declarative statment.");
            singleLineStatement = 125; //assignment statement
            WriteLine("'singleLineStatement = 125;' is an assignmnet statement.");
            WriteLine($"{nameof(singleLineStatement)} = {singleLineStatement}");
            var persons = new List<Person>
            {
                new Author
                {
                    Name = "Gaurav Aroraa"
                }
            }; //declarative and assignmnet statement
            WriteLine("'var persons = new List<Person>();' is a declarative and assignmnet statement.");
            //block statement
            foreach (var person in persons)
            {
                WriteLine("'foreach (var person in persons){}' is a block statement.");
                WriteLine($"Name:{person.Name}");
            }
        }

        private static void ImplicitExplicitTypeConversionExample()
        {
            WriteLine("Implicit conversion");
            int numberInt = 2589;
            double doubleNumber = numberInt; // implicit type conversion

            WriteLine($"{nameof(numberInt)} of type:{numberInt.GetType().FullName} has value:{numberInt}");
            WriteLine($"{nameof(doubleNumber)} of type:{doubleNumber.GetType().FullName} implicitly type casted and has value:{doubleNumber}");

            WriteLine("Implicit conversion");
            doubleNumber = 2589.05D;
            numberInt = (int)doubleNumber; //explicit type conversion
            WriteLine($"{nameof(doubleNumber)} of type:{doubleNumber.GetType().FullName} has value:{doubleNumber}");
            WriteLine($"{nameof(numberInt)} of type:{numberInt.GetType().FullName} explicitly type casted and has value:{numberInt}");
            
        }

        private static void OperatorOverloadigExample()
        {
            WriteLine("Operator overloading example\n");
            Write("Enter x-axis of Surface1: ");
            var x1 =ReadLine();
            Write("Enter y-axis of Surface1: ");
            var y1 = ReadLine();
            Write("Enter x-axis of Surface2: ");
            var x2=ReadLine();
            Write("Enter y-axis of Surface2: ");
            var y2=ReadLine();

            var surface1 = new Coordinate(Convert.ToInt32(x1),Convert.ToInt32(y1));
            var surface2 = new Coordinate(Convert.ToInt32(x2),Convert.ToInt32(y2));
            WriteLine();
            Clear();
            WriteLine($"Surface1:{surface1}");
            WriteLine($"Area of Surface1:{surface1.Area()}");
            WriteLine($"Surface2:{surface2}");
            WriteLine($"Area of Surface2:{surface2.Area()}");
            WriteLine();
            WriteLine($"surface1 == surface2: {surface1==surface2}");
            WriteLine($"surface1 < surface2: {surface1 < surface2}");
            WriteLine($"surface1 > surface2: {surface1 > surface2}");
            WriteLine($"surface1 <= surface2: {surface1 <= surface2}");
            WriteLine($"surface1 >= surface2: {surface1 >= surface2}");
            WriteLine();
            var surface3 = surface1 + surface2;
            WriteLine($"Addition: {nameof(surface1)} + {nameof(surface2)} = {surface3}");
            WriteLine($"{nameof(surface3)}:{surface3}");
            WriteLine($"Area of {nameof(surface3)}: {surface3.Area()} ");
            WriteLine();
            WriteLine($"Substraction: {nameof(surface1)} - {nameof(surface2)} = {surface1-surface2}");
            WriteLine($"Multiplication: {nameof(surface1)} * {nameof(surface2)} = {surface1 * surface2}");
            WriteLine($"Division: {nameof(surface1)} / {nameof(surface2)} = {surface1 / surface2}");
            WriteLine($"Modulus: {nameof(surface1)} % {nameof(surface2)} = {surface1 % surface2}");
        }

        private static void OperatorExample()
        {
            WriteLine("Operators example\n");
            var csharpOperator = new CSharpOperator();
            Write("Enter first number:");
            csharpOperator.Num1 = Convert.ToInt32(ReadLine());
            Write("Enter second number:");
            csharpOperator.Num2 = Convert.ToInt32(ReadLine());
            Clear();
            csharpOperator.Display();

        }

        private static void BoxingUnboxingExample()
        {
            int thisIsvalueTypeVariable = 786;
            object thisIsObjectTypeVariable = thisIsvalueTypeVariable; //Boxing
            thisIsvalueTypeVariable += 1;
            WriteLine("Boxing");
            WriteLine($"Before boxing: Value of {nameof(thisIsvalueTypeVariable)}: {thisIsvalueTypeVariable}");
            WriteLine($"After boxing: Value of {nameof(thisIsObjectTypeVariable)}: {thisIsObjectTypeVariable}");

            thisIsObjectTypeVariable = 1900;
            thisIsvalueTypeVariable = (int) thisIsObjectTypeVariable; //Unboxing
            WriteLine("Unboxing");
            WriteLine($"Before Unboxing: Value of {nameof(thisIsObjectTypeVariable)}: {thisIsObjectTypeVariable}");
            WriteLine($"After Unboxing: Value of {nameof(thisIsvalueTypeVariable)}: {thisIsvalueTypeVariable}");
            
        }

        private static void DataTypeExample()
        {
           CSharpType.Display();
        }

        private static void DynamicTypeExample()
        {
            dynamic dynamicInt = 10;
            dynamic dynamicString = "This is a string";
            object obj = 10;
            WriteLine($"Run-time type of {nameof(dynamicInt)} is {dynamicInt.GetType()}");
            WriteLine($"Run-time type of {nameof(dynamicString)} is {dynamicString.GetType()}");
            WriteLine($"Run-time type of {nameof(obj)} is {obj.GetType()}");

        }

        private static void UsingExample()
        {
            //Console.WriteLine("This WriteLien is without using static directive");
            //WriteLine("This WriteLien is called after using static directive");

            using (var disposableClass = new DisposableClass())
            {
                WriteLine($"{disposableClass.GetMessage()}");
            }
        }

        private static void TypeofExample()
        {
            
            var thisIsADouble = 30.3D;
            WriteLine("using typeof()");
            WriteLine($"System.Type Object of {nameof(Program)} is {typeof(Program)}\n");
            var objProgram = new Program();
            WriteLine("using GetType()");
            WriteLine($"Sytem.Type Object of {nameof(objProgram)} is {objProgram.GetType()}");
            WriteLine($"Sytem.Type Object of {nameof(thisIsADouble)} is {thisIsADouble.GetType()}");
        }

        private static void SizeofExample()
        {
            WriteLine("Various inbuilt types have size as mentioned below:\n");
            WriteLine($"The size of data type int is: {sizeof(int)}");
            WriteLine($"The size of data type long is: {sizeof(long)}");
            WriteLine($"The size of data type double is: {sizeof(double)}");
            WriteLine($"The size of data type bool is: {sizeof(bool)}");
            WriteLine($"The size of data type short is: {sizeof(short)}");
            WriteLine($"The size of data type byte is: {sizeof(byte)}");
        }

        

        private static void CheckOverFlowExample()
        {
            const int maxValue = int.MaxValue;
            const int addSugar = 19;
            //int sumWillthrowError = 2147483647 + 19; //compile time error
            var sumWillNotThrowError = unchecked(maxValue + addSugar);
            //var sumWillNotThrowError = checked(maxValue + addSugar); //compile time error
            WriteLine(
                $"sum value:{sumWillNotThrowError} is not the correct value because it is larger than {maxValue}.");
        }

        private static void ExampleIsAsOperator()
        {
            WriteLine("Is As Operator");
            var author = new Author {Name = "Gaurav Aroraa"};
            var reviewer = new Reviewer {Name = "Shivprasad Koirala"};
            var team = new TeamMember {Name = "Vikas Tiwari"};
            var stackholder = new Stackholder();
            WriteLine("Author name using as:\n");
            stackholder.GetAuthorName(author);
            WriteLine("\nAuthor name using is:");
            stackholder.GetStackholdersname(author);
            WriteLine("Review name using is:");
            stackholder.GetStackholdersname(reviewer);
            WriteLine("Team member name using is:");
            stackholder.GetStackholdersname(team);
        }

        private static void ConsoleBeepExample()
        {
            for (var i = 0; i < 9; i++)
                Beep();
        }

        private static void ConsoleOperationExamples()
        {
            WriteLine("Console Color example\n");
            var colors = (ConsoleColor[]) Enum.GetValues(typeof(ConsoleColor));
            WriteLine("All available colors");
            (int background, int foreground) userInput;
            do
            {
                userInput = DisplayColorMenu(colors);
                if (userInput.foreground == colors.Length + 1 || userInput.background == colors.Length + 1)
                {
                    WriteLine("Rsetting to default...");
                    ResetColor();
                    Write("Press any ky to continue...");
                    ReadLine();
                    Clear();
                    userInput = DisplayColorMenu(colors);
                }
                else if (userInput.foreground < 0 || userInput.background < 0)
                {
                    WriteLine("-ve values are no allowed.");
                    Clear();
                    userInput = DisplayColorMenu(colors);
                }
                else if (userInput.background == colors.Length + 2 || userInput.foreground == colors.Length + 2)
                {
                }
                else
                {
                    BackgroundColor = colors[userInput.background];
                    ForegroundColor = colors[userInput.foreground];

                    WriteLine($"Foreground color is {ForegroundColor}");
                    WriteLine($"Background color is {BackgroundColor}");
                    WriteLine();

                    Write("Type anything to see the changes:");
                    ReadLine();
                }
            } while (userInput.background != colors.Length + 2 || userInput.foreground != colors.Length + 2);
        }

        private static (int, int) DisplayColorMenu(ConsoleColor[] colors)
        {
            var count = 0;

            foreach (var color in colors)
            {
                WriteLine($"{count} {color}");
                count += 1;
            }
            WriteLine($"{count + 1} Reset");
            WriteLine($"{count + 2} Exit");

            Write("Choose Foreground color:");
            var foreground = Convert.ToInt32(ReadLine());
            Write("Choose Background color:");
            var background = Convert.ToInt32(ReadLine());

            return new ValueTuple<int, int>(background, foreground);
        }

        private static void SameClassDifferentNamespacesExample()
        {
            var class1 = new ClassExample();
            var class2 = new Day02New.ClassExample();
            class1.Display();
            class2.Display();
        }
    }
}