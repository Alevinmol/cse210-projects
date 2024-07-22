using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Manuel Buelta 121", "Teapa", "Tabasco", "Mexico");
        Address address2 = new Address("Wallaby P Sherman", "Sydney", "New South Wales", "Australia");
        Address address3 = new Address("4374 S Main street", "Murray", "Utah", "USA");
        
        Lecture lecture = new Lecture("How to play Yugioh", "An in depth look at the Yugioh meta on 2024", "07/30/2024", "5:00PM", address1, "Lecture", "Yami Yugi", 200);
        Reception reception = new Reception("Al's graduation", "A celebration to Al graduating high school", "07/30/2024", "6:00PM", address2, "Reception", "alsgraduation@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Family picnic", " A family gathering to catch up and eat together", "07/30/2024", "3:00PM", address3, "Outdoor Gathering", "Nice and sunny");

        lecture.ShortDescription();
        Console.WriteLine();
        lecture.StandardDetails();
        Console.WriteLine();
        lecture.FullDetais();
        Console.WriteLine();

        reception.ShortDescription();
        Console.WriteLine();
        reception.StandardDetails();
        Console.WriteLine();
        reception.FullDetais();
        Console.WriteLine();

        outdoorGathering.ShortDescription();
        Console.WriteLine();
        outdoorGathering.StandardDetails();
        Console.WriteLine();
        outdoorGathering.FullDetais();
    }
}