// Zmienna zawierająca kartę, którą porównujemy
let clickedCard;
// Zmienna, obrazująca ilość znalezionych par
let foundPairs = 0;
// Zmienna, blokująca ruch w wymaganym przypadku
let yourMove = false;
// Czas na wygranie
let clock = 60;
// Pobranie spanu, do pokazania bieżącej wartości czasu
let spn = document.querySelector("#firstGameTimer");
// Pobranie przycisku rozpoczęcia gry
let buttonStart = document.querySelector('#first-game-start-button');
// Pobranie przycisku wyjścia z gry
let buttonLeave = document.querySelector('#first-game-leave');

// Rekacja na kliknięcie przycisku rozpoczęcia gry
buttonStart.addEventListener('click', (e) => {
    e.preventDefault();
    // Przyzwolenie na ruch
    yourMove = true;
    // Włączenie timera
    let timer = setInterval(() => {
        // Jeżeli czas nam minął to przegraliśmys
        if (clock === 0) {
            // Wyświetlenie odpowiedniego komunikatu
            alert("Przegrałeś");
            // Wyłączenie timera
            clearInterval(timer);
            // Refresh strony
            window.location.reload(true);
        }
        // Jeżeli czas nie minął
        else {
            // Zmniejszamy czas
            clock -= 1;
            // Przypisujemy wartość czasu do spanu
            spn.innerHTML = clock;
            // Jeżeli znaleźliśmy wszystkie pary
            if (foundPairs === 8) setTimeout(() => {
                // Znajdź czas, do zakończenia
                let time = 60 - clock;
                // Wyświetl odpowidni komunikat
                alert("Gratuluję wygrałeś, udało Ci się skączyć " + time + " sekund przed czasem!");
                // Wyłącz timer
                clearInterval(timer);
                // Refresh okna
                window.location.reload(true);
            }, 100);

        }
    }, 1000);
    // Wyłącz przycisk rozpocznij grę
    buttonStart.disabled = true;
});
// Reakcja na wciśnięcie przycisku wyjścia
buttonLeave.addEventListener('click', (e) => {
    e.preventDefault();
    window.document.location = './HtmlGamesPage.html';
});
// Tablica kolorów
const colors = [
    'red',
    'yellow',
    'green',
    'blue',
    'orange',
    'violet',
    'pink',
    'brown'
];
// Zamiana tablicy na listę
const cards = [...document.querySelectorAll('.card')];
// Pętla przyporządkowująca kolory do bloczków
for (let color of colors) {
    // Wybieramy randomowo bloczek, 
    const card1Index = parseInt(Math.random() * cards.length);
    const card1 = cards[card1Index];
    // Usuwamy go z tablicy
    cards.splice(card1Index, 1);
    // Dodajemy odpowiednie klasy do bloczku
    card1.classList.add(color);
    card1.classList.add("hide");

    // Wybieramy randomowo bloczek, 
    const card2Index = parseInt(Math.random() * cards.length);
    const card2 = cards[card2Index];
    // Usuwamy go z tablicy
    cards.splice(card2Index, 1);
    // Dodajemy odpowiednie klasy do bloczku
    card2.classList.add(color);
    card2.classList.add("hide");
}

// Funkcja obsługująca kliknięcie bloczku
function BlockClick(e) {
    // Jeżeli mamy możliwość ruchu
    if (yourMove == true) {
    // Pobieramy kliknięty bloczek
    const target = e.currentTarget;
    // Żeby nie móc nacisnąć odznaczonych bloczków
    if (target.classList.contains('done')) {
        return;
    }
    // Pokazujemy kolor bloczka
    target.classList.remove("hide");
    // Jeżeli wybieramy pierwszą kartęs
        if (!clickedCard) {
        // Przypisujemy kartę, żebyśmy mogli je porównać
        clickedCard = target;
    }
    // Jeżeli wybieramy drugą kartę
    else {
        // Jeżeli sparowaliśmy
            if (clickedCard.classList.item(1) === target.classList.item(1)) {
                // Dodajemy klasę, która nie pozwala nam zaznaczyć klocka
                clickedCard.classList.add("done");
                target.classList.add("done");
                // Zerujemy drugą kartę
                clickedCard = null;
                // Dodajemy parę do licznika
                foundPairs += 1;
            }
            // Jeżeli para się nie zgadza
            else if (clickedCard.classList.item(1) != target.classList.item(1)) {
                    // Ustawiamy timer
                    setTimeout(() => {
                    // Po dwóch sekundach chowamy bloczki
                    clickedCard.classList.add("hide");
                    target.classList.add("hide");
                    clickedCard = null;
                    // Dajemy możliwość ruchu żeby nie móc ciągle zaznaczać
                    yourMove = true;
                    }, 500);
                // Odbieramy możliwość ruchu
                yourMove = false;
            }
        }
    }
}