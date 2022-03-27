const email = document.getElementById('email');
const pass = document.getElementById('password');
const username = document.getElementById('username');
const emailDiv = document.querySelector('.register-mail');
const passDiv = document.querySelector('.register-pass');
const userNameDiv = document.querySelector('.register-username');
const logButton = document.getElementById('reg-button');
const ShowPassword = document.getElementById('show-password-r');

var emailRegex = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
	console.log("sfsd:"+userNameDiv);
function EmailCheck() {
	var emailInput = email.value;
	if (emailInput == "" || emailInput.length < 6) {
		emailDiv.style.borderColor = "red";
		return false;
	}
	else if (!emailRegex.test(emailInput)) {
		emailDiv.style.borderColor = "red";
		return false;
	}
	else {
		//
		emailDiv.style.borderColor = "gray";
		return true;
	}

}

function PasswordCheck() {
	passInput = pass.value;

	if (passInput == "" || passInput.length < 6) {
		passDiv.style.borderColor = "red";
		return false;
	}
	else {
		passDiv.style.borderColor = "gray";
		return true;
	}
}

function UsernameCheck() {
	usernameInput = username.value;

	if (usernameInput == "" || usernameInput.length < 6) {
		userNameDiv.style.borderColor = "red";
		return false;
	}
	else {
		userNameDiv.style.borderColor = "gray";
		return true;
	}
}



email.addEventListener('keyup', () => {

	if (EmailCheck() == true) {
		userNameDiv.style.display = "block";
	}
	else {
		userNameDiv.style.display = "none";
	}
});

username.addEventListener('keyup', () => {
	

	if (UsernameCheck() == true) {
		passDiv.style.display = "block";

	}
	else {
		passDiv.style.display = "none";
	}
});

pass.addEventListener('keyup', () => {
	if (EmailCheck() == true) {

		if (PasswordCheck() == true) {
			logButton.disable = false;
			logButton.classList.add('reg-active');
			logButton.classList.remove('reg-passive');
		}
		else {
			logButton.disable = true;
			logButton.classList.add('reg-passive');

			logButton.classList.remove('reg-active');
		}
	}
	else {
		logButton.disable = true;
		logButton.classList.add('reg-passive');
		logButton.classList.remove('reg-active');
	}



});


ShowPassword.addEventListener('click', () => {
	if (pass.type === "password") {
		pass.type = "text";
		ShowPassword.classList.add("fa-lock-open");
		ShowPassword.classList.remove("fa-lock");
	}
	else {
		pass.type = "password";
		ShowPassword.classList.remove("fa-lock-open");
		ShowPassword.classList.add("fa-lock");
	}
});