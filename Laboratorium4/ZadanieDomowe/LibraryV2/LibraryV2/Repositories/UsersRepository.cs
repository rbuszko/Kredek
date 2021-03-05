using LibraryV2.Models.Entities;
using LibraryV2.Repositories.Interfaces;
using LibraryV2.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryV2.Repositories
{
    class UsersRepository : Repository, IUsersRepository
    {
        /// <summary>
        /// Metoda pozwala dodać osobę do bazy danych
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        public bool AddIdentity(string firstName, string lastName, int age, byte[] image)
        {
            // Tworzymy osobę, który zostanie dodany
            Identities identitiesToAdd = new Identities()
            {
                // Określamy parametry
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Image = image
            };
            // Dodajemy osobę do bazy
            DataBaseContext.Identities.Add(identitiesToAdd);
            // Jeżeli została dodany, to zwracamy true
            return DataBaseContext.SaveChanges() > 0;
        }
        /// <summary>
        /// Metoda do pobrania wszystkich użytkowników z tabeli Users
        /// </summary>
        /// <returns></returns>
        public List<UsersViewModel> GetUsers()
        {
            List<Users> users = DataBaseContext.Users.ToList();
            return Mapper.Map<List<Users>, List<UsersViewModel>>(users);
        }
        /// <summary>
        /// Metoda spradzająca czy można się zalogować do aplikacji na podstawie loginu, hasła i rodzaju użytkownika
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="who"></param>
        /// <returns></returns>
        public bool CheckUser(string login, string password, string who)
        {
            // Sprawdzamy, czy użytkownik o podanych paramterach znajduje się w bazie
            Users users = DataBaseContext.Users.SingleOrDefault(u => u.Login == login && u.Password == password && u.Roles.Name == who);
            // Przypisujemy zalogowanego użytkownika
            Program.user = login;
            // Zwracamy true jeżeli jest
            return users != null;
        }
        /// <summary>
        /// Metoda do pobrania wszystkich danych osobowych z tabeli Identities
        /// </summary>
        /// <returns></returns>
        public List<Identities> GetIdentities()
        {
            return DataBaseContext.Identities.ToList();
        }
        /// <summary>
        /// Metoda pozwala dodać użytkownika do bazy
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="personId"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool AddUser(string login, string password, int personId, string role)
        {
            // Sprawdzmy, czy istnieje podana rola
            Roles roleOfUser = DataBaseContext.Roles.SingleOrDefault(r => r.Name == role);
            if (roleOfUser == null) return false;
            // Tworzymy użytkownika o podanych parametrach
            Users usersToAdd = new Users()
            {
                Login = login,
                Password = password,
                IdentitiesId = personId,
                Roles = roleOfUser
            };
            // Sprawdzamy, czy podany login istnieje już w bazie danych
            Users foundedUser = DataBaseContext.Users.FirstOrDefault(u => u.Login == login);
            // Jeżeli tak, to wyświetlamy odpowiedni komunikat, jeżeli nie, to dodajemy
            // użytkownika do bazy
            if (foundedUser != null) MessageBox.Show("Taki użytkownik już istnieje!");
            else DataBaseContext.Users.Add(usersToAdd);
            // Jeżeli użytkownik został dodany zwracamy true
            return DataBaseContext.SaveChanges() > 0;
        }
        /// <summary>
        /// Metoda pozwala usunąć użytkownika z bazy
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool DeleteUser(int userId)
        {
            // Znajdujemy obiekt do usunięcia
            Users user = DataBaseContext.Users.SingleOrDefault(u => u.Id == userId);
            // Jeżeli nie to zwróć false
            if (user == null) return false;
            // Usunięcie użytkownika z bazy
            DataBaseContext.Users.Remove(user);
            // Jeżeli się udało, to zwróć true
            return DataBaseContext.SaveChanges() > 0;
        }

        public bool EditUser(int userId, string login, string password, int personId, string role)
        {
            // Znajdujemy obiekt do edycji
            Users user = DataBaseContext.Users.SingleOrDefault(u => u.Id == userId);
            // Sprawdzamy, czy podany rodzaj użytkownika istnieje
            Roles roleOfUser = DataBaseContext.Roles.SingleOrDefault(r => r.Name == role);
            // Jeżeli nie to zwróć false
            if (user == null || roleOfUser == null)
                return false;

            //zmieniamy właściwości obiektu
            user.Login = login;
            user.Password = password;
            user.IdentitiesId = personId;
            user.Roles = roleOfUser;

            //zapisujemy zmiane
            return DataBaseContext.SaveChanges() > 0;
        }
    }
}
