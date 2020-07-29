using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_architecture.DataAccess
{
    public interface IDataService
    {
        IList<Project> GetProjects();
    }

    public class DataServiceStub : IDataService
    {
        public IList<Project> GetProjects()
        {
            List<Project> projects = new List<Project>()
            {
                new Project()
                {
                    ID = 0,
                    Name = "BelaktSocialNetwork",
                    Estimate = 500
                },
                new Project()
                {
                    ID = 1,
                    Name = "SteamBelarusEdition",
                    Estimate = 15000
                },
                new Project()
                {
                    ID = 2,
                    Name = "CityRhytms",
                    Estimate = 20000
                }
            };

            return projects;
        }
    }
}
