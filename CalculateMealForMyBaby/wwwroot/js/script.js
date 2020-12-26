const clickStart = document.querySelector('.buttClick');
const getDiv = document.querySelector('.formStyle');

function addForm(event) {
    event.preventDefault();
    getDiv.style.display = "block";
}

clickStart.addEventListener("click", addForm);