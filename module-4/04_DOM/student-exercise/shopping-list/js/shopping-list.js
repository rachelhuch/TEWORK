 const pageTitle= "My Shopping List";

// add groceries
const groceries = ['Milk', 'Eggs', 'Bread', 'Scandinavian Swimmers', 'Spinach', 'Diet Coke', 'Chicken', 'Toilet Paper', 'Bell Peppers', 'Cinnamon Roles' ];
/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  document.querySelector('#title').innerText=pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  let ul= document.getElementById('groceries');

  groceries.forEach(grocery => {
    let li= document.createElement('li');
    li.innerText=grocery;
    ul.insertAdjacentElement('beforeend', li);
  });
  

}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted(){
  let AllNodes = document.getElementById('groceries').childNodes;
  AllNodes.forEach( node => {
    if(node.nodeName =='LI'){
      node.classList.add('completed');
    }
  });
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
