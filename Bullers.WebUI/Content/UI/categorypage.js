// const divCategory=document.getElementsByClassName('circle-category');
// console.log(divCategory);

const divQuer=document.querySelectorAll('.circle-category');
const titleContent = document.querySelector('.ads-bar h5');
console.log(window.location.href);
var urlPage = window.location.href;
if (urlPage.includes("?")) {
	var categoryNameFound = urlPage.indexOf("=");
	titleContent.innerHTML = urlPage.slice(categoryNameFound+1, urlPage.length);
}
else {
	titleContent.innerHTML = "Latest Ads";
}

	//divQuer.forEach(function(divC){
	//	divC.addEventListener('click',()=>{
	//	var x=divC.querySelector('span').textContent;
		
	//	if(x!=null || x!=""){
	//		titleContent.innerHTML = x;
	//	}
	//	else{
	//		titleContent.innerHTML="Latest Ads";
	//		}
			
	//});

	//});



