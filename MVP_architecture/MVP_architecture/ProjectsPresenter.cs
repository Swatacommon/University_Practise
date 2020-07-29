using System;
using System.Windows.Media;
using MVP_architecture.DataAccess;

namespace MVP_architecture
{
    class ProjectsPresenter
    {

        private IProjectsView view = null;
        private IProjectsModel model = null;

        public ProjectsPresenter(IProjectsView projectsView, IProjectsModel projectsModel)
        {
            view = projectsView;
            view.ProjectUpdated += view_ProjectUpdated;
            view.SelectionChanged += view_SelectionChanged;
            view.DetailsUpdated += view_DetailsUpdated;
            model = projectsModel;
            model.ProjectUpdated += model_ProjectUpdated;
            view.LoadProjects(model.GetProjects());
        }

        //обработчик вызывается в ответ на событие IProjectsView.DetailsUpdated и просто вызывает SetEstimateColor() 
        //для обновления цвета TextBox со предположительной стоимостью проекта.
        private void view_DetailsUpdated(object sender, ProjectEventArgs e)
        {
            SetEstimatedColor(e.Project);
        }

        //обновляет представление при возникновении события IProjectsView.SelectionChanged (выбора нового проекта в ComboBox).
        private void view_SelectionChanged(object sender, EventArgs e)
        {
            int selectedId = view.SelectedProjectId;
            if (selectedId > view.NONE_SELECTED)
            {
                Project project = model.GetProject(selectedId);
                view.EnableControls(true);
                view.UpdateDetails(project);
                SetEstimatedColor(project);
            }
            else
            {
                view.EnableControls(false);
            }
        }

        //вызывается в ответ на IProjectsModel.ProjectUpdate, также вызывая обновление модели и представления.
        private void model_ProjectUpdated(object sender, ProjectEventArgs e)
        {
            view.UpdateProject(e.Project);
        }

        private void view_ProjectUpdated(object sender,
            ProjectEventArgs e)
        {
            model.UpdateProject(e.Project);
            SetEstimatedColor(e.Project);
        }

        private void SetEstimatedColor(Project project)
        {
            if (project.ID == view.SelectedProjectId)
            {
                if (project.Actual <= 0)
                {
                    view.SetEstimatedColor(null);
                }
                else if (project.Actual > project.Estimate)
                {
                    view.SetEstimatedColor(Colors.Red);
                }
                else
                {
                    view.SetEstimatedColor(Colors.Green);
                }
            }
        }

    }
}
