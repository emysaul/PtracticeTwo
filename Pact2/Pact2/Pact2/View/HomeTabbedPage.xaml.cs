using Pact2.ModelView;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pact2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            InitializeComponent();
            BindingContext = new LoginUserModelView();
        }
    }
}