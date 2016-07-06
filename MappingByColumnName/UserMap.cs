using CsvHelper.Configuration;

namespace MappingByColumnName
{
    sealed class UserMap : CsvClassMap<User>
    {
        public UserMap()
        {
            Map(m => m.Name).Name("User Name");
            Map(m => m.Surname).Name("User Surname");
            Map(m => m.Age).Name("User Age");
        }
    }
}
