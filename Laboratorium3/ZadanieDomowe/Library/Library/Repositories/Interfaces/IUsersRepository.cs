namespace Library.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Users
    /// </summary>
    interface IUsersRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda do logowania na konto pracownika z tabeli Users na podstawie loginu, hasła i roli
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool LoginWorker(string login, string password);
        /// <summary>
        /// Abstrakcyjna metoda do logowania na konto klienta z tabeli Users na podstawie loginu, hasła i roli
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool LoginClient(string login, string password);
        /// <summary>
        /// Abstrakcyjna metoda, która ustawia wartości konkretnej osoby
        /// jest wykonywana w celu zdobycia danych osobowych zalogowanej osoby
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        void AssignIdentity(ref string firstName,ref string lastName,ref int age);

    }
}
