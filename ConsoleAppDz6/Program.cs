using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ConsoleAppDz6;
class Program
{
    static void Main(string[] args)
    {
        List<Pidruchnuk> books = new List<Pidruchnuk>();
        const string filePath = "C:\\Users\\yulia\\source\\repos\\ConsoleAppDz6\\ConsoleAppDz6\\j.json";

       
            try
            {
                
                string jsonContent = File.ReadAllText(filePath);

               
            books = JsonSerializer.Deserialize<List<Pidruchnuk>>(jsonContent);

            foreach (var pidruchnuk in books)
            {
                 Console.WriteLine($"Title: {pidruchnuk.Title}");
                    Console.WriteLine($"Publishing House ID: {pidruchnuk.PublishingHouseId}");
                    Console.WriteLine($"Publishing House Name: {pidruchnuk.PublishingHouse.Name}");
                    Console.WriteLine($"Address: {pidruchnuk.PublishingHouse.Adress}");
                    Console.WriteLine();
            }

        }
            catch (Exception ex)
            {
                Console.WriteLine($"Невідома помилка: {ex.Message}");
            }


        
} }