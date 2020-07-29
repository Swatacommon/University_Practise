using MVP_architecture.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_architecture
{
    //вспомогательный класс члены которого могут использоваться в обработчике события ProjectUpdated.
    public class ProjectEventArgs : EventArgs
    {
        public Project Project { get; set; }
        public ProjectEventArgs(Project project)
        {
            Project = project;
        }
    }

    public interface IProjectsModel
    {
        void UpdateProject(Project project); // метод позволяет обновлять проект.
        IEnumerable<Project> GetProjects(); // метод, возвращает список проектов.
        Project GetProject(int Id); //возвращает проект по ID.
        event EventHandler<ProjectEventArgs> ProjectUpdated; //событие, которое вызывается, когда проект был обновлен.
    }

    class ProjectsModel : IProjectsModel
    {
        private IEnumerable<Project> projects = null;
        public event EventHandler<ProjectEventArgs> ProjectUpdated = delegate { };

        public ProjectsModel()
        {
            projects = new DataServiceStub().GetProjects();
        }

        public void UpdateProject(Project project)
        {
            ProjectUpdated(this, new ProjectEventArgs(project));
        }

        public IEnumerable<Project> GetProjects()
        {
            return projects;
        }


        public Project GetProject(int Id)
        {
            return projects.Where(p => p.ID == Id).First() as Project;
        }
    }
}
