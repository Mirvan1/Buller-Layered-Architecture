const category=document.getElementById('category-select');

	const formElement=document.getElementById('form-nodiv');
	console.log(formElement.childNodes[4]);
function deleteBeforeNodes(param){
		//var fourChild=document.getElementsByClassName('created-element-'+param);	
 			
		for(var i=0;i<category.length;i++){
			if(i==param){
				continue;
			}
			// console.log(document.getElementsByClassName('created-element-'+i)[i+1]);
		var selectChild=document.getElementsByClassName('created-element-'+i);
			let j=0;
			while(selectChild.length){
			    if(selectChild[j]==null){
					break;
				}
				else{
				selectChild[j].style.display='none';
				selectChild[j].innerHTML="";
				}
				j++;
		    }


		}


}

category.addEventListener('change',()=>{

	if(category.selectedIndex=="1"){
	var sexDiv=document.createElement('div');
		sexDiv.setAttribute('class','field-product created-element-1');
		sexDiv.innerHTML=`<label>Sex</label>
					<select name="ProductSex" id="sex-select">
						 <option value="0">Male</option>
						 <option value="1">Female</option>
						 <option value="2">Unisex</option>
					</select>`;
		formElement.insertBefore(sexDiv,formElement.childNodes[4]);


	var ItemDiv=document.createElement('div');
		ItemDiv.setAttribute('class','field-product created-element-1');
		
		ItemDiv.innerHTML=`<label>Item Name</label>
					<input type="text" name="ProductName">`;
		formElement.insertBefore(ItemDiv,formElement.childNodes[5]);


		deleteBeforeNodes(1);		
	}




	if(category.selectedIndex=="2"){

	var ItemNameDiv=document.createElement('div');
		ItemNameDiv.setAttribute('class','field-product created-element-2');
		
		ItemNameDiv.innerHTML=`<label>Item Name</label>
					<input type="text" name="ElectronicsName">`;
		formElement.insertBefore(ItemNameDiv,formElement.childNodes[4]);

		deleteBeforeNodes(2);		
	}




	if(category.selectedIndex=="3"){

	var VehicleNameDiv=document.createElement('div');
		VehicleNameDiv.setAttribute('class','field-product created-element-3');
		
		VehicleNameDiv.innerHTML=`<label>Vehicle Name</label>
					<input type="text" name="VehicleName">`;
		formElement.insertBefore(VehicleNameDiv,formElement.childNodes[4]);

	var vehicleColorDiv=document.createElement('div');
		vehicleColorDiv.setAttribute('class','field-product created-element-3');
		
		vehicleColorDiv.innerHTML=`<label> Color</label>
					<input type="text" name="VehicleColor">`;
		formElement.insertBefore(vehicleColorDiv,formElement.childNodes[5]);


	var vehicleMotorrDiv=document.createElement('div');
		vehicleMotorrDiv.setAttribute('class','field-product created-element-3');
		
		vehicleMotorrDiv.innerHTML=`<label> Motor</label>
					<input type="text" name="VehicleMotor">`;
		formElement.insertBefore(vehicleMotorrDiv,formElement.childNodes[6]);

	var vehicleYearDiv=document.createElement('div');
		vehicleYearDiv.setAttribute('class','field-product created-element-3');
		
		vehicleYearDiv.innerHTML=`<label> Year</label>
					<input type="text" name="VehicleYear">`;
		formElement.insertBefore(vehicleYearDiv,formElement.childNodes[7]);



		deleteBeforeNodes(3);		
	}

















	if(category.selectedIndex=="4"){
		
		var AdTypeDiv=document.createElement('div');
		AdTypeDiv.setAttribute('class','field-product created-element-4');
		AdTypeDiv.innerHTML=`<label>Ad Type</label>
					<select name="AdType" id="ad-type-select">
						 <option value="0">Sale</option>
						 <option value="1">Hire</option>
					</select>`;
		formElement.insertBefore(AdTypeDiv,formElement.childNodes[4]);


		var AreaDiv=document.createElement('div');
		AreaDiv.setAttribute('class','field-product created-element-4');
		AreaDiv.innerHTML=`<label>Area,m<sup>2</sup></label>
					<input type="text" name="Area">`;
		formElement.insertBefore(AreaDiv,formElement.childNodes[5]);



		var RoomDiv=document.createElement('div');
		RoomDiv.setAttribute('class','field-product created-element-4');
		RoomDiv.innerHTML=`<label>Room</label>
					<input type="text" name="totalRoom">`;
		formElement.insertBefore(RoomDiv,formElement.childNodes[6]);
		deleteBeforeNodes(4)

	}





if(category.selectedIndex=="5"){

	var HobbyNameDiv=document.createElement('div');
		HobbyNameDiv.setAttribute('class','field-product created-element-5');
		
		HobbyNameDiv.innerHTML=`<label>Hobby Name</label>
					<input type="text" name="">`;
		formElement.insertBefore(HobbyNameDiv,formElement.childNodes[4]);

		deleteBeforeNodes(5);		
	}




	if(category.selectedIndex=="6"){

	var JobFieldDiv=document.createElement('div');
		JobFieldDiv.setAttribute('class','field-product created-element-6');
		
		JobFieldDiv.innerHTML=`<label>Job Field</label>
					<input type="text" name="">`;
		formElement.insertBefore(JobFieldDiv,formElement.childNodes[4]);


	var ExperienceDiv=document.createElement('div');
		ExperienceDiv.setAttribute('class','field-product created-element-6');
		
		ExperienceDiv.innerHTML=`<label>Experience</label>
					<input type="text" name="">`;
		formElement.insertBefore(ExperienceDiv,formElement.childNodes[5]);

		deleteBeforeNodes(6);		
	}






});

