
using TallerUsoLayouts; 

namespace TallerUsoLayouts 
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();

            // Usamos NavigationPage para que se pueda navegar entre páginas
            MainPage = new NavigationPage(new MainPage());
        }
        
    }
}
