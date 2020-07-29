using MVP_architecture.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MVP_architecture
{
    /// <summary>
    /// Логика взаимодействия для ProjectView.xaml
    /// </summary>
    /// 
    public interface IProjectsView
    {
        int NONE_SELECTED { get; }
        int SelectedProjectId { get; }
        void UpdateProject(Project project);
        void LoadProjects(IEnumerable<Project> projects);
        void UpdateDetails(Project project);
        void EnableControls(bool isEnabled);
        void SetEstimatedColor(Color? color);
        event EventHandler<ProjectEventArgs> ProjectUpdated;
        event EventHandler<ProjectEventArgs> DetailsUpdated;
        event EventHandler SelectionChanged;
    }
    public partial class ProjectView : Window, IProjectsView
    {
        public int NONE_SELECTED { get { return -1; } }
        public event EventHandler<ProjectEventArgs>
        ProjectUpdated = delegate { };
        public int SelectedProjectId { get; private set; }

        public event EventHandler SelectionChanged = delegate { };
        public event EventHandler<ProjectEventArgs> DetailsUpdated = delegate { };

        public ProjectView()
        {
            InitializeComponent();
            SelectedProjectId = NONE_SELECTED;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Project project = new Project();
            project.Name = nameTextBox.Text;
            project.Estimate = GetDouble(estimatedTextBox.Text);
            project.Actual = GetDouble(actualTextBox.Text);
            project.ID = int.Parse(projectsComboBox.SelectedValue.ToString());
            ProjectUpdated(this, new ProjectEventArgs(project));
        }

        private void projectsComboBox_SelectionChanged(
            object sender, SelectionChangedEventArgs e)
        {
            SelectedProjectId = (projectsComboBox.SelectedValue == null) ?
                NONE_SELECTED : int.Parse(projectsComboBox.SelectedValue.ToString());
            SelectionChanged(this, new EventArgs());
        }

        public void UpdateProject(Project project)
        {
            IEnumerable<Project> projects = projectsComboBox.ItemsSource as IEnumerable<Project>;
            Project projectToUpdate = projects.Where(p => p.ID == project.ID).First() as Project;
            projectToUpdate.Name = project.Name;
            projectToUpdate.Estimate = project.Estimate;
            projectToUpdate.Actual = project.Actual;
            if (project.ID == SelectedProjectId)
                UpdateDetails(project);
        }

        public void LoadProjects(IEnumerable<Project> projects)
        {
            projectsComboBox.ItemsSource = projects;
            projectsComboBox.DisplayMemberPath = "Name";
            projectsComboBox.SelectedValuePath = "ID";
        }

        public void EnableControls(bool isEnabled)
        {
            estimatedTextBox.IsEnabled = isEnabled;
            actualTextBox.IsEnabled = isEnabled;
            updateButton.IsEnabled = isEnabled;
        }

        public void SetEstimatedColor(Color? color)
        {
            estimatedTextBox.Foreground = (color == null) ?
                actualTextBox.Foreground : new SolidColorBrush((Color)color);
        }

        public void UpdateDetails(Project project)
        {
            nameTextBox.Text = project.Name;
            estimatedTextBox.Text = project.Estimate.ToString();
            actualTextBox.Text = project.Actual.ToString();
            DetailsUpdated(this, new ProjectEventArgs(project));
        }

        private double GetDouble(string text)
        {
            return string.IsNullOrEmpty(text) ? 0 : double.Parse(text);
        }
    }
}
