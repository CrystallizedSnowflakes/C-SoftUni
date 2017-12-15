using System;

class BlankReceipt
{
    static void Main()
    {
        PrintReceipt();
    }

    static void PrintReceipt()
    {
        PrintReceiptHeader();
        PrintReceiptBody();
        PrintREceiptFooter();
    }

    static void PrintREceiptFooter()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("\u00A9 SoftUni");
    }

    static void PrintReceiptBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    static void PrintReceiptHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }
}

