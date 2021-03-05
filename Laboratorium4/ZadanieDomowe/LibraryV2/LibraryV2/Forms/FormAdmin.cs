using LibraryV2.Models.Entities;
using LibraryV2.Repositories;
using LibraryV2.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryV2.Forms
{
    public partial class FormAdmin : Form
    {
        // Obiekt repozytorium użytkownika
        private UsersRepository usersRepository = new UsersRepository();

        public FormAdmin()
        {
            InitializeComponent();

            // Ustawienie okna, żeby pojawiało się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Funkcja służąca do odświeżenia dataGridViewIdentities
        /// </summary>
        private void RefreshDataGridViewIdentities()
        {
            dataGridViewIdentities.DataSource = usersRepository.GetIdentities();
        }
        /// <summary>
        /// Funkcja służąca do odświeżenia dataGridViewUsers
        /// </summary>
        private void RefreshDataGridViewUsers()
        {
            dataGridViewUsers.DataSource = usersRepository.GetUsers();
        }
        /// <summary>
        /// Funkcja służy do wyczyszczenia wszystkich TextBoxów
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxId.Text = "";
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            textBoxPerson.Text = "";
            textBoxRole.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAge.Text = "";
            textBoxImage.Text = "";
        }
        /// <summary>
        /// Funkcja służąca do przekonwertowania zmiennej typu Image na byte[]
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        /// <summary>
        /// Funkcja służąca do przekonwertowania zmiennej typu byte[] na Image
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // Akutalizuje dane w DataGridViewIdentities przy ładowaniu okna
            RefreshDataGridViewIdentities();
            RefreshDataGridViewUsers();
        }
        /// <summary>
        /// Przycisk służy do wybrania zdjęcia definiującego jeden z parametrów
        /// tabeli Identity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            // Wybranie zdjęć w określonym formacie
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Image files (*.jpeg)|*.jpeg", Multiselect = false })
            {
                // Jeżeli wybierzemy zdjęcie
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Wyświetlamy zdjęcie
                    pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
                    // Wyświetlamy ścieżkę
                    textBoxImage.Text = openFileDialog.FileName;
                }
            }
        }
        /// <summary>
        /// Przycisk służy do dodanania osoby do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddIdentity_Click(object sender, EventArgs e)
        {
            // Parametry opisujące osobę
            string firstName;
            string lastName;
            int age;
            byte[] image;

            try
            {
                firstName = textBoxFirstName.Text;
                lastName = textBoxLastName.Text;
                age = int.Parse(textBoxAge.Text);
                image = ConvertImageToBytes(pictureBoxPhoto.Image);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Podałeś nieprawidłowe parametry Osoby!");
                return;
            }

            // Zmienna do sprawdzenia czy osoba została dodana
            bool isAdded = usersRepository.AddIdentity(firstName, lastName, age, image);

            // Jeśli tak, to odśwież tabelę
            if (isAdded)
            {
                RefreshDataGridViewIdentities();
            }
            // Jeśli nie, to wyświetl komunikat
            else
            {
                MessageBox.Show("Osoba nie została dodana sprawdź poprawność parametrów");
            }
        }
        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku dodania nowego użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            // Pobranie parametrów użytkownika z tabel
            string login;
            string password;
            int personId;
            string role;
            try
            {
                login = textBoxLogin.Text;
                password = textBoxPassword.Text;
                personId = int.Parse(textBoxPerson.Text);
                role = textBoxRole.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Podałeś nieprawidłowe parametry użytkownika");
                return;
            }
            // Dodanie użytkownika
            bool isAdded = usersRepository.AddUser(login, password, personId, role);
            // Jeżeli uzytkownik został dodany 
            if (isAdded)
            {
                // Odświeżamy tabelę
                RefreshDataGridViewUsers();
                // Czyścimy okienka
                ClearTextBoxes();
            }
            // Jeżeli nie, to wyświetlamy odpowiedni komunikat
            else
            {
                MessageBox.Show("Użytkownik nie został usunięty sprawdź poprawność parametrów");
            }
        }
        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku usunięcia użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            // Pobranie id użytkownika
            int id;
            try
            {
                id = int.Parse(textBoxId.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Musisz wpisać Id!");
                return;
            }
            // Usunięcie użytkownika z bazy
            bool isDeleted = usersRepository.DeleteUser(id);
            // Jeżeli użytkownik został usunięty
            if (isDeleted)
            {
                // Odświeżamy tabelę użytkownika
                RefreshDataGridViewUsers();
                // Czyścimy textboxy
                ClearTextBoxes();
            }
            // Jeżeli nie został, wyświetlamy odpowiedni komunikat
            else
            {
                MessageBox.Show("Użytkownik nie został usunięty sprawdź poprawność parametrów");
            }
        }
        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku edytowania użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            // Pobranie danych z textboxów
            int id;
            string login;
            string password;
            int personId;
            string role;
            try
            {
                id = int.Parse(textBoxId.Text);
                login = textBoxLogin.Text;
                password = textBoxPassword.Text;
                personId = int.Parse(textBoxPerson.Text);
                role = textBoxRole.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Podałeś nieprawidłowe parametry użytkownika!");
                return;
            }
            // Wysłanie zapytania edytującego dane użytkownika
            bool isEdited = usersRepository.EditUser(id, login, password, personId, role);
            // Jeżeli uzytkownik został edytowany
            if (isEdited)
            {
                // Odświeżamy tabelę
                RefreshDataGridViewUsers();
                // Czyścimy textboxy
                ClearTextBoxes();
            }
            // Jeżeli nie to wyświetlamy odpowiedni komunikat
            else
            {
                MessageBox.Show("Użytkownik nie został usunięty sprawdź poprawność parametrów");
            }
        }
        /// <summary>
        /// Metoda wykonywana za każdym razem gdy użytkownik zmieni zaznaczenie wiersza w DataGridViewUsers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            // Pobieramy dane wybranego użytkownika
            UsersViewModel users = (UsersViewModel)dataGridViewUsers.CurrentRow.DataBoundItem;

            //nadpisz dane zaznaczonym rekordem
            textBoxId.Text = users.Id.ToString();
            textBoxLogin.Text = users.Login.ToString();
            textBoxPassword.Text = users.Password.ToString();
            textBoxPerson.Text = users.IdentityId.ToString();
            textBoxRole.Text = users.Role;
        }
        /// <summary>
        /// Metoda wykonywana za każdym razem gdy użytkownik zmieni zaznaczenie wiersza w DataGridViewIdentitys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewIdentities_SelectionChanged(object sender, EventArgs e)
        {
            // Pobranie zaznaczonych danych z tabeli
            Identities identities = (Identities)dataGridViewIdentities.CurrentRow.DataBoundItem;

            // Zmiana wyświetlanego zdjęcia
            pictureBoxPhoto.Image = ConvertByteArrayToImage(identities.Image);
        }
    }
}
