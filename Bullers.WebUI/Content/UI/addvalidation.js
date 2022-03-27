const categorySelect=document.getElementById('category-select');
const citySelect=document.getElementById('city-select');
const Price=document.getElementById('Price');
const Description=document.getElementById('Description');
const Name=document.getElementById('Name');
const Email=document.getElementById('Email');
const Phone=document.getElementById('Phone');
const PriceSpan=document.getElementById('price-span');
const submitButton=document.getElementById('add-form-button');
const formTag = document.getElementById('form-nodiv');
//submitButton.disabled=true;

const DescSpan=document.getElementById('desc-span');

const valErrors=document.getElementById('errors');
const valErrorsDiv=document.querySelector('.validation-errors');


const validateEmail = (email) => {
  return String(email)
    .toLowerCase()
    .match(
      /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    );
};

let numberRegex="\d";

function PriceValidation(){
	if(Price.value==""  || Price.value==null ){
		Price.style.borderColor="red";
		return false;
	}
	else{
			Price.style.borderColor="blue";
			return true;
	}
}

function DescriptionValidation(){
	if(Description.value.trim()=="" || Description.value==null 
			 ){
			Description.style.borderColor="red";
		return false;
		}
		else if(Description.value.length<5){
			Description.style.borderColor="red";
			return false;
		}
		else{
			Description.style.borderColor="blue";
			return true;
		}
}

function NameValidation(){
	if(Name.value.trim()=="" || Name.value==null || Name.value.length<=2){
		Name.style.borderColor="red";
		return false;
	}
	else{
		Name.style.borderColor="blue";
		return true;
	}
}

function EmailValidation(){
	if(Email.value.trim()=="" || Email.value==null || Email.value<=7 || validateEmail(Email.value)==null){
		Email.style.borderColor="red";
		return false;
	}
	else{
		Email.style.borderColor="blue";	
		return true;
	}
}

function PhoneValidation(){
	if(Phone.value.trim()=="" || Phone.value==null || Phone.value.length<=8){
		Phone.style.borderColor="red";	
		return false;
	}
	else{
		Phone.style.borderColor="blue";
		return true;
	}
}


function FormValidation(){
		if(!PriceValidation()){
			valErrorsDiv.style.display="block";
			valErrors.innerHTML+="*Price field must not be blank"+"<br/>";
			//console.log(PriceValidation())
			
		}
		 if(!DescriptionValidation()){
			valErrorsDiv.style.display="block";	
			valErrors.innerHTML+="*Description at least 5 charachters"+"<br/>";
			
		}
		 if(!NameValidation()){
			valErrorsDiv.style.display="block";	
			valErrors.innerHTML+="*Name field must not be blank"+"<br/>";
			
		}
		 if(!EmailValidation()) {
			valErrorsDiv.style.display="block";	
			valErrors.innerHTML+="*Email is not valid"+"<br/>";
		

		}
		 if(!PhoneValidation()){
			valErrorsDiv.style.display="block";	
			valErrors.innerHTML+="*Phone is not valid"+"<br/>";
		}
		else{

			valErrorsDiv.style.display="none";
			
		}
}

Price.addEventListener("keyup",PriceValidation);


Description.addEventListener("keyup",DescriptionValidation);

Name.addEventListener("keyup",NameValidation);
Email.addEventListener("keyup",EmailValidation);


Phone.addEventListener("keyup",PhoneValidation);

	
formTag.addEventListener("submit",()=>{
		//valErrors.innerHTML="";
		/*e.preventDefault();*/
	console.log(PriceValidation()+" ds");
	FormValidation();

			
});
