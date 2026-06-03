let palabraOculta = "";
let intentosRestantes = 10;
let letrasUsadas = [];
let juegoTerminado = false;

function inicializarJuego() {
    const palabraSecreta = document.getElementById("palabraSecreta").value;
    palabraOculta = "_".repeat(palabraSecreta.length).split("").join(" ");
    document.getElementById("palabraOculta").textContent = palabraOculta;
    document.getElementById("intentosRestantes").textContent = intentosRestantes;
    document.getElementById("letrasUsadas").textContent = "-";
    document.getElementById("letraInput").focus();
}

function ArriesgarLetra() {
    if (juegoTerminado) {
        return;
    }
    const letraInput = document.getElementById("letraInput");
    const letra = letraInput.value.toUpperCase();
    const palabraSecreta = document.getElementById("palabraSecreta").value.toUpperCase();
    if (!letra || letra.length !== 1 || letra < "A" || letra > "Z") {
        letraInput.value = "";
        letraInput.focus();
        return;
    }
    if (letrasUsadas.includes(letra)) {
        letraInput.value = "";
        letraInput.focus();
        return;
    }
    letrasUsadas.push(letra);
    document.getElementById("letrasUsadas").textContent = letrasUsadas.join(", ");
    const palabraArray = palabraOculta.split(" ");
    let acierto = false;
    for (let i = 0; i < palabraSecreta.length; i++) {
        if (palabraSecreta[i] === letra) {
            palabraArray[i] = letra;
            acierto = true;
        }
    }
    palabraOculta = palabraArray.join(" ");
    document.getElementById("palabraOculta").textContent = palabraOculta;
    if (!acierto) {
        intentosRestantes -= 1;
        document.getElementById("intentosRestantes").textContent = intentosRestantes;
    }
    letraInput.value = "";
    letraInput.focus();
    if (!palabraOculta.includes("_")) {
        juegoTerminado = true;
        document.getElementById("mensajeFinal").textContent = "Ganaste! La palabra era " + palabraSecreta;
    }
    if (intentosRestantes <= 0) {
        juegoTerminado = true;
        document.getElementById("mensajeFinal").textContent = "Perdiste. La palabra era " + palabraSecreta;
    }
}
window.onload = inicializarJuego;
