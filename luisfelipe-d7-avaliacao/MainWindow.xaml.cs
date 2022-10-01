using System.Windows;

namespace luisfelipe_d7_avaliacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
          
            InitializeComponent();
        }

        private void Acessar(object sender, RoutedEventArgs e)
        {
            string email;
            string senha;
            email = user.Text;
            senha = pass.Password.ToString();
            if (email != "admin@email.com" && senha != "admin123") 
            {
                MessageBox.Show("Credenciais inválidas.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else 
            {
                MessageBox.Show("Usuário autenticado!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.None);
            }
            
        }
    }
}
