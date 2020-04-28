function factorsOf() {
	var nmbr = prompt("Number");
	document.getElementById("factorsOfOutput").innerHTML = "The factors of " + nmbr + " are<br/>";
	for (var i = 1; i <= nmbr; i++) {
		if (nmbr / i === Math.round(nmbr / i)) {
			document.getElementById("factorsOfOutput").innerHTML += i + "<br/>"
		}
	}
}
function add() {
	var a = prompt("First Number") * 1;
	var b = prompt("Second Number") * 1;
	document.getElementById("output").innerHTML = a + " + " + b + " = " + (a + b) + "<br/>" + document.getElementById("output").innerHTML;
}
function mul() {
	var a = prompt("First Number") * 1;
	var b = prompt("Second Number") * 1;
	document.getElementById("output").innerHTML = a + " * " + b + " = " + (a * b) + "<br/>" + document.getElementById("output").innerHTML;
}
function exp() {
	var a = prompt("Base") * 1;
	var b = prompt("Exponent") * 1;
	document.getElementById("output").innerHTML = a + " <sup> " + b + "</sup> = " + Math.pow(a, b) + "<br/>" + document.getElementById("output").innerHTML;
}
function sub() {
	var a = prompt("First Number") * 1;
	var b = prompt("Second Number") * 1;
	document.getElementById("output").innerHTML = a + " - " + b + " = " + (a - b) + "<br/>" + document.getElementById("output").innerHTML;
}
function div() {
	var a = prompt("First Number") * 1;
	var b = prompt("Second Number") * 1;
	document.getElementById("output").innerHTML = a + " / " + b + " = " + (a / b) + "<br/>" + document.getElementById("output").innerHTML;
}
function log() {
	var a = prompt("Base") * 1;
	var b = prompt("Number") * 1;
	document.getElementById("output").innerHTML = "log<sub>" + a + "</sub>" + b + " = " + (Math.log(a) / Math.log(b)) + "<br/>" + document.getElementById("output").innerHTML;
}
