// Uzyskanie dostępu do spanu, który wyświetla nazwę użytkownika
let spn = document.querySelector("#userGamesPage");
// Przypisanie zmiennej lokalnej z logowania do nazwy użytkownika
spn.innerHTML = localStorage.getItem('userName');
