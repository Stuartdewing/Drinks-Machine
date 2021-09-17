// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const TextDisplay = document.getElementById("textDisplay");
let button = document.getElementById("button");
let select = document.getElementById("select");

function PopulateDrinkList() {
	$.ajax({
		url: '/Home/DrinkList',
		type: "GET",
		dataType: "json",
		success: function (result) {

			let newoption = document.createElement("option");
			newoption.text = "- Select Drink -";
			newoption.value = "0";
			let select = document.getElementById("select");
			select.append(newoption);
			
			for (i = 0; i < result.length; i++) {
				let drinkname = result[i];
// creates <option> and adds to <select> 
				let newoption = document.createElement("option");
				newoption.text = drinkname;
				newoption.value = drinkname;
				let select = document.getElementById("select");
				select.add(newoption);
// re orders <options> in alphabetical order
				$(function () {
					var select = $('select');
// sorts <option> in targeted <select> in alphabetical order
					select.html(select.find('option').sort(function (x, y) { return $(x).text() > $(y).text() ? 1 : -1; }));
				});
			}

		
		},
		error: function (jqXHR, textStatus, errorThrow) {
			console.log("Error!!!! PopulateDrinkList - Ajax", textStatus, errorThrow);
		}
	});
}

PopulateDrinkList();

// Event lisnter for drink selection <select>
$('select').on('change', function () {
	
	select.style.display = "none";
	button.style.display = "block";

	let DrinkSelection = this.value;

	$(TextDisplay).html("Your drink is being prepared.....");

	function DisplayRecipe() {
		$.ajax({
			url: '/Home/RecipeList',
			type: "GET",
			dataType: "json",
			data:{
				drink: DrinkSelection
			},
			success: function (result) {

				console.log(result);
				
				let i = 0;									

				function myLoop() {							
					setTimeout(function () {				
						$(TextDisplay).html(result[i]);		
						i++;								
						if (i < result.length) {			
							myLoop();						
						}									
					}, 3000)
				}

				myLoop();									

			},
			error: function (jqXHR, textStatus, errorThrow) {
				console.log("Error!!!! Display Recipe - Ajax", textStatus, errorThrow);
			}
		});
	}
	DisplayRecipe();
});


//$('button').click(function () {
//	console.log("Click");
//};
$(document).ready(function () {
	$("#button").click(function () {
		select.style.display = "block";
		button.style.display = "none";
	});
});



