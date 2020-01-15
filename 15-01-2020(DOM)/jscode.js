function changeStyle()
{
	var paragraph = document.getElementsByClassName('para');

	var firstParaText = paragraph[0].innerHTML;
	var secondParaText = paragraph[1].innerHTML;
	var addThen = paragraph[2].innerHTML = firstParaText + secondParaText ;

	var firstParaText = paragraph[0].innerHTML = " ";
	var secondParaText = paragraph[1].innerHTML = " ";

}