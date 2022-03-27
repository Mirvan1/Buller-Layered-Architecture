const searchInput=document.getElementById('searchBar');
const searchIcon=document.getElementById('searchIcon');
const addButton=document.getElementById('new-ad-button');
const productName=document.getElementsByClassName('name-product');
const productNameOfDiv=document.getElementsByClassName('product-card');
const productLocationInDiv=document.querySelectorAll('.card-title span small');


function adjustSearchs(){

if(self.innerWidth<450)
{
	searchInput.style.display='none';
	searchIcon.classList.add('effectSearch');
}
else{
	// document.body.classList.toggle('effect');
	searchInput.style.display='block';

	searchIcon.classList.remove('effectSearch');
}

if(self.innerWidth<600){
	addButton.innerHTML=`<i class="fa-solid fa-plus"></i>`;
}
else{
	addButton.innerHTML=`<i class="fa-solid fa-plus"></i> New Ad`;
}

if(self.innerWidth<600 && self.innerWidth>400){
	searchIcon.style.transform="translateX(-80%)";
}
else{
searchIcon.style.transform="translateX(0%)";	
}

 }



window.addEventListener('resize',adjustSearchs);
window.addEventListener('load',adjustSearchs);

searchIcon.addEventListener('click',()=>{
	if(searchInput.style.display=='none'){
	searchInput.style.display='block';
	searchIcon.classList.remove('effectSearch');
}
else{
		searchInput.style.display='none';
	searchIcon.classList.add('effectSearch');
}
});


function searchItems(){
	search=searchInput.value.toUpperCase();
	for(var i=0;i<productName.length;i++){
		nameVal=productName[i].textContent || productName[i].innerText ;
		locationVal=productLocationInDiv[i].textContent ||productLocationInDiv[i].innerText ;
		 console.log(productLocationInDiv[i].textContent);

		if(nameVal.toUpperCase().indexOf(search)>-1 || locationVal.toUpperCase().indexOf(search)>-1){
			productNameOfDiv[i].style.display='block';

		}
		else{
			productNameOfDiv[i].style.display='none';
		}
	};

}

searchInput.addEventListener("keyup",searchItems);

