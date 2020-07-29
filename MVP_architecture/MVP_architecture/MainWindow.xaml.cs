using System.Windows;
using MVP_architecture;
namespace MVP_architecture
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    ///

    public partial class MainWindow : Window
    {
        private IProjectsModel model = null;
        public MainWindow()
        {
            InitializeComponent();
            model = new ProjectsModel();
        }

        private void showProjectsButton_Click(object sender, RoutedEventArgs e)
        {
            ProjectView view = new ProjectView();
            ProjectsPresenter presenter = new ProjectsPresenter(view, model);
            view.Owner = this;
            view.Show();
        }
    }
}
