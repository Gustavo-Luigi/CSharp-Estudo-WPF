using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PropertyChanged.ViewModels
{
    public class MainViewModel
    {
        public PersonViewModel Person { get; private set; }
        public BackgoundViewModel Background { get; private set; }

        public MainViewModel()
        {
            Person = new PersonViewModel();
            Background = new BackgoundViewModel();
        }

        public void SetBackgorund(Brush brushColor)
        {
            Background.Color = brushColor;
        }
    }
}
