using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace MappingByColumnIndex
{
    class Program
    {
        static void Main()
        {
            IEnumerable<User> users;

            using (var streamReader = File.OpenText("Pirates.csv"))
            {
                var reader = new CsvReader(streamReader);
                reader.Configuration.RegisterClassMap<UserMap>();
                users = reader.GetRecords<User>().ToList();
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name}, {user.Surname}, {user.Age}");
            }
            Console.ReadLine();
        }
    }
}
