const email = document.getElementById('email');
const pass=document.getElementById('password');
const emailDiv=document.querySelector('.mail');
const passDiv=document.querySelector('.pass');
const logButton=document.getElementById('login-button');
const ShowPassword=document.getElementById('show-password');

var emailRegex=/^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;

function EmailCheck(){
	var emailInput=email.value;
	if(emailInput=="" || emailInput.length<6){
		emailDiv.style.borderColor="red";
		return false;
	}
	else if(!emailRegex.test(emailInput)){
		emailDiv.style.borderColor="red";
		return false;
	}
	else{
		//
		emailDiv.style.borderColor="gray";
		return true;
	}

}

function PasswordCheck(){
	passInput=pass.value;
	
	if(passInput=="" || passInput.length<6){
		passDiv.style.borderColor="red";
		return false;
	}
	else{
		passDiv.style.borderColor="gray";
		return true;
	}
}

email.addEventListener('keyup',()=>{

	if(EmailCheck()==true){
		passDiv.style.display="block";
	}
	else{
		passDiv.style.display="none";
	}
});


pass.addEventListener('keyup',()=>{
	if(EmailCheck()==true){

		if(PasswordCheck()==true){
			logButton.disable=false;
			logButton.classList.add('login-active');
			logButton.classList.remove('login-passive');
		}
		else{
			logButton.disable=true;
			logButton.classList.add('login-passive');

			logButton.classList.remove('login-active');
		}
	}
	else{
		logButton.disable=true;
		logButton.classList.add('login-passive');
		logButton.classList.remove('login-active');
	}



});


ShowPassword.addEventListener('click',()=>{
		if(pass.type==="password"){
			pass.type="text";
			ShowPassword.classList.add("fa-lock-open");
			ShowPassword.classList.remove("fa-lock");
		}
		else{
			pass.type="password";
			ShowPassword.classList.remove("fa-lock-open");
			ShowPassword.classList.add("fa-lock");
		}
});