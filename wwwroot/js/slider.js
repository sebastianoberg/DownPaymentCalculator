var slider = document.getElementById("cashContribution");
var output = document.getElementById("demo");

output.innerHTML = slider.value;

slider.oninput = function () {
    output.innerHTML = this.value;
}