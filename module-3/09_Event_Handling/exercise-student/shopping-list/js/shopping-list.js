let allItemsIncomplete = true;

const pageTitle = 'My Shopping List';

const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {

  const title = document.getElementById('title');

  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {

  const ul = document.querySelector('ul');

  groceries.forEach((item) => {

    const li = document.createElement('li');

    li.innerText = item.name;

    const checkCircle = document.createElement('i');

    checkCircle.setAttribute('class', 'far fa-check-circle');

    li.appendChild(checkCircle);

    ul.appendChild(li);

  });
}

// start of exercise

document.addEventListener("DOMContentLoaded", () => {

  setPageTitle();

  displayGroceries();

  const groceries = document.querySelectorAll("li");

  groceries.forEach(grocery => {

    const shoppingList = document.querySelector("ul");

    shoppingList.addEventListener("click", (e) => {

      if(!e.target.classList.contains("completed")) {

        e.target.classList.add("completed");
      }

    });
  
    grocery.addEventListener("dblclick", () => {

      if(grocery.classList.contains("completed")) {

        grocery.classList.remove("completed");

      }

    });
  
  });

  const markAllComplete = document.getElementById("toggleAll");

  markAllComplete.addEventListener('click', (e) => {

    if(allItemsIncomplete) {

      groceries.forEach(grocery => {
        
        grocery.classList.add("completed");

        markAllComplete.innerText = "Mark All Incomplete";

        allItemsIncomplete = false;

      });

    } else if(!allItemsIncomplete) {

      groceries.forEach(grocery => {
        
        grocery.classList.remove("completed");

        markAllComplete.innerText = "Mark All Complete";

        allItemsIncomplete = true;

      });

    }

  });

});
