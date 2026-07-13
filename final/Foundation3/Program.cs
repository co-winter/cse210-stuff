using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "100 College Ave",
            "Rexburg",
            "ID",
            "USA");

        Lecture lecture = new Lecture(
            "C# Programming",
            "Learn the basics of C#.",
            "July 20, 2026",
            "6:00 PM",
            address1,
            "John Smith",
            150);


        Address address2 = new Address(
            "500 Main Street",
            "Boise",
            "ID",
            "USA");

        Reception reception = new Reception(
            "Company Reception",
            "Meet our newest employees.",
            "August 5, 2026",
            "7:00 PM",
            address2,
            "rsvp@company.com");


        Address address3 = new Address(
            "Green Park",
            "Idaho Falls",
            "ID",
            "USA");

        OutdoorGathering outdoor = new OutdoorGathering(
            "Community Picnic",
            "Bring food and enjoy the afternoon.",
            "September 10, 2026",
            "12:00 PM",
            address3,
            "Sunny, 75°F");


        Console.WriteLine("===== LECTURE =====");
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDetails());

        Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.WriteLine();


        Console.WriteLine("===== RECEPTION =====");
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDetails());

        Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.WriteLine();


        Console.WriteLine("===== OUTDOOR GATHERING =====");
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoor.GetShortDetails());
    }
}