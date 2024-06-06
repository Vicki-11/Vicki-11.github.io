body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    background-color: #0d1b3d; /* Tło ciemnoniebieskie */
    color: #fff; /* Biały tekst */
}

header {
    background-color: #1f2f57; /* Ciemnoniebieski nagłówek */
    color: white;
    padding: 10px 0;
    text-align: center;
}

nav ul {
    list-style: none;
    padding: 0;
    margin: 0;
    display: flex;
    justify-content: center;
}

nav ul li {
    margin: 0 15px;
}

nav ul li a {
    color: white;
    text-decoration: none;
    font-size: 18px;
}

section {
    padding: 60px 20px; /* Większe odstępy */
    text-align: center;
    background: #0d1b3d; /* Tło ciemnoniebieskie */
}

section:nth-of-type(odd) {
    background: #162a4f; /* Trochę jaśniejsze tło dla nieparzystych sekcji */
}

h1, h2 {
    color: #00d8ff; /* Turkusowy kolor nagłówków */
}

button {
    padding: 10px 20px;
    margin-top: 10px;
    cursor: pointer;
    background-color: #00d8ff; /* Turkusowy kolor przycisku */
    color: #0d1b3d; /* Ciemnoniebieski tekst */
    border: none;
    border-radius: 5px;
}

footer {
    background-color: #1f2f57;
    color: white;
    text-align: center;
    padding: 10px 0;
    position: fixed;
    bottom: 0;
    width: 100%;
}

.project {
    margin: 20px 0;
}

form {
    display: flex;
    flex-direction: column;
    align-items: center;
}

form label {
    margin: 10px 0 5px;
}

form input, form textarea {
    margin: 5px 0;
    padding: 10px;
    width: 300px;
    max-width: 100%;
    border: none;
    border-radius: 5px;
}

input, textarea {
    color: #0d1b3d; /* Ciemnoniebieski tekst */
}
