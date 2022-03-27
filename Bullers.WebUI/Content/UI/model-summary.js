
function showsModelState() {
	const divUl = document.querySelector("#errors ul");
	const errorDiv = document.querySelector(".validation-errors");
	console.log(divUl.getElementsByTagName("li").length);
	if (divUl.getElementsByTagName("li").length > 1) {
		errorDiv.style.display = "block";
	}
	else {
		errorDiv.style.display = "none";
	}
}

showsModelState();