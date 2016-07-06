using CsvHelper.Configuration;

namespace CreateCsvFileWithMappingByColumnName
{
    sealed class UserMap : CsvClassMap<User>
    {
        public UserMap()
        {
            Map(m => m.Name).Name("User name");
            Map(m => m.Surname).Name("User surname");
            Map(m => m.Age).Name("User age");
        }
    }
}
