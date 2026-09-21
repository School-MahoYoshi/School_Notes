
function kiir() {
    const eredmeny = document.getElementById("result");
    eredmeny.innerText = "Valami szöveg";
}
function terulet(a, b) {
    const eredmeny = document.getElementById("result");

    let t = a * b;
    eredmeny.innerText = t;
}

document.getElementById("szoveg").addEventListener("click", kiir)
document.getElementById("szamol").addEventListener("click", () => terulet(2, 6))