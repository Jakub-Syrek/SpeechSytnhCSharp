using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemo
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
        public string prefferedVoice = "Microsoft David Desktop";
        private void ReadContent_Click(object sender, RoutedEventArgs e)
        {           
                using (TasksVoiceSynthesis taskObj = new TasksVoiceSynthesis($"{ Text.Text}", prefferedVoice))
                {
                    //taskObj.text = $"{ Text.Text}";
                    taskObj.PlayTasks(prefferedVoice);
                }            
        }        
        private void ChangeVoice_Click(object sender, RoutedEventArgs e)
        {
            using (TasksVoiceSynthesis taskObj = new TasksVoiceSynthesis($"{ Text.Text}", prefferedVoice))
            {
                //taskObj.text = $"{ Text.Text}";
                //taskObj.PlayTasks();
                //taskObj.ReturnInstalledVoices();
                List<string> lista = taskObj.Voices;              
                
                string currentVoice = taskObj.CurrentVoice();
                for (int i = 0;i <= lista.Count-1;i++)
                {
                    if (prefferedVoice != lista[i])
                    {
                        prefferedVoice = lista[i];
                        break;
                        
                    }
                }
            }
        }
    }
}
