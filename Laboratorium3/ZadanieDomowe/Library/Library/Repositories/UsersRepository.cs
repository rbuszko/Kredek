using System;
using System.Data.SqlClient;

namespace Library.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Users
    /// </summary>
    class UsersRepository: Repository, Interfaces.IUsersRepository
    {
        /// <summary>
        /// Funkcja służy do zalogowania się do okna pracownika na podstawie loginu i hasła
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool LoginWorker(string login, string password)
        {
            // Przypisanie wartości loginu i hasła do zmiennych statycznych
            Program.Login = login;
            Program.Password = password;

            string queryGetRolesId = "SELECT RolesId FROM Users WHERE Login='" + login + "' AND Password='" + password + "';";
            string loginQuery = $"SELECT COUNT(*) FROM Users WHERE Login='{login}' AND Password='{password}';";

            Connection.Open();
            // Dostęp do Id Klienta
            SqlCommand commandGetRolesId = new SqlCommand(queryGetRolesId, Connection);
            int RolesId = (int)commandGetRolesId.ExecuteScalar();

            // Dostęp do Nazwy użytkownika
            string queryGetRoleName = $"SELECT Name FROM Roles WHERE Id= {RolesId};";
            SqlCommand commandGetRolesName = new SqlCommand(queryGetRoleName, Connection);
            string RolesName = (string)commandGetRolesName.ExecuteScalar();
            Program.Role = RolesName;

            // Szuka w bazie użytkownika
            SqlCommand loginCommand = new SqlCommand(loginQuery, Connection);
            int foundUsers = (int)loginCommand.ExecuteScalar();

            Connection.Close();
            // Jeżeli użytkownik istnieje i jest pracownikiem, to zwraca true
            if (foundUsers >= 1 && RolesName == "Pracownik") return true;
            return false;
        }
        /// <summary>
        /// Metoda sprawdza, czy można zalogować się na podstawie loginu i hasła na konto klienta
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool LoginClient(string login, string password)
        {
            // Przypisanie wartości loginu i hasła do zmiennych statycznych
            Program.Login = login;
            Program.Password = password;

            string queryGetRolesId = "SELECT RolesId FROM Users WHERE Login='" + login + "' AND Password='" + password + "';";
            string loginQuery = $"SELECT COUNT(*) FROM Users WHERE Login='{login}' AND Password='{password}';";

            Connection.Open();
            // Dostęp do Id Klienta
            SqlCommand commandGetRolesId = new SqlCommand(queryGetRolesId, Connection);
            int RolesId = (int)commandGetRolesId.ExecuteScalar();

            // Dostęp do Nazwy użytkownika
            string queryGetRoleName = $"SELECT Name FROM Roles WHERE Id= {RolesId};";
            SqlCommand commandGetRolesName = new SqlCommand(queryGetRoleName, Connection);
            string RolesName = (string)commandGetRolesName.ExecuteScalar();
            Program.Role = RolesName;

            // Szuka w bazie użytkownika
            SqlCommand loginCommand = new SqlCommand(loginQuery, Connection);
            int foundUsers = (int)loginCommand.ExecuteScalar();

            Connection.Close();
            // Jeżeli użytkownik istnieje i jest klientem, to zwraca true
            if (foundUsers >= 1 && RolesName == "Klient") return true;
            return false;
        }
        /// <summary>
        /// Funkcja odpowiada za przypisanie wartości do zmiennych osoby
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        public void AssignIdentity(ref string firstName,ref string lastName,ref int age)
        {
            // Zapytanie stworzone w celu zdobycia ID zalogowanego użytkownika
            string querygetPersonId = $"SELECT IdentitiesId FROM Users WHERE Login='{Program.Login}' AND Password='{Program.Password}';";
            Connection.Open();
            // Dostęp do Id osoby
            SqlCommand commandGetPersonId = new SqlCommand(querygetPersonId, Connection);
            int IdentitiesId = (int)commandGetPersonId.ExecuteScalar();

            // Zapytania w celu zdobycia informacji o konkretnej osobie
            string querygetPersonFirstName = $"SELECT FirstName FROM Identities WHERE Id={IdentitiesId};";
            string querygetPersonLastName = $"SELECT LastName FROM Identities WHERE Id={IdentitiesId};";
            string querygetPersonAge = $"SELECT Age FROM Identities WHERE Id={IdentitiesId};";

            // Pobranie informacji o konkretnej osobie
            SqlCommand commandGetPersonFirstName = new SqlCommand(querygetPersonFirstName, Connection);
            string IdentitiesFirstName = (string)commandGetPersonFirstName.ExecuteScalar();
            SqlCommand commandGetPersonLastName = new SqlCommand(querygetPersonLastName, Connection);
            string IdentitiesLastName = (string)commandGetPersonLastName.ExecuteScalar();
            SqlCommand commandGetPersonAge = new SqlCommand(querygetPersonAge, Connection);
            int IdentitiesAge = (int)commandGetPersonAge.ExecuteScalar();

            Connection.Close();
            // Przypisanie wartości do danych osobowych zalogowanego użytkownika
            firstName = IdentitiesFirstName;
            lastName = IdentitiesLastName;
            age = IdentitiesAge;
        }

    }
}
