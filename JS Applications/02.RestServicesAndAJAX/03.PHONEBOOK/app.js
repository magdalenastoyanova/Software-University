function attachEvents() {
   const url = 'https://phonebook-nakov.firebaseio.com/phonebook.json';
   
   let loadBtn = document.getElementById('btnLoad');
   let createBtn = document.getElementById('btnCreate');

   let ulEl = document.getElementById('phonebook');

   loadBtn.addEventListener('click', () =>{
     fetch(url)
        .then(response => response.json())
        .then((data) => {
            Object.keys(data).forEach((key) => {
           let  li = document.createElement('li'); 
           li.textContent = `${data[key].person}: ${data[key].phone}`;
           let deleteBtn = document.createElement('button'); 
           deleteBtn.textContent = 'Delete';
           deleteBtn.addEventListener('click', () => {del(key)});

           li.appendChild(deleteBtn);

           ulEl.appendChild(li);
        });
      });
    });

    createBtn.addEventListener('click', create);

    function del(key) {
        let deleteUrl = `https://phonebook-nakov.firebaseio.com/phonebook/${key}.json`;
        fetch(deleteUrl, {method: 'DELETE'});
    }

    function create() {
        let person = document.getElementById('person');
        let phone = document.getElementById('phone');


        fetch(url, {
            method: 'POST',
             body: JSON.stringify({person: person.value, phone: phone.value})
            });
    }    
}


 attachEvents();