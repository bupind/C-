using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication3 {
    class Program {
        static void ContinueProgram() {
            Console.Write("Apakah anda ingin menggunakan program lagi \nKetik YA atau TIDAK: \n (Hanya huruf BALOK) ");
            string continueProgram = Console.ReadLine();
            if (continueProgram == "YA") {
                Main();
            }
            else {
                Console.WriteLine("Semangat broh ^_^");
            }
        }
        static void DecimalToBinary(int decimalNum) {
            Console.Write(decimalNum);
            string binary = "";
            while (decimalNum > 0) {
                binary += decimalNum % 2;
                decimalNum /= 2;
            }
            char[] binaryResult = binary.ToCharArray();
            Array.Reverse(binaryResult);
            Console.WriteLine(new string(binaryResult));
            ContinueProgram();
        }
        static void DecimalToHexa(int hexaNum) {
            Console.Write(hexaNum);
            string hexa = "";
            while (hexaNum > 0) {
                switch (hexaNum % 16) {
                    case 0: hexa += "0"; break;
                    case 1: hexa += "1"; break;
                    case 2: hexa += "2"; break;
                    case 3: hexa += "3"; break;
                    case 4: hexa += "4"; break;
                    case 5: hexa += "5"; break;
                    case 6: hexa += "6"; break;
                    case 7: hexa += "7"; break;
                    case 8: hexa += "8"; break;
                    case 9: hexa += "9"; break;
                    case 10: hexa += "A"; break;
                    case 11: hexa += "B"; break;
                    case 12: hexa += "C"; break;
                    case 13: hexa += "D"; break;
                    case 14: hexa += "E"; break;
                    case 15: hexa += "F"; break;
                }
                hexaNum /= 16;
            }
            char[] hexaResult = hexa.ToCharArray();
            Array.Reverse(hexaResult);
            Console.WriteLine(new string(hexaResult));
            ContinueProgram();
        }
        static void BinaryToDec(string binaryNum) {
            Console.Write(binaryNum + "(2) = ");
            char[] binary = binaryNum.ToCharArray();
            Array.Reverse(binary);
            short power = 0;
            double decimalNum = 0;
            int steps = binary.Length;
            int val = 0;
            for (int i = 0; i < steps; i++) {
                val = (int)Char.GetNumericValue(binary[i]);
                decimalNum += val * Math.Pow(2, power);
                power++;
            }
            Console.WriteLine(decimalNum);
            ContinueProgram();
        }
        static void BinaryToHexa(string binaryNum) {
            Console.Write(binaryNum);
            if (binaryNum.Length % 4 > 0) {
                int leadingZeroes = binaryNum.Length % 4;
                binaryNum = new string('0', 4 - leadingZeroes) + binaryNum;
            }
            int hexaDigits = binaryNum.Length / 4;
            string hexaNumber = "";
            string substringBin = "";
            int startDigit = 0;
            for (int i = 0; i < hexaDigits; i++) {
                substringBin = binaryNum.Substring(startDigit, 4);
                switch (substringBin) {
                    case "0000": hexaNumber += "0"; break;
                    case "0001": hexaNumber += "1"; break;
                    case "0010": hexaNumber += "2"; break;
                    case "0011": hexaNumber += "3"; break;
                    case "0100": hexaNumber += "4"; break;
                    case "0101": hexaNumber += "5"; break;
                    case "0110": hexaNumber += "6"; break;
                    case "0111": hexaNumber += "7"; break;
                    case "1000": hexaNumber += "8"; break;
                    case "1001": hexaNumber += "9"; break;
                    case "1010": hexaNumber += "A"; break;
                    case "1011": hexaNumber += "B"; break;
                    case "1100": hexaNumber += "C"; break;
                    case "1101": hexaNumber += "D"; break;
                    case "1110": hexaNumber += "E"; break;
                    case "1111": hexaNumber += "F"; break;
                }
                startDigit += 4;
            }
            Console.WriteLine(hexaNumber);
            ContinueProgram();
        }
        static void HexaToDecimal(string hexaNum) {
            Console.Write(hexaNum);
            char[] hexa = hexaNum.ToCharArray();
            Array.Reverse(hexa);
            double decResult = 0;
            int power = 0;
            for (int i = 0; i < hexa.Length; i++) {
                switch (hexa[i]) {
                    case '0': decResult += 0 * Math.Pow(16, power); break;
                    case '1': decResult += 1 * Math.Pow(16, power); break;
                    case '2': decResult += 2 * Math.Pow(16, power); break;
                    case '3': decResult += 3 * Math.Pow(16, power); break;
                    case '4': decResult += 4 * Math.Pow(16, power); break;
                    case '5': decResult += 5 * Math.Pow(16, power); break;
                    case '6': decResult += 6 * Math.Pow(16, power); break;
                    case '7': decResult += 7 * Math.Pow(16, power); break;
                    case '8': decResult += 8 * Math.Pow(16, power); break;
                    case '9': decResult += 9 * Math.Pow(16, power); break;
                    case 'A': decResult += 10 * Math.Pow(16, power); break;
                    case 'B': decResult += 11 * Math.Pow(16, power); break;
                    case 'C': decResult += 12 * Math.Pow(16, power); break;
                    case 'D': decResult += 13 * Math.Pow(16, power); break;
                    case 'E': decResult += 14 * Math.Pow(16, power); break;
                    case 'F': decResult += 15 * Math.Pow(16, power); break;
                }
                power++;
            }
            Console.WriteLine(decResult);
            ContinueProgram();
        }
        static void HexaToBinary(string hexaNum) {
            Console.Write(hexaNum);
            char[] hexa = hexaNum.ToCharArray();
            string binaryNum = "";
            for (int i = 0; i < hexaNum.Length; i++) {
                switch (hexaNum[i]) {
                    case '0': binaryNum += "0000"; break;
                    case '1': binaryNum += "0001"; break;
                    case '2': binaryNum += "0010"; break;
                    case '3': binaryNum += "0011"; break;
                    case '4': binaryNum += "0100"; break;
                    case '5': binaryNum += "0101"; break;
                    case '6': binaryNum += "0110"; break;
                    case '7': binaryNum += "0111"; break;
                    case '8': binaryNum += "1000"; break;
                    case '9': binaryNum += "1001"; break;
                    case 'A': binaryNum += "1010"; break;
                    case 'B': binaryNum += "1011"; break;
                    case 'C': binaryNum += "1100"; break;
                    case 'D': binaryNum += "1101"; break;
                    case 'E': binaryNum += "1110"; break;
                    case 'F': binaryNum += "1111"; break;
                }
            }
            Console.WriteLine(binaryNum);
            ContinueProgram();
        }
        static void CustomSystems(int baseCustomSystem, int targetCustomSystem) {
            Console.Write("Enter number in system ({0}): ", baseCustomSystem);
            string baseNumber = Console.ReadLine();
            Console.Write(baseNumber + "({0}) = ", baseCustomSystem);
            char[] baseNumberArray = baseNumber.ToCharArray();
            Array.Reverse(baseNumberArray);
            short power = 0;
            int decVal = 0;
            for (int i = 0; i < baseNumberArray.Length; i++) {
                switch (baseNumberArray[i]) {
                    case '0': decVal += 0 * (int)Math.Pow(baseCustomSystem, power); break;
                    case '1': decVal += 1 * (int)Math.Pow(baseCustomSystem, power); break;
                    case '2': decVal += 2 * (int)Math.Pow(baseCustomSystem, power); break;
                    case '3': decVal += 3 * (int)Math.Pow(baseCustomSystem, power); break;
                    case '4': decVal += 4 * (int)Math.Pow(baseCustomSystem, power); break;
                    case '5': decVal += 5 * (int)Math.Pow(baseCustomSystem, power); break;
                    case '6': decVal += 6 * (int)Math.Pow(baseCustomSystem, power); break;
                    case '7': decVal += 7 * (int)Math.Pow(baseCustomSystem, power); break;
                    case '8': decVal += 8 * (int)Math.Pow(baseCustomSystem, power); break;
                    case '9': decVal += 9 * (int)Math.Pow(baseCustomSystem, power); break;
                    case 'A': decVal += 10 * (int)Math.Pow(baseCustomSystem, power); break;
                    case 'B': decVal += 11 * (int)Math.Pow(baseCustomSystem, power); break;
                    case 'C': decVal += 12 * (int)Math.Pow(baseCustomSystem, power); break;
                    case 'D': decVal += 13 * (int)Math.Pow(baseCustomSystem, power); break;
                    case 'E': decVal += 14 * (int)Math.Pow(baseCustomSystem, power); break;
                    case 'F': decVal += 15 * (int)Math.Pow(baseCustomSystem, power); break;
                }
                power++;
            } 
            if (targetCustomSystem == 10) {
                Console.WriteLine(decVal);
            }
            else if (targetCustomSystem < 10) {
                string lowerClass = "";
                while (decVal > 0) {
                    lowerClass += decVal % targetCustomSystem;
                    decVal /= targetCustomSystem;
                }
                char[] lowerClassResult = lowerClass.ToCharArray();
                Array.Reverse(lowerClassResult);

                Console.WriteLine(String.Join("", lowerClassResult) + "({0})", targetCustomSystem);
            }
            else if (targetCustomSystem > 10) {
                string upperClass = "";
                while (decVal > 0) {
                    switch (decVal % targetCustomSystem) {
                        case 0: upperClass += "0"; break;
                        case 1: upperClass += "1"; break;
                        case 2: upperClass += "2"; break;
                        case 3: upperClass += "3"; break;
                        case 4: upperClass += "4"; break;
                        case 5: upperClass += "5"; break;
                        case 6: upperClass += "6"; break;
                        case 7: upperClass += "7"; break;
                        case 8: upperClass += "8"; break;
                        case 9: upperClass += "9"; break;
                        case 10: upperClass += "A"; break;
                        case 11: upperClass += "B"; break;
                        case 12: upperClass += "C"; break;
                        case 13: upperClass += "D"; break;
                        case 14: upperClass += "E"; break;
                        case 15: upperClass += "F"; break;
                    }

                    decVal /= targetCustomSystem;
                }
                char[] upperClassResult = upperClass.ToCharArray();
                Array.Reverse(upperClassResult);
                Console.WriteLine(String.Join("", upperClassResult) + "({0})", targetCustomSystem);
            }
            ContinueProgram();
        }
        static void Main() {
            Console.WriteLine("Ketik SO untuk mengidentifikasikan bahwa anda bukan ROBOT :D.\n*Hanya huruf BALOK");
            string begin = Console.ReadLine();
            if (begin == "SO") {
                Console.WriteLine("Convert dari (Hanya Angka) \nPilihan: \n 1. BINARY\n 2. DECIMAL\n 3. HEXADECIMAL.");
                string sourceCommand = Console.ReadLine();
                Console.WriteLine("Tujuan Convert (Hanya Angka). \nPilihan: \n 1. BINARY\n 2. DECIMAL \n 3. HEXADECIMAL.");
                string targetCommand = Console.ReadLine();
                if (sourceCommand == targetCommand) {
                    Console.WriteLine("Please, coba lagi");
                    Main();
                }
                if (sourceCommand == "2") {
                    Console.Write("Tulis angka Decimal: ");
                    int decimalNum = int.Parse(Console.ReadLine());

                    if (targetCommand == "1")
                    {
                        DecimalToBinary(decimalNum);
                    }

                    if (targetCommand == "3")
                    {
                        DecimalToHexa(decimalNum);
                    }
                }

                if (sourceCommand == "1")
                {
                    Console.Write("Tulis angka binary: ");
                    string binaryNum = Console.ReadLine();

                    if (targetCommand == "2")
                    {
                        BinaryToDec(binaryNum);
                    }

                    if (targetCommand == "3")
                    {
                        BinaryToHexa(binaryNum);
                    }
                }

                if (sourceCommand == "3")
                {
                    Console.Write("Tulis angka hexadecimal: ");
                    string hexaNum = Console.ReadLine();

                    if (targetCommand == "1")
                    {
                        HexaToBinary(hexaNum);
                    }

                    if (targetCommand == "2")
                    {
                        HexaToDecimal(hexaNum);
                    }
                }
            }

            else if (begin == "4")
            {
                Console.WriteLine("Masih dalam tahap Pengembangan bro...");
            }

            else
            {
                Main();
            }
        }
    }
}