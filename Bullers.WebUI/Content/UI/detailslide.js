const slider=document.getElementsByClassName('slider');
const nextB=document.getElementById('next');
const prevB=document.getElementById('prev');


var slideIndex=0;
var temp=slider[0].src;



function arrows(index){
	if(slideIndex>=slider.length-1){
		slideIndex=0;
		ChangeSrc(++slideIndex);	
	}
	else if(slideIndex<=0){
		slideIndex=slider.length-1;
		ChangeSrc(slideIndex--);
	}
	else{
	ChangeSrc(slideIndex+=index);
	}
}

function ChangeSrc(slideIndex){
	

	slider[0].src=slider[slideIndex].src;

}

nextB.addEventListener('click',arrows(1));
 prevB.addEventListener('click',arrows(-1));