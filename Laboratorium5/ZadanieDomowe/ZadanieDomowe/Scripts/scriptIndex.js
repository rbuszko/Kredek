// Przycisk logowania
let button = document.querySelector('#log-in');

// Reakcja przycisku logowania na kliknięcie
button.addEventListener('click', (e) => {
    // Zmienna posiadająca wartość wpisanej nazwy użytkownika
    let username = document.getElementById("login-input");

    e.preventDefault();
    // Jeżeli użytkownik nie podał żadnej nazwy
    if (username.value != "") {
        // Dodajemy zmienną do schowka, ta zmienna jest wykorzystywana w oknie z gramis
        localStorage.setItem('userName', username.value);
        // Otwarcie okna gier
        window.document.location = './Pages/HtmlGamesPage.html';
    }
    // Jeżeli użytkownik podał nazwę
    else {
        // Ustawienie timera na pokazanie informacji o braku wpisania nazwy
        username.nextElementSibling.textContent = "Nie wpisałeś nazwy użytkownika";
        setTimeout(() => {
            username.nextElementSibling.textContent = "";
        }, 2000);
    }
});