using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace CreateCsvFileWithMappingByColumnName
{
    class Program
    {
        static void Main()
        {
            var users = new List<User>()
            {
                new User() {Name = "Jack", Surname = "Sparrow", Age = 23},
                new User() {Name = "Davy", Surname = "Jones", Age = 25},
                new User() {Name = "Hektor", Surname = "Barbossa", Age = 23}
            };
            using (var streamWriter = File.CreateText("Pirates.csv"))
            {
                var writer = new CsvWriter(streamWriter);
                writer.Configuration.RegisterClassMap<UserMap>();
                writer.WriteRecords(users);
            }

            IEnumerable<User> records;

            using (var streamReader = File.OpenText("Pirates.csv"))
            {
                var reader = new CsvReader(streamReader);
                reader.Configuration.RegisterClassMap<UserMap>();
                records = reader.GetRecords<User>().ToList();
            }

            foreach (var user in records)
            {
                Console.WriteLine($"{user.Name}, {user.Surname}, {user.Age}");
            }
            Console.ReadLine();
        }
    }
}
