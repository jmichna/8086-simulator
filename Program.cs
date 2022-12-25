using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace _8086_simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcja1;
            Deklaacja16bit XX = new Deklaacja16bit();
            Console.WriteLine("Witamy w Emulatorze procesora Intel 8086!");
        Powrot:
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Proszę wybrać jedną z opcji poniżej");
            Console.WriteLine("1. Pokaż rejestry");
            Console.WriteLine("2. SET");
            Console.WriteLine("3. MOVE");
            Console.WriteLine("4. Operacje Arytmetyczne");
            Console.WriteLine("5. Czyszczenie!");
            opcja1 = Console.ReadLine();
            if (opcja1 != null)
            {
                if (opcja1 == "1")
                {
                    try
                    {
                        XX.get();
                        Thread.Sleep(5000);
                        Console.WriteLine("Proszę nacisnąć cokolwiek aby powrócić do menu głównego...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    catch
                    {
                        XX.clear();
                        Console.WriteLine("Błąd! Dla bezpieczeństwa wszystie rejestry zostają wyczyszczone!");
                    }
                    goto Powrot;
                }
                else if (opcja1 == "2")
                {
                    try
                    {
                        XX.set();
                        Console.Clear();
                    }
                    catch
                    {
                        XX.clear();
                        Console.WriteLine("Błąd! Dla bezpieczeństwa wszystie rejestry zostają wyczyszczone!");
                    }
                    goto Powrot;

                }
                else if (opcja1 == "3")
                {
                    try
                    {
                        XX.move();
                        Console.Clear();
                    }
                    catch
                    {
                        XX.clear();
                        Console.WriteLine("Błąd! Dla bezpieczeństwa wszystie rejestry zostają wyczyszczone!");
                    }
                    goto Powrot;
                }
                else if (opcja1 == "4")
                {
                    try
                    {
                        XX.operacjear();
                        Thread.Sleep(5000);
                        Console.Clear();
                    }
                    catch
                    {
                        XX.clear();
                        Console.WriteLine("Błąd! Dla bezpieczeństwa wszystie rejestry zostają wyczyszczone!");
                    }
                    goto Powrot;
                }
                else if (opcja1 == "5")
                {
                    XX.clear();
                    Console.WriteLine("Tabele zeostały wyczyszczone!");
                    Thread.Sleep(5000);
                    Console.Clear();
                    goto Powrot;
                }
                else
                {
                    Console.WriteLine("Błąd! Proszę wybrać komendę ponownie!");
                    Thread.Sleep(2500);
                    Console.Clear();
                    goto Powrot;
                }
            }
            else
            {
                Console.WriteLine("Nie wybrano komendy!");
                goto Powrot;
            }


        }
    }

    public class Deklaacja16bit
    {
        string HexA;
        string HexB;
        string HexC;
        string HexD;
        int AX;
        int BX;
        int CX;
        int DX;
        string HexAH;
        string HexBH;
        string HexCH;
        string HexDH;
        string HexAL;
        string HexBL;
        string HexCL;
        string HexDL;
        int AH;
        int BH;
        int CH;
        int DH;
        int AL;
        int BL;
        int CL;
        int DL;

        public void clear()
        {
            HexA = null;
            HexB = null;
            HexC = null;
            HexD = null;
            HexAH = null;
            HexBH = null;
            HexCH = null;
            HexDH = null;
            HexAL = null;
            HexBL = null;
            HexCL = null;
            HexDL = null;
            AX = 0;
            BX = 0;
            CX = 0;
            DX = 0;
            AH = 0;
            BH = 0;
            CH = 0;
            DH = 0;
            AL = 0;
            BL = 0;
            CL = 0;
            DL = 0;

        }

        public void set()
        {
            string set;
        Wroc:
            Console.WriteLine("1. SET 16BIT");
            Console.WriteLine("2. SET 8BIT");
            set = Console.ReadLine();

            if (set != null)
            {
                if (set == "1")
                {
                Wroc1:
                    Console.WriteLine("Proszę wybrać rejestr któremu chcesz ustawić wartość:");
                    Console.WriteLine("1. AX");
                    Console.WriteLine("2. BX");
                    Console.WriteLine("3. CX");
                    Console.WriteLine("4. DX");
                    string rejestr = Console.ReadLine();
                    if (rejestr != null)
                    {
                        if (rejestr == "1")
                        {
                            Console.WriteLine("Proszę podać liczbę w systemie szenstastkowym!");
                            HexA = Console.ReadLine();
                            if (HexA.Length <= 4)
                            {
                                AX = int.Parse(HexA, System.Globalization.NumberStyles.HexNumber);
                            }
                            else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 4 znaki!"); goto Wroc; }
                        }
                        else if (rejestr == "2")
                        {
                            Console.WriteLine("Proszę podać liczbę w systemie szenstastkowym!");
                            HexB = Console.ReadLine();
                            if (HexB.Length <= 4)
                            {
                                BX = int.Parse(HexB, System.Globalization.NumberStyles.HexNumber);
                            }
                            else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 4 znaki!"); goto Wroc; }
                        }
                        else if (rejestr == "3")
                        {
                            Console.WriteLine("Proszę podać liczbę w systemie szenstastkowym!");
                            HexC = Console.ReadLine();
                            if (HexC.Length <= 4)
                            {
                                CX = int.Parse(HexC, System.Globalization.NumberStyles.HexNumber);
                            }
                            else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 4 znaki!"); goto Wroc; }
                        }
                        else if (rejestr == "4")
                        {
                            Console.WriteLine("Proszę podać liczbę w systemie szenstastkowym!");
                            HexD = Console.ReadLine();
                            if (HexD.Length <= 4)
                            {
                                DX = int.Parse(HexD, System.Globalization.NumberStyles.HexNumber);
                            }
                            else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 4 znaki!"); goto Wroc; }
                        }
                        else
                        {
                            Console.WriteLine("Błąd! Proszę wpisać komendę ponownie!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nie wpisano żadnej wartości!");
                        goto Wroc1;
                    }
                }
                else if (set == "2")
                {
                    string opcja4;
                Wroc2:
                    Console.WriteLine("Prosze wybrać resjestr któremu chcesz ustawić wartość:");
                    Console.WriteLine("1. AH");
                    Console.WriteLine("2. BH");
                    Console.WriteLine("3. CH");
                    Console.WriteLine("4. DH");
                    Console.WriteLine("5. AL");
                    Console.WriteLine("6. BL");
                    Console.WriteLine("7. CL");
                    Console.WriteLine("8. DL");
                    opcja4 = Console.ReadLine();
                    if (opcja4 != null)
                    {
                        if (opcja4.Length <= 2)
                        {
                            if (opcja4 == "1")
                            {
                                    Console.WriteLine("Proszę podać liczbę w systemie szesnastkowym!");
                                    HexAH = Console.ReadLine();
                                if (HexAH.Length <= 2)
                                {
                                    AH = int.Parse(HexAH, System.Globalization.NumberStyles.HexNumber);
                                }
                                else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 2 znaki!"); goto Wroc2; }
                            }
                            else if (opcja4 == "2")
                            {
                                    Console.WriteLine("Proszę podać liczbę w systemie szesnastkowym!");
                                    HexBH = Console.ReadLine();
                                if (HexBH.Length <= 2)
                                {
                                    BH = int.Parse(HexBH, System.Globalization.NumberStyles.HexNumber);
                                }
                                else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 2 znaki!"); goto Wroc2; }
                            }
                            else if (opcja4 == "3")
                            {
                                    Console.WriteLine("Proszę podać liczbę w systemie szesnastkowym!");
                                    HexCH = Console.ReadLine();
                                if (HexCH.Length <= 2)
                                {
                                    CH = int.Parse(HexCH, System.Globalization.NumberStyles.HexNumber);
                                }
                                else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 2 znaki!"); goto Wroc2; }
                            }
                            else if (opcja4 == "4")
                            {
                                    Console.WriteLine("Proszę podać liczbę w systemie szesnastkowym!");
                                    HexDH = Console.ReadLine();
                                if (HexDH.Length <= 2)
                                {
                                    DH = int.Parse(HexDH, System.Globalization.NumberStyles.HexNumber);
                                }
                                else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 2 znaki!"); goto Wroc2; }
                            }
                            else if (opcja4 == "5")
                            {
                                    Console.WriteLine("Proszę podać liczbę w systemie szesnastkowym!");
                                    HexAL = Console.ReadLine();
                                if (HexAL.Length <= 2)
                                {
                                    AL = int.Parse(HexAL, System.Globalization.NumberStyles.HexNumber);
                                }
                                else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 2 znaki!"); goto Wroc2; }
                            }
                            else if (opcja4 == "6")
                            {
                                    Console.WriteLine("Proszę podać liczbę w systemie szesnastkowym!");
                                    HexBL = Console.ReadLine();
                                if (HexBL.Length <= 2)
                                {
                                    BL = int.Parse(HexBL, System.Globalization.NumberStyles.HexNumber);
                                }
                                else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 2 znaki!"); goto Wroc2; }
                            }
                            else if (opcja4 == "7")
                            {
                                    Console.WriteLine("Proszę podać liczbę w systemie szesnastkowym!");
                                    HexCL = Console.ReadLine();
                                if (HexCL.Length <= 2)
                                {
                                    CL = int.Parse(HexCL, System.Globalization.NumberStyles.HexNumber);
                                }
                                else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 2 znaki!"); goto Wroc2; }
                            }
                            else if (opcja4 == "8")
                            {
                                    Console.WriteLine("Proszę podać liczbę w systemie szesnastkowym!");
                                    HexDL = Console.ReadLine();
                                if (HexDL.Length <= 2)
                                {
                                    DL = int.Parse(HexDL, System.Globalization.NumberStyles.HexNumber);
                                }
                                else { Console.WriteLine("Wartość jest za długa! Proszę podać maksymalnie 2 znaki!"); goto Wroc2; }

                            }
                            else
                            {
                                Console.WriteLine("Błąd! Proszę wybrać rejestr jeszcze raz!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wartośc za długa!");
                            goto Wroc2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nie wybrano komendy!");
                        goto Wroc2;
                    }

                }
                else
                {
                    Console.WriteLine("Błąd! Proszę podać wartość ponownie!");
                    goto Wroc;
                }
            }
            else
            {
                Console.WriteLine("Proszę wybrać komendę!");
                goto Wroc;
            }




        }
        public void get()
        {
            string opcja2;
            string opcja3;
            string opcja5;
            Wroc3:
            Console.WriteLine("1.GET 16 BIT");
            Console.WriteLine("2.GET 8 BIT");
            opcja2 = Console.ReadLine();
            if (opcja2 != null)
            {
                if (opcja2 == "1")
                {
                    Console.WriteLine("AX, DEC" + AX + ", HEX " + HexA);
                    Console.WriteLine("BX, DEC" + BX + ", HEX " + HexB);
                    Console.WriteLine("CX, DEC" + CX + ", HEX " + HexC);
                    Console.WriteLine("DX, DEC" + DX + ", HEX " + HexD);
                }
                else if (opcja2 == "2")
                {
                    Console.WriteLine("AL, DEC" + AL + ", HEX " + HexAL);
                    Console.WriteLine("BL, DEC" + BL + ", HEX " + HexBL);
                    Console.WriteLine("CL, DEC" + CL + ", HEX " + HexCL);
                    Console.WriteLine("DL, DEC" + DL + ", HEX " + HexDL);
                    Console.WriteLine("AH, DEC" + AH + ", HEX " + HexAH);
                    Console.WriteLine("BH, DEC" + BH + ", HEX " + HexBH);
                    Console.WriteLine("CH, DEC" + CH + ", HEX " + HexCH);
                    Console.WriteLine("DH, DEC" + DH + ", HEX " + HexDH);
                }
                else
                {
                    Console.WriteLine("Błąd! Proszę wybrać wartośc ponownie!");
                }
            }
            else
            {
                Console.WriteLine("Nie wybrano żadnej opcji!");
                goto Wroc3;
            }
            
        }

        public void move()
        {
            string opcja6;
            string opcja7;
            string opcja8;
            string move1;
            string move2;
        Powrot1:
            Console.WriteLine("1. MOVE 16BIT");
            Console.WriteLine("2. MOVE 8BIT");
            opcja6 = Console.ReadLine();

            if (opcja6 != null)
            {
                if (opcja6 == "1")
                {
                    Console.WriteLine("Proszę wybrac rejestr!");
                    Console.WriteLine("1. AX");
                    Console.WriteLine("2. BX");
                    Console.WriteLine("3. CX");
                    Console.WriteLine("4. DX");
                    opcja7 = Console.ReadLine();
                    if (opcja7 != null)
                    {
                        if (opcja7 == "1")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. BX");
                            Console.WriteLine("2. CX");
                            Console.WriteLine("3. DX");
                            move1 = Console.ReadLine();
                            if (move1 != null)
                            {
                                if (move1 == "1")
                                {
                                    BX = AX;
                                    Console.WriteLine("Przeniesiono wartość z AX do BX!");
                                }
                                else if (move1 == "2")
                                {
                                    CX = AX;
                                    Console.WriteLine("Przeniesiono wartość z AX do CX!");
                                }
                                else if (move1 == "3")
                                {
                                    DX = AX;
                                    Console.WriteLine("Przeniesiono wartość z AX do DX!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }

                        }
                        else if (opcja7 == "2")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. AX");
                            Console.WriteLine("2. CX");
                            Console.WriteLine("3. DX");
                            move1 = Console.ReadLine();
                            if (move1 != null)
                            {
                                if (move1 == "1")
                                {
                                    AX = BX;
                                    Console.WriteLine("Przeniesiono wartość z BX do AX!");
                                }
                                else if (move1 == "2")
                                {
                                    CX = BX;
                                    Console.WriteLine("Przeniesiono wartość z BX do CX!");
                                }
                                else if (move1 == "3")
                                {
                                    DX = BX;
                                    Console.WriteLine("Przeniesiono wartość z BX do DX!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }
                        }
                        else if (opcja7 == "3")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. AX");
                            Console.WriteLine("2. BX");
                            Console.WriteLine("3. DX");
                            move1 = Console.ReadLine();
                            if (move1 != null)
                            {
                                if (move1 == "1")
                                {
                                    AX = CX;
                                    Console.WriteLine("Przeniesiono wartość z CX do AX!");
                                }
                                else if (move1 == "2")
                                {
                                    BX = CX;
                                    Console.WriteLine("Przeniesiono wartość z CX do BX!");
                                }
                                else if (move1 == "3")
                                {
                                    DX = CX;
                                    Console.WriteLine("Przeniesiono wartość z CX do DX!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }
                        }
                        else if (opcja7 == "4")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. AX");
                            Console.WriteLine("2. BX");
                            Console.WriteLine("3. CX");
                            move1 = Console.ReadLine();
                            if (move1 != null)
                            {
                                if (move1 == "1")
                                {
                                    AX = DX;
                                    Console.WriteLine("Przeniesiono wartość z DX do AX!");
                                }
                                else if (move1 == "2")
                                {
                                    BX = DX;
                                    Console.WriteLine("Przeniesiono wartość z DX do BX!");
                                }
                                else if (move1 == "3")
                                {
                                    CX = DX;
                                    Console.WriteLine("Przeniesiono wartość z DX do CX!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Błąd! Proszę wybrać rejestr ponownie!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nie wybrano żadnej wartości!");
                    }
                }
                else if (opcja6 == "2")
                {
                    Console.WriteLine("Proszę wybrać rejest z którego chcesz przenieść wartość!");
                    Console.WriteLine("1. AH");
                    Console.WriteLine("2. BH");
                    Console.WriteLine("3. CH");
                    Console.WriteLine("4. DH");
                    Console.WriteLine("5. AL");
                    Console.WriteLine("6. BL");
                    Console.WriteLine("7. CL");
                    Console.WriteLine("8. DL");
                    opcja8 = Console.ReadLine();
                    if (opcja8 != null)
                    {
                        if (opcja8 == "1")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. BH");
                            Console.WriteLine("2. CH");
                            Console.WriteLine("3. DH");
                            Console.WriteLine("4. AL");
                            Console.WriteLine("5. BL");
                            Console.WriteLine("6. CL");
                            Console.WriteLine("7. DL");
                            move2 = Console.ReadLine();
                            if (move2 != null)
                            {
                                if (move2 == "1")
                                {
                                    BH = AH;
                                    Console.WriteLine("Przeniesiono wartość z AH do BH");
                                }
                                else if (move2 == "2")
                                {
                                    CH = AH;
                                    Console.WriteLine("Przeniesiono wartość z AH do CH");
                                }
                                else if (move2 == "3")
                                {
                                    DH = AH;
                                    Console.WriteLine("Przeniesiono wartość z AH do DH");
                                }
                                else if (move2 == "4")
                                {
                                    AL = AH;
                                    Console.WriteLine("Przeniesiono wartość z AH do AL");
                                }
                                else if (move2 == "5")
                                {
                                    BL = AH;
                                    Console.WriteLine("Przeniesiono wartość z AH do BL");
                                }
                                else if (move2 == "6")
                                {
                                    CL = AH;
                                    Console.WriteLine("Przeniesiono wartość z AH do CL");
                                }
                                else if (move2 == "7")
                                {
                                    DL = AH;
                                    Console.WriteLine("Przeniesiono wartość z AH do DL");
                                }
                                else
                                {
                                    Console.WriteLine("Błąd! Proszę wybrać ponownie wartość!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }
                        }
                        else if (opcja8 == "2")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. AH");
                            Console.WriteLine("2. CH");
                            Console.WriteLine("3. DH");
                            Console.WriteLine("4. AL");
                            Console.WriteLine("5. BL");
                            Console.WriteLine("6. CL");
                            Console.WriteLine("7. DL");
                            move2 = Console.ReadLine();
                            if (move2 != null)
                            {
                                if (move2 == "1")
                                {
                                    AH = BH;
                                    Console.WriteLine("Przeniesiono wartość z BH do AH");
                                }
                                else if (move2 == "2")
                                {
                                    CH = BH;
                                    Console.WriteLine("Przeniesiono wartość z BH do CH");
                                }
                                else if (move2 == "3")
                                {
                                    DH = BH;
                                    Console.WriteLine("Przeniesiono wartość z BH do DH");
                                }
                                else if (move2 == "4")
                                {
                                    AL = BH;
                                    Console.WriteLine("Przeniesiono wartość z BH do AL");
                                }
                                else if (move2 == "5")
                                {
                                    BL = BH;
                                    Console.WriteLine("Przeniesiono wartość z BH do BL");
                                }
                                else if (move2 == "6")
                                {
                                    CL = BH;
                                    Console.WriteLine("Przeniesiono wartość z BH do CL");
                                }
                                else if (move2 == "7")
                                {
                                    DL = BH;
                                    Console.WriteLine("Przeniesiono wartość z BH do DL");
                                }
                                else
                                {
                                    Console.WriteLine("Błąd! Proszę wybrać ponownie wartość!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }
                        }
                        else if (opcja8 == "3")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. AH");
                            Console.WriteLine("2. BH");
                            Console.WriteLine("3. DH");
                            Console.WriteLine("4. AL");
                            Console.WriteLine("5. BL");
                            Console.WriteLine("6. CL");
                            Console.WriteLine("7. DL");
                            move2 = Console.ReadLine();
                            if (move2 != null)
                            {
                                if (move2 == "1")
                                {
                                    AH = CH;
                                    Console.WriteLine("Przeniesiono wartość z CH do AH");
                                }
                                else if (move2 == "2")
                                {
                                    BH = CH;
                                    Console.WriteLine("Przeniesiono wartość z CH do BH");
                                }
                                else if (move2 == "3")
                                {
                                    DH = CH;
                                    Console.WriteLine("Przeniesiono wartość z CH do DH");
                                }
                                else if (move2 == "4")
                                {
                                    AL = CH;
                                    Console.WriteLine("Przeniesiono wartość z CH do AL");
                                }
                                else if (move2 == "5")
                                {
                                    BL = CH;
                                    Console.WriteLine("Przeniesiono wartość z CH do BL");
                                }
                                else if (move2 == "6")
                                {
                                    CL = CH;
                                    Console.WriteLine("Przeniesiono wartość z CH do CL");
                                }
                                else if (move2 == "7")
                                {
                                    DL = CH;
                                    Console.WriteLine("Przeniesiono wartość z CH do DL");
                                }
                                else
                                {
                                    Console.WriteLine("Błąd! Proszę wybrać ponownie wartość!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }
                        }
                        else if (opcja8 == "4")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. AH");
                            Console.WriteLine("2. BH");
                            Console.WriteLine("3. CH");
                            Console.WriteLine("4. AL");
                            Console.WriteLine("5. BL");
                            Console.WriteLine("6. CL");
                            Console.WriteLine("7. DL");
                            move2 = Console.ReadLine();
                            if (move2 != null)
                            {
                                if (move2 == "1")
                                {
                                    AH = DH;
                                    Console.WriteLine("Przeniesiono wartość z DH do AH");
                                }
                                else if (move2 == "2")
                                {
                                    BH = DH;
                                    Console.WriteLine("Przeniesiono wartość z DH do BH");
                                }
                                else if (move2 == "3")
                                {
                                    CH = DH;
                                    Console.WriteLine("Przeniesiono wartość z DH do CH");
                                }
                                else if (move2 == "4")
                                {
                                    AL = DH;
                                    Console.WriteLine("Przeniesiono wartość z DH do AL");
                                }
                                else if (move2 == "5")
                                {
                                    BL = DH;
                                    Console.WriteLine("Przeniesiono wartość z DH do BL");
                                }
                                else if (move2 == "6")
                                {
                                    CL = DH;
                                    Console.WriteLine("Przeniesiono wartość z DH do CL");
                                }
                                else if (move2 == "7")
                                {
                                    DL = DH;
                                    Console.WriteLine("Przeniesiono wartość z DH do DL");
                                }
                                else
                                {
                                    Console.WriteLine("Błąd! Proszę wybrać ponownie wartość!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }
                        }
                        else if (opcja8 == "5")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. AH");
                            Console.WriteLine("2. BH");
                            Console.WriteLine("3. CH");
                            Console.WriteLine("4. DH");
                            Console.WriteLine("5. BL");
                            Console.WriteLine("6. CL");
                            Console.WriteLine("7. DL");
                            move2 = Console.ReadLine();
                            if (move2 != null)
                            {
                                if (move2 == "1")
                                {
                                    AH = AL;
                                    Console.WriteLine("Przeniesiono wartość z AL do AH");
                                }
                                else if (move2 == "2")
                                {
                                    BH = AL;
                                    Console.WriteLine("Przeniesiono wartość z AL do BH");
                                }
                                else if (move2 == "3")
                                {
                                    CH = AL;
                                    Console.WriteLine("Przeniesiono wartość z AL do CH");
                                }
                                else if (move2 == "4")
                                {
                                    DH = AL;
                                    Console.WriteLine("Przeniesiono wartość z AL do DH");
                                }
                                else if (move2 == "5")
                                {
                                    BL = AL;
                                    Console.WriteLine("Przeniesiono wartość z AL do BL");
                                }
                                else if (move2 == "6")
                                {
                                    CL = AL;
                                    Console.WriteLine("Przeniesiono wartość z AL do CL");
                                }
                                else if (move2 == "7")
                                {
                                    DL = AL;
                                    Console.WriteLine("Przeniesiono wartość z AL do DL");
                                }
                                else
                                {
                                    Console.WriteLine("Błąd! Proszę wybrać ponownie wartość!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }
                        }
                        else if (opcja8 == "6")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. AH");
                            Console.WriteLine("2. BH");
                            Console.WriteLine("3. CH");
                            Console.WriteLine("4. DH");
                            Console.WriteLine("5. AL");
                            Console.WriteLine("6. CL");
                            Console.WriteLine("7. DL");
                            move2 = Console.ReadLine();
                            if (move2 != null)
                            {
                                if (move2 == "1")
                                {
                                    AH = BL;
                                    Console.WriteLine("Przeniesiono wartość z BL do AH");
                                }
                                else if (move2 == "2")
                                {
                                    BH = BL;
                                    Console.WriteLine("Przeniesiono wartość z BL do BH");
                                }
                                else if (move2 == "3")
                                {
                                    CH = BL;
                                    Console.WriteLine("Przeniesiono wartość z BL do CH");
                                }
                                else if (move2 == "4")
                                {
                                    DH = BL;
                                    Console.WriteLine("Przeniesiono wartość z BL do DH");
                                }
                                else if (move2 == "5")
                                {
                                    AL = BL;
                                    Console.WriteLine("Przeniesiono wartość z BL do AL");
                                }
                                else if (move2 == "6")
                                {
                                    CL = BL;
                                    Console.WriteLine("Przeniesiono wartość z BL do CL");
                                }
                                else if (move2 == "7")
                                {
                                    DL = BL;
                                    Console.WriteLine("Przeniesiono wartość z BL do DL");
                                }
                                else
                                {
                                    Console.WriteLine("Błąd! Proszę wybrać ponownie wartość!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }
                        }
                        else if (opcja8 == "7")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. AH");
                            Console.WriteLine("2. BH");
                            Console.WriteLine("3. CH");
                            Console.WriteLine("4. DH");
                            Console.WriteLine("5. AL");
                            Console.WriteLine("6. BL");
                            Console.WriteLine("7. DL");
                            move2 = Console.ReadLine();
                            if (move2 != null)
                            {
                                if (move2 == "1")
                                {
                                    AH = CL;
                                    Console.WriteLine("Przeniesiono wartość z CL do AH");
                                }
                                else if (move2 == "2")
                                {
                                    BH = CL;
                                    Console.WriteLine("Przeniesiono wartość z CL do BH");
                                }
                                else if (move2 == "3")
                                {
                                    CH = CL;
                                    Console.WriteLine("Przeniesiono wartość z CL do CH");
                                }
                                else if (move2 == "4")
                                {
                                    DH = CL;
                                    Console.WriteLine("Przeniesiono wartość z CL do DH");
                                }
                                else if (move2 == "5")
                                {
                                    AL = CL;
                                    Console.WriteLine("Przeniesiono wartość z CL do AL");
                                }
                                else if (move2 == "6")
                                {
                                    BL = CL;
                                    Console.WriteLine("Przeniesiono wartość z CL do BL");
                                }
                                else if (move2 == "7")
                                {
                                    DL = CL;
                                    Console.WriteLine("Przeniesiono wartość z CL do DL");
                                }
                                else
                                {
                                    Console.WriteLine("Błąd! Proszę wybrać ponownie wartość!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }
                        }
                        else if (opcja8 == "8")
                        {
                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz przenieść wartość!");
                            Console.WriteLine("1. AH");
                            Console.WriteLine("2. BH");
                            Console.WriteLine("3. CH");
                            Console.WriteLine("4. DH");
                            Console.WriteLine("5. AL");
                            Console.WriteLine("6. BL");
                            Console.WriteLine("7. CL");
                            move2 = Console.ReadLine();
                            if (move2 != null)
                            {
                                if (move2 == "1")
                                {
                                    AH = DL;
                                    Console.WriteLine("Przeniesiono wartość z DL do AH");
                                }
                                else if (move2 == "2")
                                {
                                    BH = DL;
                                    Console.WriteLine("Przeniesiono wartość z DL do BH");
                                }
                                else if (move2 == "3")
                                {
                                    CH = DL;
                                    Console.WriteLine("Przeniesiono wartość z DL do CH");
                                }
                                else if (move2 == "4")
                                {
                                    DH = DL;
                                    Console.WriteLine("Przeniesiono wartość z DL do DH");
                                }
                                else if (move2 == "5")
                                {
                                    AL = DL;
                                    Console.WriteLine("Przeniesiono wartość z DL do AL");
                                }
                                else if (move2 == "6")
                                {
                                    BL = DL;
                                    Console.WriteLine("Przeniesiono wartość z DL do BL");
                                }
                                else if (move2 == "7")
                                {
                                    CL = DL;
                                    Console.WriteLine("Przeniesiono wartość z DL do CL");
                                }
                                else
                                {
                                    Console.WriteLine("Błąd! Proszę wybrać ponownie wartość!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nie wybrano rejestru!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Błąd! Proszę wpidać wartość ponownie!");
                    }
                }
                else
                {
                    Console.WriteLine("Nie wybrano żadnej komendy!");
                    goto Powrot1;
                }
            }
        }

        public void operacjear()
        {
            string opcja9;
            string opcja10;
            string opcja11;
            string opcja12;
            int suma;
            Wroc4:
            Console.WriteLine("1. ADD");
            opcja9 = Console.ReadLine();
            if (opcja9 != null)
            {
                if (opcja9 == "1")
                {
                    Wroc5:
                    Console.WriteLine("1. 16BIT");
                    Console.WriteLine("2. 8BIT");
                    opcja10 = Console.ReadLine();
                    if (opcja10 != null)
                    {
                        if (opcja10 == "1")
                        {
                            Wroc6:
                            Console.WriteLine("Wybierz z którego rejestru chcesz dodać wartość!");
                            Console.WriteLine("1. AX");
                            Console.WriteLine("2. BX");
                            Console.WriteLine("3. CX");
                            Console.WriteLine("4. DX");
                            opcja11 = Console.ReadLine();
                            if (opcja11 != null)
                            {
                                if (opcja11 == "1")
                                {
                                    Console.WriteLine("Wybierz do którego rejestru chcesz dodać wartość!");
                                    Console.WriteLine("1. BX");
                                    Console.WriteLine("2. CX");
                                    Console.WriteLine("3. DX");
                                    opcja12 = Console.ReadLine();
                                    if (opcja12 != null)
                                    {
                                        if (opcja12 == "1")
                                        {
                                            suma = AX + BX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja12 == "2")
                                        {
                                            suma = AX + CX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja12 == "3")
                                        {
                                            suma = AX + DX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nie wybrano żadnej wartości!");
                                        goto Wroc6;
                                    }
                                }
                                else if (opcja11 == "2")
                                {
                                    Console.WriteLine("Wybierz do którego rejestru chcesz dodać wartość!");
                                    Console.WriteLine("1. AX");
                                    Console.WriteLine("2. CX");
                                    Console.WriteLine("3. DX");
                                    opcja12 = Console.ReadLine();
                                    if (opcja12 != null)
                                    {
                                        if (opcja12 == "1")
                                        {
                                            suma = BX + AX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja12 == "2")
                                        {
                                            suma = BX + CX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja12 == "3")
                                        {
                                            suma = BX + DX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nie wybrano żadnej wartości!");
                                        goto Wroc6;
                                    }
                                }
                                else if (opcja11 == "3")
                                {
                                    Console.WriteLine("Wybierz do którego rejestru chcesz dodać wartość!");
                                    Console.WriteLine("1. AX");
                                    Console.WriteLine("2. BX");
                                    Console.WriteLine("3. DX");
                                    opcja12 = Console.ReadLine();
                                    if (opcja12 != null)
                                    {
                                        if (opcja12 == "1")
                                        {
                                            suma = CX + AX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja12 == "2")
                                        {
                                            suma = CX + BX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja12 == "3")
                                        {
                                            suma = CX + DX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nie wybrano żadnej wartości!");
                                        goto Wroc6;
                                    }
                                }
                                else if (opcja11 == "4")
                                {
                                    Console.WriteLine("Wybierz do którego rejestru chcesz dodać wartość!");
                                    Console.WriteLine("1. AX");
                                    Console.WriteLine("2. BX");
                                    Console.WriteLine("3. CX");
                                    opcja12 = Console.ReadLine();
                                    if (opcja12 != null)
                                    {
                                        if (opcja12 == "1")
                                        {
                                            suma = DX + AX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja12 == "2")
                                        {
                                            suma = DX + BX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja12 == "3")
                                        {
                                            suma = DX + CX;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nie wybrano żadnej wartości!");
                                        goto Wroc6;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnej komendy!");
                            }
                        }
                        else if (opcja10 == "2")
                        {
                            string opcja13;
                            string opcja14;
                            Console.WriteLine("Proszę wybrać rejestr z którego rejestru chcesz dodać wartość!");
                            Console.WriteLine("1. AL");
                            Console.WriteLine("2. BL");
                            Console.WriteLine("3. CL");
                            Console.WriteLine("4. DL");
                            Console.WriteLine("5. AH");
                            Console.WriteLine("6. BH");
                            Console.WriteLine("7. CH");
                            Console.WriteLine("8. DH");
                            opcja13 = Console.ReadLine();
                            if (opcja13 != null)
                            {
                                if (opcja13 == "1")
                                {
                                    Console.WriteLine("Proszę wybrać rejestr do którego chcesz dodać wartość!");
                                    Console.WriteLine("1. BL");
                                    Console.WriteLine("2. CL");
                                    Console.WriteLine("3. DL");
                                    Console.WriteLine("4. AH");
                                    Console.WriteLine("5. BH");
                                    Console.WriteLine("6. CH");
                                    Console.WriteLine("7. DH");
                                    opcja14 = Console.ReadLine();
                                    if (opcja14 != null)
                                    {
                                        if (opcja14 == "1")
                                        {
                                            suma = AL + BL;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "2")
                                        {
                                            suma = AL + CL;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "3")
                                        {
                                            suma = AL + DL;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "4")
                                        {
                                            suma = AL + AH;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "5")
                                        {
                                            suma = AL + BH;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "6")
                                        {
                                            suma = AL + CH;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "7")
                                        {
                                            suma = AL + DH;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nie wybrano rejestru!");
                                    }
                                }
                                else if (opcja13 == "2")
                                {
                                    Console.WriteLine("Proszę wybrać rejestr do którego chcesz dodać wartość!");
                                    Console.WriteLine("1. AL");
                                    Console.WriteLine("2. CL");
                                    Console.WriteLine("3. DL");
                                    Console.WriteLine("4. AH");
                                    Console.WriteLine("5. BH");
                                    Console.WriteLine("6. CH");
                                    Console.WriteLine("7. DH");
                                    opcja14 = Console.ReadLine();
                                    if (opcja14 != null)
                                    {
                                        if (opcja14 == "1")
                                        {
                                            suma = BL + AL;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "2")
                                        {
                                            suma = BL + CL;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "3")
                                        {
                                            suma = BL + DL;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "4")
                                        {
                                            suma = BL + AH;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "5")
                                        {
                                            suma = BL + BH;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "6")
                                        {
                                            suma = BL + CH;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                        else if (opcja14 == "7")
                                        {
                                            suma = BL + DH;
                                            Console.WriteLine("Suma to: " + suma);
                                        }
                                    }
                                    else if (opcja13 == "3")
                                    {
                                        Console.WriteLine("Proszę wybrać rejestr do którego chcesz dodać wartość!");
                                        Console.WriteLine("1. AL");
                                        Console.WriteLine("2. BL");
                                        Console.WriteLine("3. DL");
                                        Console.WriteLine("4. AH");
                                        Console.WriteLine("5. BH");
                                        Console.WriteLine("6. CH");
                                        Console.WriteLine("7. DH");
                                        opcja14 = Console.ReadLine();
                                        if (opcja14 != null)
                                        {
                                            if (opcja14 == "1")
                                            {
                                                suma = CL + AL;
                                                Console.WriteLine("Suma to: " + suma);
                                            }
                                            else if (opcja14 == "2")
                                            {
                                                suma = CL + BL;
                                                Console.WriteLine("Suma to: " + suma);
                                            }
                                            else if (opcja14 == "3")
                                            {
                                                suma = CL + DL;
                                                Console.WriteLine("Suma to: " + suma);
                                            }
                                            else if (opcja14 == "4")
                                            {
                                                suma = CL + AH;
                                                Console.WriteLine("Suma to: " + suma);
                                            }
                                            else if (opcja14 == "5")
                                            {
                                                suma = CL + BH;
                                                Console.WriteLine("Suma to: " + suma);
                                            }
                                            else if (opcja14 == "6")
                                            {
                                                suma = CL + CH;
                                                Console.WriteLine("Suma to: " + suma);
                                            }
                                            else if (opcja14 == "7")
                                            {
                                                suma = CL + DH;
                                                Console.WriteLine("Suma to: " + suma);
                                            }
                                        }
                                        else if (opcja13 == "4")
                                        {
                                            Console.WriteLine("Proszę wybrać rejestr do którego chcesz dodać wartość!");
                                            Console.WriteLine("1. AL");
                                            Console.WriteLine("2. BL");
                                            Console.WriteLine("3. CL");
                                            Console.WriteLine("4. AH");
                                            Console.WriteLine("5. BH");
                                            Console.WriteLine("6. CH");
                                            Console.WriteLine("7. DH");
                                            opcja14 = Console.ReadLine();
                                            if (opcja14 != null)
                                            {
                                                if (opcja14 == "1")
                                                {
                                                    suma = DL + AL;
                                                    Console.WriteLine("Suma to: " + suma);
                                                }
                                                else if (opcja14 == "2")
                                                {
                                                    suma = DL + BL;
                                                    Console.WriteLine("Suma to: " + suma);
                                                }
                                                else if (opcja14 == "3")
                                                {
                                                    suma = DL + CL;
                                                    Console.WriteLine("Suma to: " + suma);
                                                }
                                                else if (opcja14 == "4")
                                                {
                                                    suma = DL + AH;
                                                    Console.WriteLine("Suma to: " + suma);
                                                }
                                                else if (opcja14 == "5")
                                                {
                                                    suma = DL + BH;
                                                    Console.WriteLine("Suma to: " + suma);
                                                }
                                                else if (opcja14 == "6")
                                                {
                                                    suma = DL + CH;
                                                    Console.WriteLine("Suma to: " + suma);
                                                }
                                                else if (opcja14 == "7")
                                                {
                                                    suma = DL + DH;
                                                    Console.WriteLine("Suma to: " + suma);
                                                }
                                            }
                                            else if (opcja13 == "5")
                                            {
                                                Console.WriteLine("Proszę wybrać rejestr do którego chcesz dodać wartość!");
                                                Console.WriteLine("1. AL");
                                                Console.WriteLine("2. BL");
                                                Console.WriteLine("3. CL");
                                                Console.WriteLine("4. DL");
                                                Console.WriteLine("5. BH");
                                                Console.WriteLine("6. CH");
                                                Console.WriteLine("7. DH");
                                                opcja14 = Console.ReadLine();
                                                if (opcja14 != null)
                                                {
                                                    if (opcja14 == "1")
                                                    {
                                                        suma = AH + AL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "2")
                                                    {
                                                        suma = AH + BL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "3")
                                                    {
                                                        suma = AH + CL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "4")
                                                    {
                                                        suma = AH + DL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "5")
                                                    {
                                                        suma = AH + BH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "6")
                                                    {
                                                        suma = AH + CH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "7")
                                                    {
                                                        suma = AH + DH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nie wybrano rejestru!");
                                                }
                                            }
                                            else if (opcja13 == "6")
                                            {
                                                Console.WriteLine("Proszę wybrać rejestr do którego chcesz dodać wartość!");
                                                Console.WriteLine("1. AL");
                                                Console.WriteLine("2. BL");
                                                Console.WriteLine("3. CL");
                                                Console.WriteLine("4. DL");
                                                Console.WriteLine("5. AH");
                                                Console.WriteLine("6. CH");
                                                Console.WriteLine("7. DH");
                                                opcja14 = Console.ReadLine();
                                                if (opcja14 != null)
                                                {
                                                    if (opcja14 == "1")
                                                    {
                                                        suma = BH + AL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "2")
                                                    {
                                                        suma = BH + BL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "3")
                                                    {
                                                        suma = BH + CL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "4")
                                                    {
                                                        suma = BH + DL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "5")
                                                    {
                                                        suma = BH + AH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "6")
                                                    {
                                                        suma = BH + CH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "7")
                                                    {
                                                        suma = BH + DH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nie wybrano rejestru!");
                                                }
                                            }
                                            else if (opcja13 == "7")
                                            {
                                                Console.WriteLine("Proszę wybrać rejestr do którego chcesz dodać wartość!");
                                                Console.WriteLine("1. AL");
                                                Console.WriteLine("2. BL");
                                                Console.WriteLine("3. CL");
                                                Console.WriteLine("4. DL");
                                                Console.WriteLine("5. AH");
                                                Console.WriteLine("6. BH");
                                                Console.WriteLine("7. DH");
                                                opcja14 = Console.ReadLine();
                                                if (opcja14 != null)
                                                {
                                                    if (opcja14 == "1")
                                                    {
                                                        suma = CH + AL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "2")
                                                    {
                                                        suma = CH + BL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "3")
                                                    {
                                                        suma = CH + CL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "4")
                                                    {
                                                        suma = CH + DL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "5")
                                                    {
                                                        suma = CH + AH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "6")
                                                    {
                                                        suma = CH + BH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "7")
                                                    {
                                                        suma = CH + DH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nie wybrano rejestru!");
                                                }
                                            }
                                            else if (opcja13 == "8")
                                            {
                                                Console.WriteLine("Proszę wybrać rejestr do którego chcesz dodać wartość!");
                                                Console.WriteLine("1. AL");
                                                Console.WriteLine("2. BL");
                                                Console.WriteLine("3. CL");
                                                Console.WriteLine("4. DL");
                                                Console.WriteLine("5. AH");
                                                Console.WriteLine("6. BH");
                                                Console.WriteLine("7. CH");
                                                opcja14 = Console.ReadLine();
                                                if (opcja14 != null)
                                                {
                                                    if (opcja14 == "1")
                                                    {
                                                        suma = DH + AL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "2")
                                                    {
                                                        suma = DH + BL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "3")
                                                    {
                                                        suma = DH + CL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "4")
                                                    {
                                                        suma = DH + DL;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "5")
                                                    {
                                                        suma = DH + AH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "6")
                                                    {
                                                        suma = DH + BH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                    else if (opcja14 == "7")
                                                    {
                                                        suma = DH + CH;
                                                        Console.WriteLine("Suma to: " + suma);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nie wybrano rejestru!");
                                                    goto Wroc5;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nie wybrano rejestru!");
                                                goto Wroc5;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nie wybrano rejestru!");
                                            goto Wroc5;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nie wybrano rejestru!");
                                        goto Wroc5;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Błąd! Proszę wybrać rejestr ponownie!");
                                    goto Wroc5;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie wybrano żadnego rejestru!");
                                goto Wroc5;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Błąd! Prosze wybrać ponownie!");
                            goto Wroc5;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nie wybrano żadnej komendy");
                        goto Wroc5;
                    }
                }
                else
                {
                    Console.WriteLine("Błąd! Proszę wybrać ponownie!");
                    goto Wroc4;
                }
            }
            else
            {
                Console.WriteLine("Nie wybrano żadnej komendy!");
                goto Wroc4;
            }
        }
    }
}   