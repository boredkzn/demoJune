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
using System.Windows.Shapes;

namespace demoJune
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        MainWindow mainwindow;
        ProizvodstvoEntities ProizvodstvoEntities = new ProizvodstvoEntities();
        Agent agentMain;
        public Edit(Agent agent)
        {
            InitializeComponent();
            imaAgenta.Text = agent.ImaAgenta;
            imaComp.Text = agent.ImaCompanii;
            adress.Text = agent.UridisheskiiAdres;
            inn.Text = agent.Inn;
            kpp.Text = agent.Kpp;
            fami.Text = agent.FamiliaDirectora;
            imya.Text = agent.ImaDirectora;
            otchest.Text = agent.OtchestvoDirectora;
            phone.Text = agent.Telefon;
            pochta.Text = agent.Pothta;
            prioritet.Text = agent.PrioritetnostPostavkah.ToString();
            typeAgent.Text = agent.nameType;
            agentMain = agent;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in ProizvodstvoEntities.Agent.ToList())
            {
                if (item.AgentId == agentMain.AgentId)
                {
                    item.ImaAgenta = imaAgenta.Text;
                    item.ImaCompanii = imaComp.Text;
                    item.UridisheskiiAdres = adress.Text;
                    item.Inn = inn.Text;
                    item.Kpp = kpp.Text;
                    item.FamiliaDirectora = fami.Text;
                    item.ImaDirectora = imya.Text;
                    item.OtchestvoDirectora = otchest.Text;
                    item.Telefon = phone.Text;
                    item.Pothta = pochta.Text;
                    item.PrioritetnostPostavkah = short.Parse(prioritet.Text);
                    item.nameType = typeAgent.Text;
                }
            }
            
            ProizvodstvoEntities.SaveChanges();
            MessageBox.Show("Успешно");
            mainwindow = new MainWindow();
            mainwindow.sii.ItemsSource = ProizvodstvoEntities.Agent.ToList();
            Close();
            mainwindow.Show();
        }
    }
}
