using System.Linq;
using System.Windows;

namespace Project07
{
    /// <summary>
    /// 3.2	Лабораторная работа № 3. Тема: «Модульное проектирование ПС» Вариант №2 https://github.com/Hawinar
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DGridStudents.ItemsSource = Project07TestEntities.GetContext().Student.ToList();
        }
    }
}
