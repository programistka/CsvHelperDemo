using CsvHelper.Configuration;

namespace MappingByColumnIndex
{
    sealed class UserMap : CsvClassMap<User>
    {
        public UserMap()
        {
            Map(m => m.Name).Index(0);
            Map(m => m.Surname).Index(1);
            Map(m => m.Age).Index(2);
        }
    }
}
