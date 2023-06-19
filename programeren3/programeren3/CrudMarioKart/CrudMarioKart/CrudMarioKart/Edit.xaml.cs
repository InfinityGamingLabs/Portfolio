using System;
using System.Data;
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

namespace CrudMarioKart
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit(DataRowView character)
        {
            InitializeComponent();
            FillScreen(character);
        }

        private void FillScreen(DataRowView character)
        {
            tbPlayerID.Text = character["TeamID"].ToString();
            tbName.Text = character["naam"].ToString();
            tbColor.Text = character["coach"].ToString();
            tbAttack.Text = character["stadion"].ToString();
            tbCarID.Text = character["opgericht"].ToString();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            CharacterDB characterDB = new CharacterDB();
            if (characterDB.UpdateCharacter(tbPlayerID.Text, tbName.Text, tbColor.Text, tbAttack.Text, tbCarID.Text))
            {
                MessageBox.Show($"character {tbPlayerID.Text} aangepast");
            }
            else
            {
                MessageBox.Show($"Aanpassen van {tbPlayerID.Text} mislukt");
            }
            this.Close();
        }
    }
}
