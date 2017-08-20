using Nancy;

namespace InfinityDataService
{
    public class DataServices : NancyModule
    {
        public DataServices()
        {
            Get["/"] = _ => "<a href='/Category'>GetCategories</a>";

            Get["/Category"] = _ => DataFactory.GetCategories();

            Get["/Category/{id}"] = parameters => DataFactory.GetCategoryById(parameters.id);
        }
    }
}