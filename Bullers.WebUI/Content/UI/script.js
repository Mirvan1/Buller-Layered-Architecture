const resMenu=document.getElementById('res-menu');
const menuList=document.getElementById('menu-list');
const resList=document.getElementById('res-list');
const logo=document.querySelector('.logo');


logo.addEventListener("click",()=>{
	logo.classList.toggle("rotate-logo");
});

resMenu.addEventListener('click',()=>{

	resList.classList.toggle("passive");
});
